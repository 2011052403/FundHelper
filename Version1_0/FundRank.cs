using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Version1_0
{
    public class FundRank
    {
        const string URL = "http://www.chinafund.cn/";
        private string m_html;
        //private byte[] m_buf;

        //public ProgressBar m_progressBar;
        //public bool m_bCompleted = false;

        public void DownLoadPage()
        {
            //m_progressBar.Value = 0;
            try
            {
                byte[] buf = new WebClient().DownloadData(URL);
                m_html = Encoding.Default.GetString(buf);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("访问出错,详细信息: " + ex.ToString());
            }
            
        }

        /*
        private void DownloadComplete(object sender, DownloadDataCompletedEventArgs e)
        {
            m_html = Encoding.Default.GetString(m_buf);

            m_progressBar.Value = m_progressBar.Maximum;
            Application.DoEvents();

            m_bCompleted = true;
        }

        private void ProcessChange(object sender, DownloadProgressChangedEventArgs e)
        {
            m_progressBar.Value++;
            Application.DoEvents();
        }*/


        public DataTable GetOpenTypeFundsRank()
        {
            DataTable dt = new DataTable("OpenType");
            dt.Columns.Add("排行", System.Type.GetType("System.String"));
            dt.Columns.Add("代码", System.Type.GetType("System.String"));
            dt.Columns.Add("简称", System.Type.GetType("System.String"));
            dt.Columns.Add("单位净值", System.Type.GetType("System.String"));
            dt.Columns.Add("日增长率", System.Type.GetType("System.String"));

            string pattern;       

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/)[0-9]*(?=/\" target='_blank'>[^<]*</a></td><td>[.0-9]*</td><td><font color='red'>[0-9.]*%</font></td></tr>)";
            MatchCollection matches1 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>)[^<]*(?=</a></td><td>[.0-9]*</td><td><font color='red'>[0-9.]*%</font></td></tr>)";
            MatchCollection matches2 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>)[.0-9]*(?=</td><td><font color='red'>[0-9.]*%</font></td></tr>)";
            MatchCollection matches3 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>[.0-9]*</td><td><font color='red'>)[0-9.]*%(?=</font></td></tr>)";
            MatchCollection matches4 = Regex.Matches(m_html, pattern);

            for (int i = 0; i < 20; i++ )
            {
                DataRow dr = dt.NewRow();
                dr["排行"] = i + 1;
                dr["代码"] = matches1[i].ToString();
                dr["简称"] = matches2[i].ToString();
                dr["单位净值"] = matches3[i].ToString();
                dr["日增长率"] = matches4[i].ToString();

                dt.Rows.Add(dr);
            }

            return dt;

        }


        public DataTable GetCloseTypeFundsRank()
        {
            DataTable dt = new DataTable("OpenType");
            dt.Columns.Add("排行", System.Type.GetType("System.String"));
            dt.Columns.Add("代码", System.Type.GetType("System.String"));
            dt.Columns.Add("简称", System.Type.GetType("System.String"));
            dt.Columns.Add("折价率", System.Type.GetType("System.String"));
            dt.Columns.Add("现价", System.Type.GetType("System.String"));
            dt.Columns.Add("涨幅", System.Type.GetType("System.String"));

            string pattern;
           
            pattern = "(?<=<tr><td>)[0-9]*(?=</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>[+-.0-9]*</td><td>[0-9.]*</td><td><font color='red'>[.%0-9-]*</font></td></tr>)";
            MatchCollection matches1 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>)[^<]*(?=</a></td><td>[+-.0-9]*</td><td>[0-9.]*</td><td><font color='red'>[.%0-9-]*</font></td></tr>)";
            MatchCollection matches2 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>)[+-.0-9]*(?=</td><td>[0-9.]*</td><td><font color='red'>[.%0-9-]*</font></td></tr>)";
            MatchCollection matches3 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>[+-.0-9]*</td><td>)[0-9.]*(?=</td><td><font color='red'>[.%0-9-]*</font></td></tr>)";
            MatchCollection matches4 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>[+-.0-9]*</td><td>[0-9.]*</td><td><font color='red'>)[.%0-9-]*(?=</font></td></tr>)";
            MatchCollection matches5 = Regex.Matches(m_html, pattern);

            for (int i = 0; i < matches1.Count; i++ )
            {
                DataRow dr = dt.NewRow();
                dr["排行"] = i + 1;
                dr["代码"] = matches1[i].ToString();
                dr["简称"] = matches2[i].ToString();
                dr["折价率"] = matches3[i].ToString();
                dr["现价"] = matches4[i].ToString();
                dr["涨幅"] = matches5[i].ToString();

                dt.Rows.Add(dr);
            }

            return dt;

        }

        public DataTable GetCurrencyTypeFundsRank()
        {
            DataTable dt = new DataTable("OpenType");
            dt.Columns.Add("排行", System.Type.GetType("System.String"));
            dt.Columns.Add("代码", System.Type.GetType("System.String"));
            dt.Columns.Add("简称", System.Type.GetType("System.String"));
            dt.Columns.Add("万份净收益", System.Type.GetType("System.String"));
            dt.Columns.Add("7日年化收益率", System.Type.GetType("System.String"));

            string pattern;
           
            pattern = "(?<=<tr><td>)[0-9]*(?=</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>[.0-9]*</td><td><font color='red'>[.0-9]*%</font></td></tr>)";
            MatchCollection matches1 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>)[^<]*(?=</a></td><td>[.0-9]*</td><td><font color='red'>[.0-9]*%</font></td></tr>)";
            MatchCollection matches2 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>)[.0-9]*(?=</td><td><font color='red'>[.0-9]*%</font></td></tr>)";
            MatchCollection matches3 = Regex.Matches(m_html, pattern);

            pattern = "(?<=<tr><td>[0-9]*</td><td><a href=\"http://info\\.chinafund\\.cn/fund/[0-9]*/\" target='_blank'>[^<]*</a></td><td>[.0-9]*</td><td><font color='red'>)[.0-9]*%(?=</font></td></tr>)";
            MatchCollection matches4 = Regex.Matches(m_html, pattern);

            for (int i = 20; i < 40; i++)
            {
                DataRow dr = dt.NewRow();
                dr["排行"] = i - 19;
                dr["代码"] = matches1[i].ToString();
                dr["简称"] = matches2[i].ToString();
                dr["万份净收益"] = matches3[i].ToString();
                dr["7日年化收益率"] = matches4[i].ToString();

                dt.Rows.Add(dr);
            }

            return dt;

        }
    }
}
