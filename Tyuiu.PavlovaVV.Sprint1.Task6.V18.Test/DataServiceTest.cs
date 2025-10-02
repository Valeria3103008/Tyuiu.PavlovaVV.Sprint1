using Tyuiu.PavlovaVV.Sprint1.Task6.V18.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "1234";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(strTest);
            string wait = "true";
            Assert.AreEqual(wait, res);

        }
    }

}
