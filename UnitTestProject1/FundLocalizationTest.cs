using Version1_0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 FundLocalizationTest 的测试类，旨在
    ///包含所有 FundLocalizationTest 单元测试
    ///</summary>
    [TestClass()]
    public class FundLocalizationTest
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
        ///SaveBaseMessage 的测试
        ///</summary>
        [TestMethod()]
        public void SaveBaseMessageTest()
        {
            FundLocalization target = new FundLocalization(); // TODO: 初始化为适当的值
            List<FundMsgDownload.BaseMsg> funds = new List<FundMsgDownload.BaseMsg>(); // TODO: 初始化为适当的值
            FundMsgDownload.BaseMsg Fund1 = new FundMsgDownload.BaseMsg();
            FundMsgDownload.BaseMsg Fund2 = new FundMsgDownload.BaseMsg();

            Fund1.code = "000001";
            Fund1.abbreviation = "HXCZ";
            Fund1.name = "华夏成长";
            Fund1.type = "混合型";
            Fund1.scale = null;
            Fund1.type2 = null;

            Fund2.code = "000003";
            Fund2.abbreviation = "ZHKZZA";
            Fund2.name = "中海可转债A";
            Fund2.type = "债券型";
            Fund2.scale = null;
            Fund2.type2 = null;

            funds.Add(Fund1);
            funds.Add(Fund2);

            target.SaveBaseMessage(funds);
            Assert.IsNotNull(target.ExcelBaseMsgBook);
        }

        /// <summary>
        ///SaveHistoricalNetValue 的测试
        ///</summary>
        [TestMethod()]
        public void SaveHistoricalNetValueTest()
        {
            FundLocalization target = new FundLocalization(); // TODO: 初始化为适当的值
            List<FundMsgDownload.HistoricalNetValues> fundsNetValue = new List<FundMsgDownload.HistoricalNetValues>(); // TODO: 初始化为适当的值
            FundMsgDownload.HistoricalNetValues Fund1 = new FundMsgDownload.HistoricalNetValues();
            FundMsgDownload.HistoricalNetValues Fund2 = new FundMsgDownload.HistoricalNetValues();

            Fund1.mode = 0;
            Fund1.code = "000001";
            List<string> date1 = new List<string>();
            date1.Add("2014-06-10");
            date1.Add("2014-06-09");
            Fund1.dates = date1;
            List<string> netValues1 = new List<string>();
            netValues1.Add("1.0690");
            netValues1.Add("1.0580");
            Fund1.netValues = netValues1;
            Fund1.redeemStates = new List<string>();
            Fund1.subscribeStates = new List<string>();
            Fund1.sumValues = new List<string>();
            Fund1.dailyGrowthRates = new List<string>();
            Fund1.dividends = new List<string>();

            Fund2.mode = 0;
            Fund2.code = "000003";
            List<string> date2 = new List<string>();
            date2.Add("2014-06-08");
            date2.Add("2014-06-06");
            Fund2.dates = date2;
            List<string> netValues2 = new List<string>();
            netValues2.Add("1.0690");
            netValues2.Add("1.0580");
            Fund2.netValues = netValues2;
            Fund2.redeemStates = new List<string>();
            Fund2.subscribeStates = new List<string>();
            Fund2.sumValues = new List<string>();
            Fund2.dailyGrowthRates = new List<string>();
            Fund2.dividends = new List<string>();

            fundsNetValue.Add(Fund1);
            fundsNetValue.Add(Fund2);
            //target.SaveHistoricalNetValue(fundsNetValue);
            Assert.IsNotNull(fundsNetValue);
        }

        /// <summary>
        ///updateNetValue 的测试
        ///</summary>
        [TestMethod()]
        public void updateNetValueTest()
        {
            FundLocalization target = new FundLocalization(); // TODO: 初始化为适当的值
            string code = "000005"; // TODO: 初始化为适当的值
            FundMsgDownload fmDownload = new FundMsgDownload(); // TODO: 初始化为适当的值

            target.updateNetValue(code, fmDownload);
            Assert.IsNotNull(fmDownload);
        }
    }
}
