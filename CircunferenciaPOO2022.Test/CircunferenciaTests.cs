using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CircunferenciaPOO2022.BL;

namespace CircunferenciaPOO2022.Test
{
    [TestClass]
    public class CircunferenciaTests
    {
        [TestMethod]
        public void CircunferenciaValidarOK()
        {
            //Arrange
            int medidaRadio = 10;

            //Act
            Circunferencia circ = new Circunferencia(medidaRadio);

            //Assert
            Assert.IsTrue(circ.Validar());
        }
        [TestMethod]
        public void CircunferenciaValidarNoValido()
        {
            //Arrange
            int medidaRadio = -10;

            //Act
            Circunferencia circ = new Circunferencia(medidaRadio);

            //Assert
            Assert.IsFalse(circ.Validar());
        }

        [TestMethod]
        public void CircunferenciaGetSuperficie()
        {
            //Arrange
            int medidaRadio = 10;

            //Act
            Circunferencia circ = new Circunferencia(medidaRadio);

            //Assert
            Assert.AreEqual(314.159,Math.Round(circ.GetSuperficie()),3);
        }

        [TestMethod]
        public void CircunferenciaGetPerimetro()
        {
            //Arrange
            int medidaRadio = 10;

            //Act
            Circunferencia circ = new Circunferencia(medidaRadio);

            //Assert
            Assert.AreEqual(62.83, Math.Round(circ.GetPerimetro()), 2);
        }
    }
}
