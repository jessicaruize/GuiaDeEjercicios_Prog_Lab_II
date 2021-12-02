using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void EncargadoTiempo();
    public sealed class Temporizador
    {
        private CancellationToken cancellationToken;
        private CancellationTokenSource cancellationTokenSource;
        private Task hilo;
        private int intervalo;
        public event EncargadoTiempo EventoTiempo;

        public bool EstaActivo
        {
            get
            {
                //si no es null, si esta corriendo, si esta esperando por iniciarse, si esta esperando por una activacion.
                return (hilo is not null && (hilo.Status == TaskStatus.Running || hilo.Status == TaskStatus.WaitingToRun || hilo.Status == TaskStatus.WaitingForActivation));
            }
            set
            {
                if(value && !this.EstaActivo)
                {
                    this.cancellationTokenSource = new CancellationTokenSource();
                    this.cancellationToken = this.cancellationTokenSource.Token;
                    this.hilo = new Task(this.CorrerTiempo, this.cancellationToken);
                    hilo.Start();
                }
                else
                {
                    this.cancellationTokenSource.Cancel();
                }

            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        private void CorrerTiempo()
        {
            do
            {
                if(this.EventoTiempo is not null)
                {
                    this.EventoTiempo.Invoke();
                }
                Thread.Sleep(this.Intervalo);
            } while (!cancellationToken.IsCancellationRequested);
        }

    }
}
