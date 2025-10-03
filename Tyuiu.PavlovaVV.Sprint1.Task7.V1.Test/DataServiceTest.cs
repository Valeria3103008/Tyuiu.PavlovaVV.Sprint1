using Tyuiu.PavlovaVV.Sprint1.Task7.V1.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double z = 1;
            double res = ds.Calculate(x, y, z);
            double wait = 1.618;
            Assert.AreEqual(wait, res);
        }
    }
}
