using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Version1_0
{
    public class FundMsgDownload
    {
        public class BaseMsg
        {
            public string code;
            public string abbreviation;
            public string name;
            public string type;

            //后期增加
            public string scale;
            public string type2;
        }

        public class HistoricalNetValues
        {
            public int mode;
            public string code;
            public List<string> dates;
            public List<string> netValues;
            public List<string> sumValues;
            public List<string> dailyGrowthRates;
            public List<string> subscribeStates;
            public List<string> redeemStates;
            public List<string> dividends;

            public void Reverse()
            {
                dates.Reverse(0, dates.Count);
                netValues.Reverse(0, netValues.Count);
                sumValues.Reverse(0, sumValues.Count);
                dailyGrowthRates.Reverse(0, dailyGrowthRates.Count);
                subscribeStates.Reverse(0, subscribeStates.Count);
                dividends.Reverse(0, dates.Count);
            }

            public HistoricalNetValues()
            {
                dates = new List<string>();
                netValues = new List<string>();
                sumValues = new List<string>();
                dailyGrowthRates = new List<string>();
                subscribeStates = new List<string>();
                redeemStates = new List<string>();
                dividends = new List<string>();
            }
        }

        List<BaseMsg> m_funds = new List<BaseMsg>();

        public List<BaseMsg> Funds
        {
            get { return m_funds; }
            set { m_funds = value; }
        }

        List<HistoricalNetValues> m_fundsHistoricalValue = new List<HistoricalNetValues>();

        public List<HistoricalNetValues> FundsHistoricalValue
        {
            get { return m_fundsHistoricalValue; }
            set { m_fundsHistoricalValue = value; }
        }

        const string FUND_BASE_MESSAGE_URL = "http://fund.eastmoney.com/js/fundcode_search.js?v=20140518.js";

        public void getFundsBaseMessage()
        {
            try
            {
                byte[] buf = new WebClient().DownloadData(FUND_BASE_MESSAGE_URL);
                string html = Encoding.UTF8.GetString(buf);

                string basePattern = "\\[\"[0-9]*\",\"[A-Z]*\",\"[^,]*\",\"[^,]*\"\\]";
                MatchCollection matches = Regex.Matches(html, basePattern);

                foreach (var fundBaseMessage in matches)
                {
                    BaseMsg aFund = new BaseMsg();
                    string codePattern = "(?<=\\[\")[0-9]*(?=\",\"[A-Z]*\",\"[^,]*\",\"[^,]*\"\\])";
                    MatchCollection ms = Regex.Matches(fundBaseMessage.ToString(), codePattern);
                    Debug.Assert(ms.Count != 0);
                    aFund.code = ms[0].ToString();

                    string abbreviationPattern = "(?<=\\[\"[0-9]*\",\")[A-Z]*(?=\",\"[^,]*\",\"[^,]*\"\\])";
                    ms = Regex.Matches(fundBaseMessage.ToString(), abbreviationPattern);
                    Debug.Assert(ms.Count != 0);
                    aFund.abbreviation = ms[0].ToString();

                    string namePattern = "(?<=\\[\"[0-9]*\",\"[A-Z]*\",\")[^,]*(?=\",\"[^,]*\"\\])";
                    ms = Regex.Matches(fundBaseMessage.ToString(), namePattern);
                    Debug.Assert(ms.Count != 0);
                    aFund.name = ms[0].ToString();

                    string typePattern = "(?<=\\[\"[0-9]*\",\"[A-Z]*\",\"[^,]*\",\")[^,]*(?=\"\\])";
                    ms = Regex.Matches(fundBaseMessage.ToString(), typePattern);
                    Debug.Assert(ms.Count != 0);
                    aFund.type = ms[0].ToString();

                    m_funds.Add(aFund);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("网页请求异常，详细信息：" + ex.ToString());
            }
            
        }

        private int testCount;

        public int TestCount
        {
            get { return testCount; }
            set { testCount = value; }
        }

        public void getFundsHistoricalValue()
        {
            this.testCount = 0;//////////////////////////////////////

            /*
             * 该网站的历史净值显示有两种方式:
             * 1. 净值日期	每万份收益（元）	7日年化收益率（%）	申购状态	赎回状态	分红送配
             * 2. 净值日期	单位净值（元）	累计净值（元）	日增长率	申购状态	赎回状态	分红送配
             * 
             * 根据不同的模式采取不同的匹配方式
             */

            foreach(var aFund in m_funds)
            {
                HistoricalNetValues aFundhistoricalValue = GetOneFundNetValue(aFund.code);
                
                m_fundsHistoricalValue.Add(aFundhistoricalValue);

                this.testCount++;
                
            }    
        }

         public HistoricalNetValues GetOneFundNetValue(string code)
        {
            string url = "http://fund.eastmoney.com/f10/F10DataApi.aspx?type=lsjz&code=" + code + "&page=1&per=10000";

            byte[] buf = new WebClient().DownloadData(url);
            string html = Encoding.GetEncoding("GB2312").GetString(buf);

            string modePattern = "单位净值";
            MatchCollection matches = Regex.Matches(html, modePattern);
            HistoricalNetValues aFundhistoricalValue = new HistoricalNetValues();
            aFundhistoricalValue.code = code;

            if (matches.Count != 0)
            {
                aFundhistoricalValue.mode = 0;

                string basePattern = "<td>[0-9-]*</td><td class='tor bold'>[0-9.]*</td><td class='tor bold'>[0-9.]*</td><td class='[^']*'>[+-.0-9]*%</td><td>[^<]*</td><td>[^<]*</td><td class='red unbold'>[^<]*</td></tr>";
                matches = Regex.Matches(html, basePattern);

                foreach (var match in matches)
                {
                    string datePattern = "(?<=<td>)[0-9]{4}-[0-9]{2}-[0-9]{2}(?=</td>)";
                    MatchCollection record = Regex.Matches(match.ToString(), datePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.dates.Add(record[0].ToString());

                    string netValuePattern = "(?<=<td>[0-9-]*</td><td class='tor bold'>)[0-9.]*(?=</td>)";
                    record = Regex.Matches(match.ToString(), netValuePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.netValues.Add(record[0].ToString());

                    string sumValuePattern = "(?<=<td class='tor bold'>[0-9.]*</td><td class='tor bold'>)[0-9.]*(?=</td>)";
                    record = Regex.Matches(match.ToString(), sumValuePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.sumValues.Add(record[0].ToString());

                    string dailyGrowthRatePattern = "(?<=<td class='[ a-z^']*'>)[+-.0-9]*%(?=</td>)";
                    record = Regex.Matches(match.ToString(), dailyGrowthRatePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.dailyGrowthRates.Add(record[0].ToString());

                    string subscribeStatePattern = "(?<=<td class='[ a-z^']*'>[+-.0-9]*%</td><td>)[^<]*(?=</td>)";
                    record = Regex.Matches(match.ToString(), subscribeStatePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.subscribeStates.Add(record[0].ToString());

                    string redeemStatePattern = "(?<=<td>)[^<]*(?=</td><td class='red unbold'>)";
                    record = Regex.Matches(match.ToString(), redeemStatePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.redeemStates.Add(record[0].ToString());

                    string dividendPattern = "(?<=</td><td class='red unbold'>)[^<]*(?=</td>)";
                    record = Regex.Matches(match.ToString(), dividendPattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.dividends.Add(record[0].ToString());

                }
            }
            else
            {
                aFundhistoricalValue.mode = 1;

                string basePattern = "<td>[0-9-]*(<span class='red'>\\*</span>)*</td><td class='[^']*'>[0-9.]*</td><td class='[^']*'>[0-9.]*%</td><td>[^<]*</td><td>[^<]*</td><td class='[^']*'>[^<]*</td>";
                matches = Regex.Matches(html, basePattern);

                foreach (var match in matches)
                {
                    string datePattern = "[0-9]{4}-[0-9]{2}-[0-9]{2}(?=(<span class='red'>\\*</span>)*</td>)";
                    MatchCollection record = Regex.Matches(match.ToString(), datePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.dates.Add(record[0].ToString());

                    string netValuePattern = "(?<=<td>[0-9-]*(<span class='red'>\\*</span>)*</td><td class='[^']*'>)[0-9.]*(?=</td><td class='[^']*'>)";
                    record = Regex.Matches(match.ToString(), netValuePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.netValues.Add(record[0].ToString());

                    string dailyGrowthRatePattern = "[0-9.]*%(?=</td><td>[^<]*</td><td>[^<]*</td>)";
                    record = Regex.Matches(match.ToString(), dailyGrowthRatePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.dailyGrowthRates.Add(record[0].ToString());

                    string subscribeStatePattern = "(?<=[0-9.]*%</td><td>[^<]*</td><td>)[^<]*";
                    record = Regex.Matches(match.ToString(), subscribeStatePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.subscribeStates.Add(record[0].ToString());

                    string redeemStatePattern = "(?<=<td>[^<]*</td><td>)[^<]*";
                    record = Regex.Matches(match.ToString(), redeemStatePattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.redeemStates.Add(record[0].ToString());

                    string dividendPattern = "(?<=</td><td class='red unbold'>)[^<]*(?=</td>)";
                    record = Regex.Matches(match.ToString(), dividendPattern);
                    Debug.Assert(record.Count != 0);
                    aFundhistoricalValue.dividends.Add(record[0].ToString());
                }
            }
            return aFundhistoricalValue;
        }

    }
}
