﻿using Tyuiu.PavlovaVV.Sprint1.Task1.V11.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 5.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
