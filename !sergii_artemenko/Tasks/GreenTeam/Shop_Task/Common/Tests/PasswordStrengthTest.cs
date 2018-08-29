using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace Tests
{
    [TestClass]
    public class PasswordStrengthTest
    {
        [TestMethod]
        public void Test_Ent_Short()
        {

            // Arrange
            string psw = "Ent";

            // Act
            var result = PasswordStrength.CheckPasswordStrength(psw);

            // Assert
            Assert.AreEqual("Короткий", Convert.ToString(result));
        }


        [TestMethod]
        public void Test_Ent123_Hight()
        {

            // Arrange
            string psw = "Ent123";

            // Act
            var result = PasswordStrength.CheckPasswordStrength(psw);

            // Assert
            Assert.AreEqual("Высокий", Convert.ToString(result));
        }

        [TestMethod]
        public void Test_WithSymbols_Hight()
        {

            // Arrange
            string psw = "Ent12?3123@asfafwq*";

            // Act
            var result = PasswordStrength.CheckPasswordStrength(psw);

            // Assert
            Assert.AreEqual("Отличный", Convert.ToString(result));
        }

        [TestMethod]
        public void Test_WithSymbolsAndSpecSymbols_Paranoid()
        {

            // Arrange
            string psw = "Ent123@123©asfafwq©";

            // Act
            var result = PasswordStrength.CheckPasswordStrength(psw);

            // Assert
            Assert.AreEqual("Параноик", Convert.ToString(result));
        }

    }
}
