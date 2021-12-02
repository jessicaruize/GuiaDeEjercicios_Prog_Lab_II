using Ejercicio43;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio46_TestUnitarios
{
    [TestClass]
    public class TestEjercicio43
    {
        [TestMethod]
        public void Competencia_CrearUnaCompetencia_ListaDeVehiculosEesteInstanciada()
        {
            //Arrenge
            Competencia competencia;
            //Acte
            competencia = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            //Assert
            Assert.IsNotNull(competencia.Competidores);
        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Competencia_AgregarF1ACompetenciaMotoCross_LanzaException()
        {
            //Arrenge
            Competencia cM = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a = new AutoF1(10, "ODS23");
            //Acte
            bool aux= cM + a;
            //Assert
        }
        [TestMethod]
        public void Competencia_AgregarMotoCrossACompetenciaMotoCross_NoLanzaException()
        {
            //Arrenge
            Competencia cM = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(10, "UGF23");
            //Acte
            bool aux = cM + m;
            //Assert
            Assert.IsTrue(aux);
        }
        [TestMethod]
        public void Competencia_AgregarMotoCrossACompetenciaMotoCross_EsteEnLaLista()
        {
            //Arrenge
            Competencia cM = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(10, "UGF23");
            //Acte
            bool aux = cM + m;
            //Assert
            Assert.IsTrue(cM.Competidores.Contains(m));
        }
        [TestMethod]
        public void Competencia_QuitarMotoCrossACompetenciaMotoCross_NoesteEnLaLista()
        {
            //Arrenge
            Competencia cM = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(10, "UGF23");
            //Acte
            bool aux = cM + m;
            aux = cM - m;
            //Assert
            Assert.IsFalse(cM.Competidores.Contains(m));
        }

    }
}
