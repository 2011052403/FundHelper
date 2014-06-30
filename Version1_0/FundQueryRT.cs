using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Version1_0
{
    public class FundQueryRT
    {
        private string m_fundCode;       //基金代码
        public string FundCode
        {
            get { return m_fundCode; }
            set { m_fundCode = value; }
        }

        private string m_fundName;
        public string FundName
        {
            get { return m_fundName; }
            set { m_fundName = value; }
        }

        private string m_fundPage;       //基金基本信息页面

        /*
        private string m_inceptionDate;  //基金成立日
        public string InceptionDate
        {
            get { return m_inceptionDate; }
            set { m_inceptionDate = value; }
        }*/

        private string m_fundType;           //基金类型
        public string FundType
        {
            get { return m_fundType; }
            set { m_fundType = value; }
        }

        /*
        private string m_custodian;      //管理人
        public string Custodian
        {
            get { return m_custodian; }
            set { m_custodian = value; }
        }*/

        /*
        private string m_netAssetValue;  //单位净值
        public string NetAssetValue
        {
            get { return m_netAssetValue; }
            set { m_netAssetValue = value; }
        }*/

        private string m_scale;          //规模
        public string Scale
        {
            get { return m_scale; }
            set { m_scale = value; }
        }

        private Dictionary<string, string> m_historicalNetValue;//历史净值
        public Dictionary<string, string> HistoricalNetValue
        {
            get { return m_historicalNetValue; }
            set { m_historicalNetValue = value; }
        }

        //提取基本信息页面
        public string GetFundPage(string fundCode)
        {
            m_fundCode = fundCode;
            string url = "http://fund.eastmoney.com/" + fundCode + ".html";
            byte[] buf = new WebClient().DownloadData(url);

            //该网站网页类型为gb312
            m_fundPage = Encoding.GetEncoding("GB2312").GetString(buf);

            return m_fundPage;
        }


        public void ExtractBaseMeg()
        {
            string pattern;
            MatchCollection matches;

            //获取类型
            pattern = "(?<=类&nbsp;&nbsp;&nbsp;&nbsp;型：</td><td>)[^<]*";
            matches = Regex.Matches(m_fundPage, pattern);
            if (matches.Count != 0)
            {
                string subPattern = "(?<=\\|).*";
                string test = matches[0].ToString();
                matches = Regex.Matches(matches[0].ToString(), subPattern);
                
                if (matches.Count != 0)
                {
                    m_fundType = matches[0].ToString();
                }
                else
                {
                    m_fundType = "null";
                }
                
            }
            else
            {
                m_fundType = "null";
            }
            

            /*
            //管理人
            pattern = "(?<=管&nbsp;理&nbsp;人：</td><td><a href=\"http://fund.eastmoney.com/company/[0-9]*\\.html\">)[^<]*";
            matches = Regex.Matches(m_fundPage, pattern);
            m_custodian = matches[0].ToString();
             * */

            //规模
            pattern = "(?<=规&nbsp;&nbsp;&nbsp;&nbsp;模</a>：</td><td>)[^<]*";
            matches = Regex.Matches(m_fundPage, pattern);
            
            if (matches.Count != 0)
            {
                string subPattern = ".*(?=亿)";
                matches = Regex.Matches(matches[0].ToString(), subPattern);       

                if (matches.Count != 0)
                {
                    m_scale = matches[0].ToString();
                }
                else
                {
                    m_scale = "";
                }
            }
            else
            {
                m_scale = "";
            }

            /*
            //成立日
            pattern = "(?<=成&nbsp;立&nbsp;日：</td><td>)[^<]*";
            matches = Regex.Matches(m_fundPage, pattern);
            m_inceptionDate = matches[0].ToString();

            //单位净值
            pattern = "(?<=单位净值</a>（[0-9-]*）：<span class=\"[^>]*\">)[^<]*";
            matches = Regex.Matches(m_fundPage, pattern);
            m_netAssetValue = matches[0].ToString();

             * */

            //基金名称
            pattern = "(?<=<title>)[^(]*(?=\\(" + m_fundCode + "\\))";
            matches = Regex.Matches(m_fundPage, pattern);
           
            if (matches.Count != 0)
            {
                 m_fundName = matches[0].ToString();
            }
            else
            {
                m_fundName = "null";
            }

        }

        public void GetHistoricalNetValue(DateTime start, DateTime end)
        {
            m_historicalNetValue = new Dictionary<string, string>();

            string url = "http://jingzhi.funds.hexun.com/database/jzzs.aspx?fundcode=" + m_fundCode + "&startdate=" +
                start.ToString("yyyy-MM-dd") + "&enddate=" + end.ToString("yyyy-MM-dd");

            byte[] buf = new WebClient().DownloadData(url);
            string html = Encoding.GetEncoding("GB2312").GetString(buf);

            string pattern = "<td align\\=\"center\">2014-04-30</td>\r\n<td align\\=\"center\">1.2790</td>";
            MatchCollection matches = Regex.Matches(html, pattern);

            string datePattern = "(?<=<td align\\=\"center\">)[0-9-]*(?=</td>\r\n<td align\\=\"center\">[0-9.]*</td>)";
            string valuePattern = "(?<=<td align\\=\"center\">)[0-9.^<]*(?=</td>\r\n<td align=\"center\" class=\"end\">)";
            MatchCollection dateMatches = Regex.Matches(html, datePattern);
            MatchCollection valueMatches = Regex.Matches(html, valuePattern);

            string s = dateMatches[0].ToString();
            string s1 = valueMatches[0].ToString();

            for (int i = 0; i < dateMatches.Count; i++)
            {
                m_historicalNetValue.Add(dateMatches[i].ToString(), valueMatches[i].ToString());
            }
            
        }
    }
}
