using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace AnalizerClassLibraryTest
{
    [TestClass]
    public class AnalizerClassLibraryTestClass
    {
        public TestContext TestContext { get; set; }

       
        [DataSource("System.Data.SqlClient", @"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=C:\Users\Lenovo\Tests.mdf;Integrated Security=True;Connect Timeout=30", "TestCheckCurrency", DataAccessMethod.Sequential)]
        [TestMethod]
        public void CheckCurrency_ExpressionValidity()
        {
            // Arrange
            string expression = TestContext.DataRow["expression"].ToString();
            bool expectedCheckCurrency = bool.Parse(TestContext.DataRow["CheckCurrency"].ToString());

            AnalaizerClass.expression = expression;

            // Act
            bool CheckCurrency = AnalaizerClass.CheckCurrency();

            // Assert
            Assert.AreEqual(expectedCheckCurrency, CheckCurrency);
        }

       
    }


}

