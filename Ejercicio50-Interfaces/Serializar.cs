﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50_Interfaces
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto Leìdo", typeof(V));
        }
    }
}
