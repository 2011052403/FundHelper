using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Version1_0
{
    public class FundQuery
    {
        public ProgressBar m_progressBar;
        const int ROW_NUM = 10000;

        public const int FUND_CODE = 0;
        public const int FUND_NAME = 1;

        private string m_fundCode;

        public string FundCode
        {
            get { return m_fundCode; }
            set { m_fundCode = value; }
        }

        public System.Data.DataTable QueryFundBaseMsg(string fundMsg, int msgType)
        {
            if (m_progressBar != null)
            {
                //进度条显示
                m_progressBar.Maximum = ROW_NUM;
                m_progressBar.Value = 0;
                System.Windows.Forms.Application.DoEvents();
            }
            
            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\baseMessage.xls";

            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = false;//DisplayAlerts 属性设置成 False，就不会出现这种警告。 
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);//打开Excel
            Worksheet objSheet = (Worksheet)workbook.Worksheets.get_Item(1);

            Range fundMsgRange;
            string fundMsgStr = null;
            int iRow = 3;

            if (msgType == FUND_CODE)
            {
                m_fundCode = fundMsg;
                fundMsgRange = objSheet.get_Range("a" + iRow.ToString());      
            }
            else
            {
                fundMsgRange = objSheet.get_Range("c" + iRow.ToString());
            }
            
            while (fundMsgRange.Value != null)
            {     
                fundMsgStr = fundMsgRange.Value.ToString();
                if (fundMsgStr == fundMsg)
                {
                    if (m_progressBar != null)
                    {
                        m_progressBar.Value++;
                        System.Windows.Forms.Application.DoEvents();
                    }
                    if (msgType == FUND_NAME)
                    {
                        m_fundCode = objSheet.get_Range("a" + iRow.ToString()).Value.ToString();
                    }
                   
                    break;
                }   
                iRow++;
                if (msgType == FUND_CODE)
                {
                    fundMsgRange = objSheet.get_Range("a" + iRow.ToString());
                }
                else
                {
                    fundMsgRange = objSheet.get_Range("c" + iRow.ToString());
                }

                if (m_progressBar != null)
                {
                    m_progressBar.Value++;
                    System.Windows.Forms.Application.DoEvents();
                }
               
            }

            System.Data.DataTable dt1;
            

            if (fundMsgRange.Value == null)
            {

                dt1 = null;
            } 
            else
            {
                dt1 = new System.Data.DataTable("FundBaseMessage");
                dt1.Columns.Add("基金代码", System.Type.GetType("System.String"));
                dt1.Columns.Add("基金名称缩写", System.Type.GetType("System.String"));
                dt1.Columns.Add("基金名称", System.Type.GetType("System.String"));
                dt1.Columns.Add("基金类型", System.Type.GetType("System.String"));

                DataRow dr1 = dt1.NewRow();

                Range range = objSheet.get_Range("a" + iRow.ToString());
                dr1["基金代码"] = range.Value.ToString();
                range = objSheet.get_Range("b" + iRow.ToString());
                dr1["基金名称缩写"] = range.Value.ToString();
                range = objSheet.get_Range("c" + iRow.ToString());
                dr1["基金名称"] = range.Value.ToString();
                range = objSheet.get_Range("d" + iRow.ToString());
                dr1["基金类型"] = range.Value.ToString();
                range = objSheet.get_Range("e" + iRow.ToString());
                dt1.Rows.Add(dr1);

            }

            workbook.Close(true, Type.Missing, Type.Missing);//关闭表格
            appExcel.Quit();//释放资源
            appExcel = null;

            return dt1;      
        }

        public System.Data.DataTable QueryFundNetValues()
        {
            if (m_progressBar != null)
            {
                //进度条显示
                m_progressBar.Maximum = ROW_NUM;
                m_progressBar.Value = 0;
                System.Windows.Forms.Application.DoEvents();
            }

            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\historical_net_value\\" + m_fundCode + ".xls";

            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = false;//DisplayAlerts 属性设置成 False，就不会出现这种警告。
            Microsoft.Office.Interop.Excel.Workbook workbook;
            try
            {
                workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);//打开Excel
            }
            catch (System.Exception ex)
            {
                appExcel.Quit();//释放资源
                appExcel = null;
                return null;
            }
 
            Worksheet objSheet = (Worksheet)workbook.Worksheets.get_Item(1);

            int mode = int.Parse(((Range)objSheet.Cells[1, 10]).Value.ToString());
            int iRow = 2;
            int iCol = 1;

            System.Data.DataTable dt2 = null;
            
            if (mode == 0)
            {
                dt2 = new System.Data.DataTable("FundBaseMessage");
                dt2.Columns.Add("净值日期", System.Type.GetType("System.DateTime"));
                dt2.Columns.Add("单位净值（元）", System.Type.GetType("System.String"));
                dt2.Columns.Add("累计净值（元）", System.Type.GetType("System.String"));
                dt2.Columns.Add("日增长率", System.Type.GetType("System.String"));
                dt2.Columns.Add("申购状态", System.Type.GetType("System.String"));
                dt2.Columns.Add("赎回状态", System.Type.GetType("System.String"));
                dt2.Columns.Add("分红送配", System.Type.GetType("System.String"));

                while (((Range)objSheet.Cells[iRow, iCol]).Value != null)
                {
                    DataRow dr2 = dt2.NewRow();
                    dr2["净值日期"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["单位净值（元）"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["累计净值（元）"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["日增长率"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["申购状态"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["赎回状态"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["分红送配"] = ((Range)objSheet.Cells[iRow, iCol]).Value == null ? null : ((Range)objSheet.Cells[iRow, iCol]).Value.ToString();

                    dt2.Rows.Add(dr2);

                    iRow++;
                    iCol = 1;

                    if (m_progressBar != null)
                    {
                        m_progressBar.Value++;
                        System.Windows.Forms.Application.DoEvents();
                    }
                }
            }
            else
            {             
                dt2 = new System.Data.DataTable("FundBaseMessage");
                dt2.Columns.Add("净值日期", System.Type.GetType("System.DateTime"));
                dt2.Columns.Add("每万份收益（元）", System.Type.GetType("System.String"));
                dt2.Columns.Add("7日年化收益率（%）", System.Type.GetType("System.String"));
                dt2.Columns.Add("申购状态", System.Type.GetType("System.String"));
                dt2.Columns.Add("赎回状态", System.Type.GetType("System.String"));
                dt2.Columns.Add("分红送配", System.Type.GetType("System.String"));

                while (((Range)objSheet.Cells[iRow, iCol]).Value != null)
                {                  
                    DataRow dr2 = dt2.NewRow();
                    dr2["净值日期"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["每万份收益（元）"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["7日年化收益率（%）"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["申购状态"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["赎回状态"] = ((Range)objSheet.Cells[iRow, iCol++]).Value.ToString();
                    dr2["分红送配"] = ((Range)objSheet.Cells[iRow, iCol]).Value == null ? null : ((Range)objSheet.Cells[iRow, iCol]).Value.ToString();

                    dt2.Rows.Add(dr2);

                    iRow++;
                    iCol = 1;

                    if (m_progressBar != null)
                    {
                        m_progressBar.Value++;
                        System.Windows.Forms.Application.DoEvents();
                    }
                }
            }

            workbook.Close(true, Type.Missing, Type.Missing);//关闭表格
            appExcel.Quit();//释放资源
            appExcel = null;

            if (m_progressBar != null)
            {
                m_progressBar.Value = m_progressBar.Maximum;
                System.Windows.Forms.Application.DoEvents();
            }

            return dt2;
        }

        public System.Data.DataTable GetAllFundBaseMsgs()
        {
            if (m_progressBar != null)
            {
                //进度条显示
                m_progressBar.Maximum = ROW_NUM;
                m_progressBar.Value = 0;
                System.Windows.Forms.Application.DoEvents();
            }

            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\baseMessage.xls";

            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = false;//DisplayAlerts 属性设置成 False，就不会出现这种警告。 
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);//打开Excel
            Worksheet objSheet = (Worksheet)workbook.Worksheets.get_Item(1);

            Range codeRange;
            int iRow = 3;

            System.Data.DataTable dt1 = new System.Data.DataTable();


            dt1 = new System.Data.DataTable("FundBaseMessage");
            dt1.Columns.Add("基金代码", System.Type.GetType("System.String"));
            dt1.Columns.Add("基金名称缩写", System.Type.GetType("System.String"));
            dt1.Columns.Add("基金名称", System.Type.GetType("System.String"));
            dt1.Columns.Add("基金类型", System.Type.GetType("System.String"));
            dt1.Columns.Add("风险类型", System.Type.GetType("System.String"));
            dt1.Columns.Add("基金规模", System.Type.GetType("System.Double"));


           // newDt.Columns["基金规模"].DataType = typeof(double);
            //dt1.Columns["基金规模"].DataType = typeof(double);


            codeRange = objSheet.get_Range("a" + iRow.ToString());
            int count = 0;
            while (codeRange.Value != null)
            {
                DataRow dr1 = dt1.NewRow();

                Range range = objSheet.get_Range("a" + iRow.ToString());
                dr1["基金代码"] = range.Value.ToString();
                range = objSheet.get_Range("b" + iRow.ToString());
                dr1["基金名称缩写"] = range.Value.ToString();
                range = objSheet.get_Range("c" + iRow.ToString());
                dr1["基金名称"] = range.Value.ToString();
                range = objSheet.get_Range("d" + iRow.ToString());
                dr1["基金类型"] = range.Value.ToString();
                range = objSheet.get_Range("e" + iRow.ToString());
                dr1["风险类型"] = range.Value.ToString();
                range = objSheet.get_Range("f" + iRow.ToString());
                dr1["基金规模"] = range.Value == null?DBNull.Value : range.Value;
                range = objSheet.get_Range("g" + iRow.ToString());
                dt1.Rows.Add(dr1);

                iRow++;
                codeRange = objSheet.get_Range("a" + iRow.ToString());

                if (m_progressBar != null && count == 0)
                {
                    //进度条显示
                    m_progressBar.Value ++;
                    System.Windows.Forms.Application.DoEvents();
                }

                count++;
                if (count == 3)
                {
                    count = 0;
                }
            }


            workbook.Close(true, Type.Missing, Type.Missing);//关闭表格
            appExcel.Quit();//释放资源
            appExcel = null;

            if (m_progressBar != null)
            {
                //进度条显示
                m_progressBar.Value = m_progressBar.Maximum;
                System.Windows.Forms.Application.DoEvents();
            }

            return dt1;      
        }
        
    }
}
