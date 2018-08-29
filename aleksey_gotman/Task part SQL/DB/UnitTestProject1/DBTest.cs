using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB;
using System.Data.SQLite;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void TestConnect()
        {
            //Arrange
            CRUD.ConnectionOpen();
            //Act

            //Assert
            Assert.AreEqual(ConnectionState.Open, CRUD.Con.State);
            CRUD.Close();
        }

        [TestMethod]
        public void TestClose()
        {
            //Arrange
            CRUD.ConnectionOpen();
            //Act
            CRUD.Close();
            //Assert
            Assert.AreEqual(ConnectionState.Closed, CRUD.Con.State);
        }

        [TestMethod]
        public void TestLogin_AllIsTrue()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "123@gmail.com";
            string pass = "123";
            //Act
            bool result = CRUD.Login(email, pass);
            //Assert
            Assert.IsTrue(result);
            CRUD.Close();
        }

        [TestMethod]
        public void TestLogin_AllIsFalse()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "13@gmail.com";
            string pass = "1";
            //Act
            bool result = CRUD.Login(email, pass);
            //Assert
            Assert.IsFalse(result);
            CRUD.Close();
        }

        [TestMethod]
        public void TestLogin_LoginIsTruePassIsFalse()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "123@gmail.com";
            string pass = "12";
            //Act
            bool result = CRUD.Login(email, pass);
            //Assert
            Assert.IsFalse(result);
            CRUD.Close();
        }

        [TestMethod]
        public void TestLogin_LoginIsFalsePassTrue()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "23@gmail.com";
            string pass = "123";
            //Act
            bool result = CRUD.Login(email, pass);
            //Assert
            Assert.IsFalse(result);
            CRUD.Close();
        }

        [TestMethod]
        public void TestAreRegisterd_LoginIsFalse()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "23@gmail.com";
            //Act
            bool result = CRUD.AreRegisterd(email);
            //Assert
            Assert.IsFalse(result);
            CRUD.Close();
        }

        [TestMethod]
        public void TestAreRegisterd_LoginIsTrue()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "123@gmail.com";
            //Act
            bool result = CRUD.AreRegisterd(email);
            //Assert
            Assert.IsTrue(result);
            CRUD.Close();
        }

        [TestMethod]
        public void TestRegistration()
        {
            //Arrange
            CRUD.ConnectionOpen();
            string email = "aaa@gmail.com";
            string pass = "aaa";
            bool result = false;
            //Act
            if (!CRUD.AreRegisterd(email))
            {
                CRUD.Registration(email, pass);
                result = CRUD.AreRegisterd(email);
            }
            //Assert
            Assert.IsTrue(result);
            CRUD.Close();
        }


    }
}
