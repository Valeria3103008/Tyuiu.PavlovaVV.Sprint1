using Tyuiu.PavlovaVV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 10;
            double y1 = 20;
            double x2 = 30;
            double y2 = 40;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            int wait = 28;
            Assert.AreEqual((double)wait, (double)result, 1.0);

        }
    }
}
