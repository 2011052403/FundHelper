using Version1_0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 FundRankTest 的测试类，旨在
    ///包含所有 FundRankTest 单元测试
    ///</summary>
    [TestClass()]
    public class FundRankTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///GetOpenTypeFundsRank 的测试
        ///</summary>
        [TestMethod()]
        public void GetOpenTypeFundsRankTest()
        {
            string rank = "1";
            string code = "260104";
            string abbreviation = "景顺长城内需增";
            string netValues = "4.2050";
            string dailyGrowthRates = "2.16%";

            FundRank target = new FundRank(); // TODO: 初始化为适当的值
            target.DownLoadPage();
            DataTable actual;
            actual = target.GetOpenTypeFundsRank();
            Assert.AreEqual(rank, actual.Rows[0][0]);
            Assert.AreEqual(code, actual.Rows[0][1]);
            Assert.AreEqual(abbreviation, actual.Rows[0][2]);
            Assert.AreEqual(netValues, actual.Rows[0][3]);
            Assert.AreEqual(dailyGrowthRates, actual.Rows[0][4]);
        }

        /// <summary>
        ///GetCloseTypeFundsRank 的测试
        ///</summary>
        [TestMethod()]
        public void GetCloseTypeFundsRankTest()
        {
            string rank = "1";
            string code = "150019";
            string abbreviation = "银华锐进";
            string discountRates = "--";
            string currentValue= "0.385";
            string gains = "5.48%";

            FundRank target = new FundRank(); // TODO: 初始化为适当的值
            target.DownLoadPage();
            DataTable actual;
            actual = target.GetCloseTypeFundsRank();
            Assert.AreEqual(rank, actual.Rows[0][0]);
            Assert.AreEqual(code, actual.Rows[0][1]);
            Assert.AreEqual(abbreviation, actual.Rows[0][2]);
            Assert.AreEqual(discountRates, actual.Rows[0][3]);
            Assert.AreEqual(currentValue, actual.Rows[0][4]);
            Assert.AreEqual(gains, actual.Rows[0][5]);
        }

        /// <summary>
        ///GetCurrencyTypeFundsRank 的测试
        ///</summary>
        [TestMethod()]
        public void GetCurrencyTypeFundsRankTest()
        {
            string rank = "1";
            string code = "040043";
            string abbreviation = "华安7日鑫短期";
            string millionOfNetGain = "1.8156";
            string weeklyAnnualizedReturnRates = "7.58%";

            FundRank target = new FundRank(); // TODO: 初始化为适当的值
            target.DownLoadPage();
            DataTable actual;
            actual = target.GetCurrencyTypeFundsRank();
            Assert.AreEqual(rank, actual.Rows[0][0]);
            Assert.AreEqual(code, actual.Rows[0][1]);
            Assert.AreEqual(abbreviation, actual.Rows[0][2]);
            Assert.AreEqual(millionOfNetGain, actual.Rows[0][3]);
            Assert.AreEqual(weeklyAnnualizedReturnRates, actual.Rows[0][4]);
        }
    }
}
