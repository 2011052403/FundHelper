using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace Version1_0
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {  
            
            /*基金下载代码
            FundMsgDownload t = new FundMsgDownload();
            t.getFundsBaseMessage();
            //t.getFundsHistoricalValue();
           
            FundLocalization fl = new FundLocalization();
            fl.SaveBaseMessage(t.Funds);
           // fl.SaveHistoricalNetValue(t.FundsHistoricalValue);
           // fl.updateNetValue("000001", t);

            FundQuery fq = new FundQuery();
            //FundMsg.baseMsg ff = fq.QueryFundBaseMsg("000001");
           // FundMsg.historicalNetValues hh = fq.QueryFundNetValues("000001");
             */

           // FundRank f = new FundRank();
           // f.GetCloseTypeFundsRank();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
