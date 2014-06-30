using Version1_0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 FundQueryRTTest 的测试类，旨在
    ///包含所有 FundQueryRTTest 单元测试
    ///</summary>
    [TestClass()]
    public class FundQueryRTTest
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
        ///ExtractBaseMeg 的测试
        ///</summary>
        [TestMethod()]
        public void ExtractBaseMegTest()
        {
            string type = "高风险";           //基金类型
            string scale = "37.13";  //规模

            FundQueryRT target = new FundQueryRT();
            target.GetFundPage("000031");//华夏复兴基金代码
            target.ExtractBaseMeg();

            Assert.AreEqual(type, target.FundType);
            Assert.AreEqual(scale, target.Scale);
        }

        /// <summary>
        ///GetHistoricalNetValue 的测试
        ///</summary>
        [TestMethod()]
        public void GetHistoricalNetValueTest()
        {
            FundQueryRT target = new FundQueryRT();
            target.FundCode = "000031";			//基金代码
            DateTime start = DateTime.Parse("2014-04-29");//起始时间
            DateTime end = DateTime.Parse("2014-04-30");//结束时间
            target.GetHistoricalNetValue(start, end);

            Assert.IsTrue(target.HistoricalNetValue.ContainsKey("2014-04-30") && target.HistoricalNetValue.ContainsValue("1.2790")
                && target.HistoricalNetValue.ContainsKey("2014-04-29") && target.HistoricalNetValue.ContainsValue("1.2570"));
        }
    }
}
