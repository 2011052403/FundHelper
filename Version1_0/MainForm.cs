using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Version1_0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            m_fundQueryRT = new FundQueryRT();
            m_fundQuery = new FundQuery();
            m_funMsg = new FundMsgDownload();
            m_fundLocalization = new FundLocalization();
            m_fundMsgDownload = new FundMsgDownload();
            m_netValueDT = new DataTable();

            //开启线程间操作控件
            //Control.CheckForIllegalCrossThreadCalls = false;

        }

        private bool checkinput = false;

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (checkinput == true)
            {
                this.m_fundQueryPanel.BringToFront();

                m_baseMsgDataGridView.Visible = true;
                m_dataGridView2.Visible = false;
                m_chart1.Visible = true;     
            }
            else
            {
                this.m_inputPanel.BringToFront();
            }
        }

        private void rankbutton_Click(object sender, EventArgs e)
        {
            /*
            if (m_bFirstClickRankBtn)
            {
                m_progressPanel.BringToFront();
                Application.DoEvents();

                m_funkRank = new FundRank();
                m_funkRank.m_progressBar = m_progressBar;
                m_funkRank.DownLoadPage();
                m_bFirstClickRankBtn = false;
                m_bExtractHtmlCompleted = true;     
            }
             * */
            
            
            this.m_fundRankingPanel.Visible = true;
            this.m_fundRankingPanel.BringToFront();

            this.m_rankTypeComboBox.Visible = true;

            m_rankTypeComboBox.SelectedIndex = 0;
          
        }

        /*
        private void ExtractHtmlThread()
        {
            m_progressBar.Value = 0;

            while (true)
            {
                if (m_bExtractHtmlCompleted == false)
                {
                    m_progressBar.Value++;
                    Application.DoEvents();
                    //Thread.Sleep(1000);
                }
                else
                {
                    break;
                }
            }
        }
         * */

        private void selectbutton_Click(object sender, EventArgs e)
        {       
            if (m_bFirstClickSelectedBtn)
            {
                m_progressPanel.BringToFront();
                Application.DoEvents();
                m_fundQuery.m_progressBar = m_progressBar;
                m_selectedDT = m_fundQuery.GetAllFundBaseMsgs();
                m_bFirstClickSelectedBtn = false;
            }

            this.m_selectPanel.BringToFront();
        }

        private void m_inputEnsureButton_Click(object sender, EventArgs e)
        {
            string fundMsg = m_inputTextBox.Text.ToString();
            m_fundQuery.m_progressBar = m_progressBar;
            m_inputEnsureButton.Enabled = false;

            DataTable dt1;
            
            if (m_idRadioButton.Checked == true)
            {
                dt1 = m_fundQuery.QueryFundBaseMsg(fundMsg, FundQuery.FUND_CODE);
            }
            else
            {
                dt1 = m_fundQuery.QueryFundBaseMsg(fundMsg, FundQuery.FUND_NAME);
            }
            

            if (dt1 == null)
            {
                //添加验证
                Point p = m_inputTextBox.Location;
                p.Y += 33;
                Graphics g = m_inputPanel.CreateGraphics();
                g.DrawString("不存在该基金,请重新选择!", new Font("宋体", 10), Brushes.Red, p.X, p.Y);

                m_inputEnsureButton.Enabled = true;

                return;
            }

            //显示进度条
            m_progressPanel.BringToFront();
            Application.DoEvents();
            checkinput = true;

            //绑定数据源
            m_baseMsgDataGridView.DataSource = dt1;
            m_baseMsgDataGridView.Height = m_baseMsgDataGridView.Rows.Count * m_baseMsgDataGridView.RowTemplate.Height + m_baseMsgDataGridView.ColumnHeadersHeight;

            DataTable dt2 = m_fundQuery.QueryFundNetValues();       
            m_dataGridView2.DataSource = dt2;

            /////////////
            if (m_bFirstClickRankBtn)
            {
                m_funkRank = new FundRank();
                m_funkRank.DownLoadPage();

                m_bFirstClickRankBtn = false;
            }

            
            m_netValueDT.Columns.Add("日期", System.Type.GetType("System.DateTime"));
            m_netValueDT.Columns.Add("单位净值", System.Type.GetType("System.String"));

            //计算纵坐标范围
            double max = 0;
            double min = 9999.00;

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DataRow dr3 = m_netValueDT.NewRow();
                dr3["日期"] = dt2.Rows[i][0];
                dr3["单位净值"] = dt2.Rows[i][1];

                double d = double.Parse(dt2.Rows[i][1].ToString());
                if (d > max)
                {
                    max = d;
                }
                else if (d < min)
                {
                    min = d;
                }

                m_netValueDT.Rows.Add(dr3);
            }

            m_netValueDT.DefaultView.Sort ="日期 asc";
            m_chart1.DataSource = m_netValueDT.DefaultView;

            //设置图表Y轴对应项
            m_chart1.Series[0].YValueMembers = "单位净值";

            //设置图表X轴对应项
            m_chart1.Series[0].XValueMember = "日期";

            //绑定数据
            m_chart1.DataBind();

            //确定y轴最大最小值
            m_chart1.ChartAreas[0].AxisY.Minimum = min;
            m_chart1.ChartAreas[0].AxisY.Maximum = max;

            this.m_fundQueryPanel.Visible = true;
            this.m_fundQueryPanel.BringToFront();

            m_baseMsgDataGridView.Visible = true;
            m_dataGridView2.Visible = false;
            m_chart1.Visible = true;

            m_inputEnsureButton.Enabled = true;
            m_rankButton.Enabled = true;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
            Animate.AnimateWindow(this.Handle, 700, Animate.AW_BLEND);
            this.Refresh();

            this.m_aboutPanel.Visible = true;
            this.m_aboutPanel.BringToFront();
            Application.DoEvents();
            
        }

        private void m_changeButton_Click(object sender, EventArgs e)
        {
            this.m_inputPanel.Visible = true;
            this.m_inputPanel.BringToFront();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (m_moveFlag)
                m_moveFlag = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (m_moveFlag && (e.Button == MouseButtons.Left))
                this.SetBounds(Left + e.X - x, Top + e.Y - y, this.Width, this.Height);
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!m_moveFlag && e.Clicks >= 1)
                m_moveFlag = true;
            x = e.X;
            y = e.Y;
            base.OnMouseDown(e);
        }

        private void m_aboutButton_Click(object sender, EventArgs e)
        {
            this.m_aboutPanel.Visible = true;
            this.m_aboutPanel.BringToFront();
        }

        private void m_exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_selectEnsureButton_Click(object sender, EventArgs e)
        {
            m_selectDataGridView.Visible = true;

            DataTable newDt = m_selectedDT.Clone();

            string scaleStr = "true";
            string typeStr = "true";
            string riskStr = "true";

            switch (m_riskSelectComboBox.SelectedIndex)
            {
                case 0:
                    riskStr = "风险类型='高风险'";
                    break;
                case 1:
                    riskStr = "风险类型='中高风险'";
                    break;
                case 2:
                    riskStr = "风险类型='中风险'";
                    break;
                case 3:
                    riskStr = "风险类型='中低风险'";
                    break;
                case 4:
                    riskStr = "风险类型='低风险'";
                    break;

                default:
                    break;
            }

            switch (m_scaleComboBox.SelectedIndex)
            {
                case 0:
                    scaleStr = "基金规模<10.0";
                    break;
                case 1:
                    scaleStr = "基金规模>'10' and 基金规模<'30'";
                    break;
                case 2:
                    scaleStr = "基金规模>'30' and 基金规模<'80'";
                    break;
                case 3:
                    scaleStr = "基金规模>'80' and 基金规模<'100'";
                    break;
                case 4:
                    scaleStr = "基金规模>'100'";
                    break;

                default:
                    break;
            }

            switch (m_typeSelectComboBox.SelectedIndex)
            {
                    /*
                     * 股票型
                       混合型
                       股票指数
                       定期债券
                       债券型
                       货币型
                       理财型
                       保本型
                       指数
                       分级
                       QDII
                     * 
                     * */
                case 0:
                    typeStr = "基金类型='股票型'";
                    break;
                case 1:
                    typeStr = "基金类型='混合型'";
                    break;
                case 2:
                    typeStr = "基金类型='股票指数'";
                    break;
                case 3:
                    typeStr = "基金类型='定期债券'";
                    break;
                case 4:
                    typeStr = "基金类型='债券型'";
                    break;
                case 5:
                    typeStr = "基金类型='货币型'";
                    break;
                case 6:
                    typeStr = "基金类型='理财型'";
                    break;
                case 7:
                    typeStr = "基金类型='保本型'";
                    break;
                case 8:
                    typeStr = "基金类型='指数'";
                    break;
                case 9:
                    typeStr = "基金类型='分级'";
                    break;
                case 10:
                    typeStr = "基金类型='QDII'";
                    break;

                default:
                    break;
            }

            DataRow[] dataRows = m_selectedDT.Select(scaleStr + " and " + riskStr + " and " + typeStr);

            for (int i = 0; i < dataRows.Length; i++)
            {
                newDt.ImportRow(dataRows[i]);
            }

            m_selectDataGridView.DataSource = newDt;
        }

        private void m_msgButton_Click(object sender, EventArgs e)
        {
            m_baseMsgDataGridView.Visible = true;
            m_dataGridView2.Visible = false;
            m_chart1.Visible = true;
        }

        private void m_gainButton_Click(object sender, EventArgs e)
        {
            m_endLabel.Visible = false;
            m_startLabel.Visible = false;
            m_startDateTimePicker.Visible = false;
            m_endDateTimePicker.Visible = false;
            m_baseMsgDataGridView.Visible = false;
            m_chart1.Visible = false;
            m_dataGridView2.Visible = true;
        }

        private void m_typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (m_rankTypeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        if (m_openTypeRankDT == null)
                        {
                            m_openTypeRankDT = m_funkRank.GetOpenTypeFundsRank();
                        }
                        m_rankDataGridView.DataSource = m_openTypeRankDT;
                        break;
                    }

                case 1:
                    {
                        if (m_closeTypeRankDT == null)
                        {
                            m_closeTypeRankDT = m_funkRank.GetCloseTypeFundsRank();
                        }
                        m_rankDataGridView.DataSource = m_closeTypeRankDT;
                        break;
                    }

                case 2:
                    {
                        if (m_currencyTypeRankDT == null)
                        {
                            m_currencyTypeRankDT = m_funkRank.GetCurrencyTypeFundsRank();
                        }
                        m_rankDataGridView.DataSource = m_currencyTypeRankDT;
                        break;
                    }              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_updatePanel.BringToFront();
        }

        private void m_confirmUpdateBtn_Click(object sender, EventArgs e)
        {
            //m_progressPanel.BringToFront();
            //Application.DoEvents();

            string code = m_updateTextBox.Text.ToString();
            //m_fundLocalization.m_progressBar = m_progressBar;
            m_fundLocalization.updateNetValue(code, m_fundMsgDownload);

            m_updatePanel.BringToFront();
            MessageBox.Show("更新成功！");
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = m_startDateTimePicker.Value;
            string startStr = start.ToString("yyyy-MM-dd");
            DateTime end = m_endDateTimePicker.Value;
            string endStr = end.ToString("yyyy-MM-dd");

            DataTable dt = m_netValueDT.Clone();
            DataRow[] dataRows = m_netValueDT.Select("日期>='" + startStr + "' and " + "日期<='" + endStr + "'");

            for (int i = 0; i < dataRows.Length; i++)
            {
                dt.ImportRow(dataRows[i]);
            }

            m_chart1.DataSource = dt;

            //计算纵坐标范围
            double max = 0;
            double min = 9999.00;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double d = double.Parse(dt.Rows[i][1].ToString());
                if (d > max)
                {
                    max = d;
                }
                else if (d < min)
                {
                    min = d;
                }
            }
            //确定y轴最大最小值
            m_chart1.ChartAreas[0].AxisY.Minimum = min;
            m_chart1.ChartAreas[0].AxisY.Maximum = max;

            m_chart1.DataBind();
        }

        private void OnkeyDown(object sender, KeyEventArgs e)
        {
            m_inputPanel.Refresh();
        }


    }
}
