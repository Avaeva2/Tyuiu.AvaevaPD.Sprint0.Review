using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AvaevaPD.Sprint0.TaskReview.V0.Lib;
namespace Tyuiu.AvaevaPD.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            Assert.AreEqual(150, DataService.Calculate(5, 10, 15));
        }
    }
}
