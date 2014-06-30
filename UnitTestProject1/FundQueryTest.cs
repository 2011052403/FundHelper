using Version1_0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 FundQueryTest 的测试类，旨在
    ///包含所有 FundQueryTest 单元测试
    ///</summary>
    [TestClass()]
    public class FundQueryTest
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
        ///QueryFundNetValues 的测试
        ///</summary>
        [TestMethod()]
        public void QueryFundNetValuesTest()
        {
            DateTime dates = DateTime.Parse("2014-06-09");
            string netAssetValue = "0.9140";
            string sumValues = "0.9140";
            string dailyGrowthRates = "0.22%";
            string subscribeStates = "开放申购";
            string redeemStates = "开放赎回";

            FundQuery target = new FundQuery(); // TODO: 初始化为适当的值
            target.FundCode = "000003";
            DataTable actual;
            actual = target.QueryFundNetValues();
            Assert.AreEqual(dates,actual.Rows[1][0]);
            Assert.AreEqual(netAssetValue, actual.Rows[1][1]);
            Assert.AreEqual(sumValues, actual.Rows[1][2]);
            Assert.AreEqual(dailyGrowthRates, actual.Rows[1][3]);
            Assert.AreEqual(subscribeStates, actual.Rows[1][4]);
            Assert.AreEqual(redeemStates, actual.Rows[1][5]);
        }

        /// <summary>
        ///QueryFundBaseMsg 的测试
        ///</summary>
        [TestMethod()]
        public void QueryFundBaseMsgTest()
        {
            string code = "000003";
            string abbreviation = "ZHKZZA";
            string name = "中海可转债A";
            string type = "债券型";

            FundQuery target = new FundQuery(); // TODO: 初始化为适当的值
            string fundMsg = "000003"; // TODO: 初始化为适当的值
            int msgType = 0; // TODO: 初始化为适当的值
            DataTable actual;
            actual = target.QueryFundBaseMsg(fundMsg, msgType);
            Assert.AreEqual(code, actual.Rows[0][0]);
            Assert.AreEqual(abbreviation, actual.Rows[0][1]);
            Assert.AreEqual(name, actual.Rows[0][2]);
            Assert.AreEqual(type, actual.Rows[0][3]);
        }
    }
}
