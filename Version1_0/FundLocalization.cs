using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Version1_0
{
    public class FundLocalization
    {
        public System.Windows.Forms.ProgressBar m_progressBar;
        const int COUNT = 100;

        private Workbook excelBaseMsgBook;   //测试用

        public Workbook ExcelBaseMsgBook
        {
            get { return excelBaseMsgBook; }
            set { excelBaseMsgBook = value; }
        }

        private Workbook excelHistoricalNetValueBook;   //测试用

        public Workbook ExcelHistoricalNetValueBook
        {
            get { return excelHistoricalNetValueBook; }
            set { excelHistoricalNetValueBook = value; }
        }

        public void SaveBaseMessage(List<FundMsgDownload.BaseMsg> funds)
        {
            ApplicationClass xlsApp = new ApplicationClass();  //创建Excel应用程序对象的一个实例           
            Debug.Assert(xlsApp != null);

            //创建Excel对象
            Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();
            objExcel.Visible = false;

            Object missing = System.Reflection.Missing.Value;    //定义缺省值

            //创建一个新的工作薄,并引用缺省的工作表  创建Excel后不会自动创建新的工作薄（文件）
            Workbook objBook = objExcel.Workbooks.Add(missing);
            Worksheet objSheet = (Worksheet)objBook.Worksheets.get_Item(1);

            //Range对象用于选择一个或多个单元格
            Range objRange;

            //基金信息开始行
            int stateRow = 3;

            objRange = objSheet.get_Range("A1", "F1");
            //合并单元格
            objRange.Merge(0);
            objRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // objRange = objSheet.get_Range("A1", missing);
            objRange.Value2 = "基金基本信息";
            objRange.Font.Size = 20;
            objRange.Font.Bold = true;

            //循环放入列名
            int titleIndex = 1;
            objSheet.Cells[stateRow - 1, titleIndex++] = "基金代码";
            objSheet.Cells[stateRow - 1, titleIndex++] = "基金名称缩写";
            objSheet.Cells[stateRow - 1, titleIndex++] = "基金名称";
            objSheet.Cells[stateRow - 1, titleIndex++] = "基金类型";

            //后期加入的代码f
            objSheet.Cells[stateRow - 1, titleIndex++] = "风险类型";
            objSheet.Cells[stateRow - 1, titleIndex++] = "规模";
            FundQueryRT fqRT = new FundQueryRT();

            //循环放入所有数据
            int iRow = stateRow;
            foreach (var fund in funds)
            {
                int icel = 1;//列号

                //向单元格中插入数据
                objSheet.Cells[iRow, icel++] = "'" + fund.code;//为了实现左对齐
                objSheet.Cells[iRow, icel++] = fund.abbreviation;
                objSheet.Cells[iRow, icel++] = fund.name;
                objSheet.Cells[iRow, icel++] = fund.type;

                
                //后期加入的代码
                fqRT.GetFundPage(fund.code);
                fqRT.ExtractBaseMeg();
                objSheet.Cells[iRow, icel++] = fqRT.FundType;
               // objSheet.Cells[iRow, icel++] = fqRT.Custodian;
                objSheet.Cells[iRow, icel++] = fqRT.Scale;
                 

                iRow++;
            }

            objRange = objSheet.get_Range("a2", "d2");

            objRange.EntireColumn.AutoFit();   //自动调整表格大小
            objRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;//将所有单元格左对齐

            //在表格底部添加时间
            objRange = objSheet.get_Range("a" + (iRow + 2).ToString(), "d" + (iRow + 2).ToString());//选中单元格
            objRange.Merge(0);//合并
            objRange.Value2 = DateTime.Now.ToString();//把时间赋值给单元格
            objRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;//中间对齐
            objRange.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 204, 153).ToArgb();

            this.excelBaseMsgBook = objBook;

            objBook.Saved = true;//保存表格
            DateTime dtime = DateTime.Now;//获取当前时间

            string fileName = dtime.ToString("yyyy-MM-dd hh-mm") + ".xls";
            string fileWay = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\" + fileName;
            objBook.SaveCopyAs(fileWay);//将表格拷贝到指定路径

            objBook.Close(true, Type.Missing, Type.Missing);//关闭表格
            objExcel = null;//清空Excel
            xlsApp.Quit();//释放资源
            xlsApp = null;
        }

        public void SaveHistoricalNetValue(List<FundMsgDownload.HistoricalNetValues> fundsNetValue)
        {
            for (int i = 0; i < fundsNetValue.Count; i++)
            {

                ApplicationClass xlsApp = new ApplicationClass();  //创建Excel应用程序对象的一个实例           
                Debug.Assert(xlsApp != null);

                //创建Excel对象
                Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();
                objExcel.Visible = false;

                Object missing = System.Reflection.Missing.Value;    //定义缺省值

                //创建一个新的工作薄,并引用缺省的工作表  创建Excel后不会自动创建新的工作薄（文件）
                Workbook objBook = objExcel.Workbooks.Add(missing);

                FundMsgDownload.HistoricalNetValues netValues = fundsNetValue[i];

                //先写表名和列名
                Worksheet objSheet = (Worksheet)objBook.Worksheets.get_Item(1);
                objSheet.Name = netValues.code;
                Range objRange;
                int iRow;

                if (netValues.mode == 0)
                {
                    //列名
                    int titleIndex = 1;
                    objSheet.Cells[1, titleIndex++] = "净值日期";
                    objSheet.Cells[1, titleIndex++] = "单位净值（元)";
                    objSheet.Cells[1, titleIndex++] = "累计净值（元)";
                    objSheet.Cells[1, titleIndex++] = "日增长率";
                    objSheet.Cells[1, titleIndex++] = "申购状态";
                    objSheet.Cells[1, titleIndex++] = "赎回状态";
                    objSheet.Cells[1, titleIndex++] = "分红送配";

                    objSheet.Cells[1, 10] = "'0";

                    objRange = objSheet.get_Range("a1", "g1");//选中单元格
                    objRange.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 204, 153).ToArgb();
                    iRow = 2;
                    for (int j = 0; j < netValues.dates.Count; j++)
                    {
                        int col = 1;
                        objSheet.Cells[iRow, col++] = "'" + netValues.dates[j];
                        objSheet.Cells[iRow, col++] = "'" + netValues.netValues[j];
                        objSheet.Cells[iRow, col++] = "'" + netValues.sumValues[j];
                        objSheet.Cells[iRow, col++] = "'" + netValues.dailyGrowthRates[j];
                        objSheet.Cells[iRow, col++] = netValues.subscribeStates[j];
                        objSheet.Cells[iRow, col++] = netValues.redeemStates[j];
                        objSheet.Cells[iRow, col++] = netValues.dividends[j];

                        iRow++;
                    }

                    objRange = objSheet.get_Range("a2", "g2");

                    objRange.EntireColumn.AutoFit();   //自动调整表格大小
                    objRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;//将所有单元格左对齐
                }
                else
                {
                    //列名
                    int titleIndex = 1;
                    objSheet.Cells[1, titleIndex++] = "净值日期";
                    objSheet.Cells[1, titleIndex++] = "每万份收益（元)";
                    objSheet.Cells[1, titleIndex++] = "	7日年化收益率（%）";
                    objSheet.Cells[1, titleIndex++] = "申购状态";
                    objSheet.Cells[1, titleIndex++] = "赎回状态";
                    objSheet.Cells[1, titleIndex++] = "分红送配";

                    objSheet.Cells[1, 10] = "'1";

                    objRange = objSheet.get_Range("a1", "f1");//选中单元格
                    objRange.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 204, 153).ToArgb();
                    iRow = 2;
                    for (int j = 0; j < netValues.dates.Count; j++)
                    {
                        int col = 1;
                        objSheet.Cells[iRow, col++] = "'" + netValues.dates[j];
                        objSheet.Cells[iRow, col++] = "'" + netValues.netValues[j];
                        objSheet.Cells[iRow, col++] = "'" + netValues.dailyGrowthRates[j];
                        objSheet.Cells[iRow, col++] = netValues.subscribeStates[j];
                        objSheet.Cells[iRow, col++] = netValues.redeemStates[j];
                        objSheet.Cells[iRow, col++] = netValues.dividends[j];

                        iRow++;
                    }

                    objRange = objSheet.get_Range("a2", "f2");

                    objRange.EntireColumn.AutoFit();   //自动调整表格大小
                    objRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;//将所有单元格左对齐
                }

                //在表格底部添加时间
                objRange = objSheet.get_Range("a" + (iRow + 2).ToString(), "d" + (iRow + 2).ToString());//选中单元格
                objRange.Merge(0);//合并
                objRange.Value2 = DateTime.Now.ToString();//把时间赋值给单元格
                objRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;//中间对齐
                objRange.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 204, 153).ToArgb();

                this.excelHistoricalNetValueBook = objBook;

                objBook.Saved = true;//保存表格
                DateTime dtime = DateTime.Now;//获取当前时间

                string fileName = netValues.code + ".xls";
                string fileWay = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\historical_net_value\\" + fileName;
                objBook.SaveCopyAs(fileWay);//将表格拷贝到指定路径

                objBook.Close(true, Type.Missing, Type.Missing);//关闭表格
                objExcel = null;//清空Excel
                xlsApp.Quit();//释放资源
                xlsApp = null;
            }
        }

        public void updateNetValue(string code, FundMsgDownload fmDownload)
        {
            if (m_progressBar != null)
            {
                m_progressBar.Maximum = COUNT;
                m_progressBar.Value = 0;
                System.Windows.Forms.Application.DoEvents();
            }

            FundMsgDownload.HistoricalNetValues netValues = fmDownload.GetOneFundNetValue(code);

            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\historical_net_value\\" + code + ".xls";

            Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = false;//DisplayAlerts 属性设置成 False，就不会出现这种警告。 
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);//打开Excel
            Worksheet objSheet = (Worksheet)workbook.Worksheets.get_Item(1);

            //取出第一条时间的记录
            Range lastTimeRange = objSheet.get_Range("a2");
            string timeStr = lastTimeRange.Value.ToString();
            DateTime lastTime = DateTime.Parse(timeStr);////////////////

            //比较时间,判断是否需要更新
            DateTime newTime = DateTime.Parse(netValues.dates[0].ToString());

            TimeSpan dt = newTime - lastTime;
            int count = 0;
            while (dt.Days > 1)
            {
                count++;

                //进行更新,首先计算有多少需要更新
                newTime = DateTime.Parse(netValues.dates[count].ToString());
                dt = newTime - lastTime;

                if (m_progressBar != null)
                {
                    m_progressBar.Value++;
                    System.Windows.Forms.Application.DoEvents();
                }
            }

            for (int i = 0; i < count; i++)
            {
                Range range = (Range)objSheet.Rows[i + 2, Type.Missing];
                range.EntireRow.Insert(Microsoft.Office.Interop.Excel.XlDirection.xlDown, Microsoft.Office.Interop.Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove);
                range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 255).ToArgb();

                if (m_progressBar != null)
                {
                    m_progressBar.Value++;
                    System.Windows.Forms.Application.DoEvents();
                }
            }

            int iRow = 2;
            //判断基金显示模式
            if (netValues.mode == 0)
            {
                for (int j = 0; j < count; j++)
                {
                    int col = 1;
                    objSheet.Cells[iRow, col++] = "'" + netValues.dates[j];
                    objSheet.Cells[iRow, col++] = "'" + netValues.netValues[j];
                    objSheet.Cells[iRow, col++] = "'" + netValues.sumValues[j];
                    objSheet.Cells[iRow, col++] = "'" + netValues.dailyGrowthRates[j];
                    objSheet.Cells[iRow, col++] = netValues.subscribeStates[j];
                    objSheet.Cells[iRow, col++] = netValues.redeemStates[j];
                    objSheet.Cells[iRow, col++] = netValues.dividends[j];

                    iRow++;

                    if (m_progressBar != null)
                    {
                        m_progressBar.Value++;
                        System.Windows.Forms.Application.DoEvents();
                    }
                }
            }
            else
            {
                for (int j = 0; j < count; j++)
                {
                    int col = 1;
                    objSheet.Cells[iRow, col++] = "'" + netValues.dates[j];
                    objSheet.Cells[iRow, col++] = "'" + netValues.netValues[j];
                    objSheet.Cells[iRow, col++] = "'" + netValues.dailyGrowthRates[j];
                    objSheet.Cells[iRow, col++] = netValues.subscribeStates[j];
                    objSheet.Cells[iRow, col++] = netValues.redeemStates[j];
                    objSheet.Cells[iRow, col++] = netValues.dividends[j];

                    iRow++;

                    if (m_progressBar != null)
                    {
                        m_progressBar.Value++;
                        System.Windows.Forms.Application.DoEvents();
                    }
                }
            }
            
            
            workbook.Save();
            workbook.Close(true, Type.Missing, Type.Missing);//关闭表格
            appExcel.Quit();

            if (m_progressBar != null)
            {
                m_progressBar.Value = m_progressBar.Maximum;
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
