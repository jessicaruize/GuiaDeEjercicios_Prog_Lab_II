using Ejercicio42;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ejercicio45_TestUnitarios
{
    [TestClass]
    public class TestEjercicio42
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClase_AlIntanciarConConstructorSinParametro_LanzaException()
        {
            //Arrenge
            MiClase miClase;
            //Acte
            miClase = new MiClase();
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClase_AlIntanciarConConstructorConParametro_LanzaException()
        {
            //Arrenge
            MiClase miClase;
            //Acte
            miClase = new MiClase(8);
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClase_AlUsarMiMetodo_LanzaException()
        {
            //Arrenge
            //Acte
            float f = MiClase.MiMetodo();
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void OtraClase_AlIntanciar_LanzaException()
        {
            //Arrenge
            OtraClase miClase;
            //Acte
            miClase = new OtraClase();
            //Assert
        }




        //Arrenge
        //Acte
        //Assert
    }
}
