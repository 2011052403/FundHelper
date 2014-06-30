using Version1_0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 FundMsgDownloadTest 的测试类，旨在
    ///包含所有 FundMsgDownloadTest 单元测试
    ///</summary>
    [TestClass()]
    public class FundMsgDownloadTest
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
        ///getFundsBaseMessage 的测试
        ///</summary>
        [TestMethod()]
        public void getFundsBaseMessageTest()
        {
            string code = "000001";
            string abbreviation = "HXCZ";
            string name = "华夏成长";
            string type = "混合型";

            FundMsgDownload target = new FundMsgDownload(); // TODO: 初始化为适当的值
            target.getFundsBaseMessage();
            Assert.AreEqual(code, target.Funds[0].code);
            Assert.AreEqual(abbreviation, target.Funds[0].abbreviation);
            Assert.AreEqual(name, target.Funds[0].name);
            Assert.AreEqual(type, target.Funds[0].type);
        }

        /// <summary>
        ///getFundsHistoricalValue 的测试
        ///</summary>
        [TestMethod()]
        public void getFundsHistoricalValueTest()
        {
            int testCount = 0;

            FundMsgDownload target = new FundMsgDownload(); // TODO: 初始化为适当的值
            target.getFundsHistoricalValue();

            Assert.AreEqual(testCount, target.TestCount);
        }

        /// <summary>
        ///GetOneFundNetValue 的测试
        ///</summary>
        [TestMethod()]
        public void GetOneFundNetValueTest()
        {
            string code = "000001";

            string dates = "2014-06-09";
            string netValues = "1.0580";
            string sumValues = "3.1590";
            string dailyGrowthRates = "-0.56%";
            string subscribeStates = "限制大额申购";
            string redeemStates = "开放赎回";

            FundMsgDownload target = new FundMsgDownload(); // TODO: 初始化为适当的值
            Version1_0.FundMsgDownload.HistoricalNetValues actual = target.GetOneFundNetValue(code);

            Assert.AreEqual(dates, actual.dates[4]);//索引号随日期改变
            Assert.AreEqual(netValues, actual.netValues[4]);
            Assert.AreEqual(sumValues, actual.sumValues[4]);
            Assert.AreEqual(dailyGrowthRates, actual.dailyGrowthRates[4]);
            Assert.AreEqual(subscribeStates, actual.subscribeStates[4]);
            Assert.AreEqual(redeemStates, actual.redeemStates[4]);
        }
    }
}
