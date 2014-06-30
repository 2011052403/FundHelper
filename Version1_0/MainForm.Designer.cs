using System.Data;
using System.Drawing;
namespace Version1_0
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_nameRadioButton = new System.Windows.Forms.RadioButton();
            this.m_idRadioButton = new System.Windows.Forms.RadioButton();
            this.m_inputEnsureButton = new System.Windows.Forms.Button();
            this.m_inputTextBox = new System.Windows.Forms.TextBox();
            this.m_inputLabel = new System.Windows.Forms.Label();
            this.m_fundQueryPanel = new System.Windows.Forms.Panel();
            this.m_endLabel = new System.Windows.Forms.Label();
            this.m_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_startLabel = new System.Windows.Forms.Label();
            this.m_startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_baseMsgDataGridView = new System.Windows.Forms.DataGridView();
            this.m_gainButton = new System.Windows.Forms.Button();
            this.m_msgButton = new System.Windows.Forms.Button();
            this.m_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.m_selectPanel = new System.Windows.Forms.Panel();
            this.m_selectDataGridView = new System.Windows.Forms.DataGridView();
            this.m_selectEnsureButton = new System.Windows.Forms.Button();
            this.m_scaleComboBox = new System.Windows.Forms.ComboBox();
            this.m_riskSelectComboBox = new System.Windows.Forms.ComboBox();
            this.m_typeSelectComboBox = new System.Windows.Forms.ComboBox();
            this.m_sizeSelectLabel = new System.Windows.Forms.Label();
            this.m_riskSelectLabel = new System.Windows.Forms.Label();
            this.m_typeSelectLabel = new System.Windows.Forms.Label();
            this.m_selectLabel = new System.Windows.Forms.Label();
            this.m_aboutPanel = new System.Windows.Forms.Panel();
            this.m_aboutGroupLabel = new System.Windows.Forms.Label();
            this.m_aboutPictureBox = new System.Windows.Forms.PictureBox();
            this.m_aboutButton = new System.Windows.Forms.Button();
            this.m_exitButton = new System.Windows.Forms.Button();
            this.m_changeButton = new System.Windows.Forms.Button();
            this.m_selectButton = new System.Windows.Forms.Button();
            this.m_rankButton = new System.Windows.Forms.Button();
            this.m_searchButton = new System.Windows.Forms.Button();
            this.m_backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.m_fundRankingPanel = new System.Windows.Forms.Panel();
            this.m_rankDataGridView = new System.Windows.Forms.DataGridView();
            this.m_rankTypeComboBox = new System.Windows.Forms.ComboBox();
            this.m_updateBtn = new System.Windows.Forms.Button();
            this.m_updatePanel = new System.Windows.Forms.Panel();
            this.m_updateNameRadioButton = new System.Windows.Forms.RadioButton();
            this.m_codeRadioButton = new System.Windows.Forms.RadioButton();
            this.m_confirmUpdateBtn = new System.Windows.Forms.Button();
            this.m_updateTextBox = new System.Windows.Forms.TextBox();
            this.m_updateLabel = new System.Windows.Forms.Label();
            this.m_inputPanel = new System.Windows.Forms.Panel();
            this.m_progressPanel = new System.Windows.Forms.Panel();
            this.m_tipLabel = new System.Windows.Forms.Label();
            this.m_progressBar = new System.Windows.Forms.ProgressBar();
            this.m_fundQueryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_baseMsgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridView2)).BeginInit();
            this.m_selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_selectDataGridView)).BeginInit();
            this.m_aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_aboutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_backgroundPictureBox)).BeginInit();
            this.m_fundRankingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_rankDataGridView)).BeginInit();
            this.m_updatePanel.SuspendLayout();
            this.m_inputPanel.SuspendLayout();
            this.m_progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_nameRadioButton
            // 
            this.m_nameRadioButton.AutoSize = true;
            this.m_nameRadioButton.Location = new System.Drawing.Point(229, 255);
            this.m_nameRadioButton.Name = "m_nameRadioButton";
            this.m_nameRadioButton.Size = new System.Drawing.Size(59, 16);
            this.m_nameRadioButton.TabIndex = 6;
            this.m_nameRadioButton.Text = "按名称";
            this.m_nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_idRadioButton
            // 
            this.m_idRadioButton.AutoSize = true;
            this.m_idRadioButton.Checked = true;
            this.m_idRadioButton.Location = new System.Drawing.Point(136, 255);
            this.m_idRadioButton.Name = "m_idRadioButton";
            this.m_idRadioButton.Size = new System.Drawing.Size(59, 16);
            this.m_idRadioButton.TabIndex = 5;
            this.m_idRadioButton.TabStop = true;
            this.m_idRadioButton.Text = "按代码";
            this.m_idRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_inputEnsureButton
            // 
            this.m_inputEnsureButton.Location = new System.Drawing.Point(449, 252);
            this.m_inputEnsureButton.Name = "m_inputEnsureButton";
            this.m_inputEnsureButton.Size = new System.Drawing.Size(75, 23);
            this.m_inputEnsureButton.TabIndex = 4;
            this.m_inputEnsureButton.Text = "确定";
            this.m_inputEnsureButton.UseVisualStyleBackColor = true;
            this.m_inputEnsureButton.Click += new System.EventHandler(this.m_inputEnsureButton_Click);
            // 
            // m_inputTextBox
            // 
            this.m_inputTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_inputTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.m_inputTextBox.Location = new System.Drawing.Point(136, 180);
            this.m_inputTextBox.Multiline = true;
            this.m_inputTextBox.Name = "m_inputTextBox";
            this.m_inputTextBox.Size = new System.Drawing.Size(388, 28);
            this.m_inputTextBox.TabIndex = 1;
            this.m_inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnkeyDown);
            // 
            // m_inputLabel
            // 
            this.m_inputLabel.AutoSize = true;
            this.m_inputLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_inputLabel.Location = new System.Drawing.Point(69, 111);
            this.m_inputLabel.Name = "m_inputLabel";
            this.m_inputLabel.Size = new System.Drawing.Size(199, 19);
            this.m_inputLabel.TabIndex = 0;
            this.m_inputLabel.Text = "请输入要查询的基金：";
            // 
            // m_fundQueryPanel
            // 
            this.m_fundQueryPanel.BackColor = System.Drawing.Color.White;
            this.m_fundQueryPanel.Controls.Add(this.m_endLabel);
            this.m_fundQueryPanel.Controls.Add(this.m_endDateTimePicker);
            this.m_fundQueryPanel.Controls.Add(this.m_startLabel);
            this.m_fundQueryPanel.Controls.Add(this.m_startDateTimePicker);
            this.m_fundQueryPanel.Controls.Add(this.m_baseMsgDataGridView);
            this.m_fundQueryPanel.Controls.Add(this.m_gainButton);
            this.m_fundQueryPanel.Controls.Add(this.m_msgButton);
            this.m_fundQueryPanel.Controls.Add(this.m_chart1);
            this.m_fundQueryPanel.Controls.Add(this.m_dataGridView2);
            this.m_fundQueryPanel.Location = new System.Drawing.Point(130, 106);
            this.m_fundQueryPanel.Name = "m_fundQueryPanel";
            this.m_fundQueryPanel.Size = new System.Drawing.Size(654, 440);
            this.m_fundQueryPanel.TabIndex = 5;
            this.m_fundQueryPanel.Visible = false;
            // 
            // m_endLabel
            // 
            this.m_endLabel.AutoSize = true;
            this.m_endLabel.Location = new System.Drawing.Point(518, 240);
            this.m_endLabel.Name = "m_endLabel";
            this.m_endLabel.Size = new System.Drawing.Size(35, 12);
            this.m_endLabel.TabIndex = 8;
            this.m_endLabel.Text = "结束:";
            // 
            // m_endDateTimePicker
            // 
            this.m_endDateTimePicker.Location = new System.Drawing.Point(520, 255);
            this.m_endDateTimePicker.Name = "m_endDateTimePicker";
            this.m_endDateTimePicker.Size = new System.Drawing.Size(104, 21);
            this.m_endDateTimePicker.TabIndex = 7;
            this.m_endDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // m_startLabel
            // 
            this.m_startLabel.AutoSize = true;
            this.m_startLabel.Location = new System.Drawing.Point(518, 180);
            this.m_startLabel.Name = "m_startLabel";
            this.m_startLabel.Size = new System.Drawing.Size(35, 12);
            this.m_startLabel.TabIndex = 6;
            this.m_startLabel.Text = "开始:";
            // 
            // m_startDateTimePicker
            // 
            this.m_startDateTimePicker.Location = new System.Drawing.Point(520, 195);
            this.m_startDateTimePicker.Name = "m_startDateTimePicker";
            this.m_startDateTimePicker.Size = new System.Drawing.Size(104, 21);
            this.m_startDateTimePicker.TabIndex = 5;
            this.m_startDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // m_baseMsgDataGridView
            // 
            this.m_baseMsgDataGridView.AllowUserToAddRows = false;
            this.m_baseMsgDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_baseMsgDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_baseMsgDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_baseMsgDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.m_baseMsgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_baseMsgDataGridView.DefaultCellStyle = dataGridViewCellStyle43;
            this.m_baseMsgDataGridView.Enabled = false;
            this.m_baseMsgDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.m_baseMsgDataGridView.Location = new System.Drawing.Point(61, 60);
            this.m_baseMsgDataGridView.Name = "m_baseMsgDataGridView";
            this.m_baseMsgDataGridView.ReadOnly = true;
            this.m_baseMsgDataGridView.RowHeadersVisible = false;
            this.m_baseMsgDataGridView.RowTemplate.Height = 23;
            this.m_baseMsgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_baseMsgDataGridView.Size = new System.Drawing.Size(540, 50);
            this.m_baseMsgDataGridView.TabIndex = 2;
            // 
            // m_gainButton
            // 
            this.m_gainButton.BackgroundImage = global::Version1_0.Properties.Resources.button_5;
            this.m_gainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_gainButton.FlatAppearance.BorderSize = 0;
            this.m_gainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_gainButton.Location = new System.Drawing.Point(136, 12);
            this.m_gainButton.Name = "m_gainButton";
            this.m_gainButton.Size = new System.Drawing.Size(118, 30);
            this.m_gainButton.TabIndex = 1;
            this.m_gainButton.UseVisualStyleBackColor = true;
            this.m_gainButton.Click += new System.EventHandler(this.m_gainButton_Click);
            // 
            // m_msgButton
            // 
            this.m_msgButton.BackgroundImage = global::Version1_0.Properties.Resources.button_4;
            this.m_msgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_msgButton.FlatAppearance.BorderSize = 0;
            this.m_msgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_msgButton.Location = new System.Drawing.Point(12, 12);
            this.m_msgButton.Name = "m_msgButton";
            this.m_msgButton.Size = new System.Drawing.Size(118, 30);
            this.m_msgButton.TabIndex = 0;
            this.m_msgButton.UseVisualStyleBackColor = true;
            this.m_msgButton.Click += new System.EventHandler(this.m_msgButton_Click);
            // 
            // m_chart1
            // 
            chartArea15.Name = "ChartArea1";
            this.m_chart1.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.m_chart1.Legends.Add(legend15);
            this.m_chart1.Location = new System.Drawing.Point(-6, 116);
            this.m_chart1.Name = "m_chart1";
            this.m_chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "单位净值";
            this.m_chart1.Series.Add(series15);
            this.m_chart1.Size = new System.Drawing.Size(654, 308);
            this.m_chart1.TabIndex = 4;
            this.m_chart1.Text = "chart1";
            // 
            // m_dataGridView2
            // 
            this.m_dataGridView2.AllowUserToAddRows = false;
            this.m_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.m_dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.m_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dataGridView2.DefaultCellStyle = dataGridViewCellStyle44;
            this.m_dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.m_dataGridView2.Location = new System.Drawing.Point(61, 60);
            this.m_dataGridView2.Name = "m_dataGridView2";
            this.m_dataGridView2.ReadOnly = true;
            this.m_dataGridView2.RowHeadersVisible = false;
            this.m_dataGridView2.RowTemplate.Height = 23;
            this.m_dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dataGridView2.Size = new System.Drawing.Size(540, 330);
            this.m_dataGridView2.TabIndex = 3;
            // 
            // m_selectPanel
            // 
            this.m_selectPanel.BackColor = System.Drawing.Color.White;
            this.m_selectPanel.Controls.Add(this.m_selectDataGridView);
            this.m_selectPanel.Controls.Add(this.m_selectEnsureButton);
            this.m_selectPanel.Controls.Add(this.m_scaleComboBox);
            this.m_selectPanel.Controls.Add(this.m_riskSelectComboBox);
            this.m_selectPanel.Controls.Add(this.m_typeSelectComboBox);
            this.m_selectPanel.Controls.Add(this.m_sizeSelectLabel);
            this.m_selectPanel.Controls.Add(this.m_riskSelectLabel);
            this.m_selectPanel.Controls.Add(this.m_typeSelectLabel);
            this.m_selectPanel.Controls.Add(this.m_selectLabel);
            this.m_selectPanel.Location = new System.Drawing.Point(130, 106);
            this.m_selectPanel.Name = "m_selectPanel";
            this.m_selectPanel.Size = new System.Drawing.Size(654, 440);
            this.m_selectPanel.TabIndex = 3;
            // 
            // m_selectDataGridView
            // 
            this.m_selectDataGridView.AllowUserToAddRows = false;
            this.m_selectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_selectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.m_selectDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_selectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_selectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.m_selectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_selectDataGridView.DefaultCellStyle = dataGridViewCellStyle45;
            this.m_selectDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.m_selectDataGridView.Location = new System.Drawing.Point(57, 133);
            this.m_selectDataGridView.Name = "m_selectDataGridView";
            this.m_selectDataGridView.ReadOnly = true;
            this.m_selectDataGridView.RowHeadersVisible = false;
            this.m_selectDataGridView.RowTemplate.Height = 23;
            this.m_selectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_selectDataGridView.Size = new System.Drawing.Size(540, 252);
            this.m_selectDataGridView.TabIndex = 10;
            this.m_selectDataGridView.Visible = false;
            // 
            // m_selectEnsureButton
            // 
            this.m_selectEnsureButton.Location = new System.Drawing.Point(516, 83);
            this.m_selectEnsureButton.Name = "m_selectEnsureButton";
            this.m_selectEnsureButton.Size = new System.Drawing.Size(75, 23);
            this.m_selectEnsureButton.TabIndex = 9;
            this.m_selectEnsureButton.Text = "开始筛选";
            this.m_selectEnsureButton.UseVisualStyleBackColor = true;
            this.m_selectEnsureButton.Click += new System.EventHandler(this.m_selectEnsureButton_Click);
            // 
            // m_scaleComboBox
            // 
            this.m_scaleComboBox.FormattingEnabled = true;
            this.m_scaleComboBox.Items.AddRange(new object[] {
            "10亿以下",
            "10亿~30亿",
            "30亿~50亿",
            "50亿~100亿",
            "100亿以上"});
            this.m_scaleComboBox.Location = new System.Drawing.Point(359, 80);
            this.m_scaleComboBox.Name = "m_scaleComboBox";
            this.m_scaleComboBox.Size = new System.Drawing.Size(103, 20);
            this.m_scaleComboBox.TabIndex = 6;
            this.m_scaleComboBox.Text = "不限";
            // 
            // m_riskSelectComboBox
            // 
            this.m_riskSelectComboBox.FormattingEnabled = true;
            this.m_riskSelectComboBox.Items.AddRange(new object[] {
            "高",
            "中高",
            "中",
            "中低",
            "低"});
            this.m_riskSelectComboBox.Location = new System.Drawing.Point(124, 80);
            this.m_riskSelectComboBox.Name = "m_riskSelectComboBox";
            this.m_riskSelectComboBox.Size = new System.Drawing.Size(103, 20);
            this.m_riskSelectComboBox.TabIndex = 5;
            this.m_riskSelectComboBox.Text = "不限";
            // 
            // m_typeSelectComboBox
            // 
            this.m_typeSelectComboBox.FormattingEnabled = true;
            this.m_typeSelectComboBox.Items.AddRange(new object[] {
            "股票型",
            "混合型",
            "股票指数",
            "定期债券",
            "债券型",
            "货币型",
            "理财型",
            "保本型",
            "指数",
            "分级",
            "QDII"});
            this.m_typeSelectComboBox.Location = new System.Drawing.Point(359, 45);
            this.m_typeSelectComboBox.Name = "m_typeSelectComboBox";
            this.m_typeSelectComboBox.Size = new System.Drawing.Size(103, 20);
            this.m_typeSelectComboBox.TabIndex = 4;
            this.m_typeSelectComboBox.Text = "不限";
            // 
            // m_sizeSelectLabel
            // 
            this.m_sizeSelectLabel.AutoSize = true;
            this.m_sizeSelectLabel.Location = new System.Drawing.Point(284, 83);
            this.m_sizeSelectLabel.Name = "m_sizeSelectLabel";
            this.m_sizeSelectLabel.Size = new System.Drawing.Size(59, 12);
            this.m_sizeSelectLabel.TabIndex = 3;
            this.m_sizeSelectLabel.Text = "基金规模:";
            // 
            // m_riskSelectLabel
            // 
            this.m_riskSelectLabel.AutoSize = true;
            this.m_riskSelectLabel.Location = new System.Drawing.Point(59, 83);
            this.m_riskSelectLabel.Name = "m_riskSelectLabel";
            this.m_riskSelectLabel.Size = new System.Drawing.Size(59, 12);
            this.m_riskSelectLabel.TabIndex = 2;
            this.m_riskSelectLabel.Text = "风险等级:";
            // 
            // m_typeSelectLabel
            // 
            this.m_typeSelectLabel.AutoSize = true;
            this.m_typeSelectLabel.Location = new System.Drawing.Point(284, 48);
            this.m_typeSelectLabel.Name = "m_typeSelectLabel";
            this.m_typeSelectLabel.Size = new System.Drawing.Size(59, 12);
            this.m_typeSelectLabel.TabIndex = 1;
            this.m_typeSelectLabel.Text = "基金类型:";
            // 
            // m_selectLabel
            // 
            this.m_selectLabel.AutoSize = true;
            this.m_selectLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_selectLabel.Location = new System.Drawing.Point(60, 46);
            this.m_selectLabel.Name = "m_selectLabel";
            this.m_selectLabel.Size = new System.Drawing.Size(59, 12);
            this.m_selectLabel.TabIndex = 0;
            this.m_selectLabel.Text = "筛选条件:";
            // 
            // m_aboutPanel
            // 
            this.m_aboutPanel.BackColor = System.Drawing.Color.White;
            this.m_aboutPanel.Controls.Add(this.m_aboutGroupLabel);
            this.m_aboutPanel.Controls.Add(this.m_aboutPictureBox);
            this.m_aboutPanel.Location = new System.Drawing.Point(130, 106);
            this.m_aboutPanel.Name = "m_aboutPanel";
            this.m_aboutPanel.Size = new System.Drawing.Size(654, 440);
            this.m_aboutPanel.TabIndex = 10;
            // 
            // m_aboutGroupLabel
            // 
            this.m_aboutGroupLabel.AutoSize = true;
            this.m_aboutGroupLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_aboutGroupLabel.Location = new System.Drawing.Point(512, 393);
            this.m_aboutGroupLabel.Name = "m_aboutGroupLabel";
            this.m_aboutGroupLabel.Size = new System.Drawing.Size(108, 20);
            this.m_aboutGroupLabel.TabIndex = 1;
            this.m_aboutGroupLabel.Text = "By Group4";
            // 
            // m_aboutPictureBox
            // 
            this.m_aboutPictureBox.BackgroundImage = global::Version1_0.Properties.Resources.关于;
            this.m_aboutPictureBox.Location = new System.Drawing.Point(2, 15);
            this.m_aboutPictureBox.Name = "m_aboutPictureBox";
            this.m_aboutPictureBox.Size = new System.Drawing.Size(650, 355);
            this.m_aboutPictureBox.TabIndex = 0;
            this.m_aboutPictureBox.TabStop = false;
            // 
            // m_aboutButton
            // 
            this.m_aboutButton.BackgroundImage = global::Version1_0.Properties.Resources.button_71;
            this.m_aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_aboutButton.FlatAppearance.BorderSize = 0;
            this.m_aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_aboutButton.Location = new System.Drawing.Point(0, 473);
            this.m_aboutButton.Name = "m_aboutButton";
            this.m_aboutButton.Size = new System.Drawing.Size(118, 30);
            this.m_aboutButton.TabIndex = 9;
            this.m_aboutButton.UseVisualStyleBackColor = true;
            this.m_aboutButton.Click += new System.EventHandler(this.m_aboutButton_Click);
            // 
            // m_exitButton
            // 
            this.m_exitButton.BackgroundImage = global::Version1_0.Properties.Resources.button_81;
            this.m_exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_exitButton.FlatAppearance.BorderSize = 0;
            this.m_exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_exitButton.Location = new System.Drawing.Point(0, 516);
            this.m_exitButton.Name = "m_exitButton";
            this.m_exitButton.Size = new System.Drawing.Size(118, 30);
            this.m_exitButton.TabIndex = 8;
            this.m_exitButton.UseVisualStyleBackColor = true;
            this.m_exitButton.Click += new System.EventHandler(this.m_exitButton_Click);
            // 
            // m_changeButton
            // 
            this.m_changeButton.BackgroundImage = global::Version1_0.Properties.Resources.button_61;
            this.m_changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_changeButton.FlatAppearance.BorderSize = 0;
            this.m_changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_changeButton.Location = new System.Drawing.Point(0, 429);
            this.m_changeButton.Name = "m_changeButton";
            this.m_changeButton.Size = new System.Drawing.Size(118, 30);
            this.m_changeButton.TabIndex = 7;
            this.m_changeButton.UseVisualStyleBackColor = true;
            this.m_changeButton.Click += new System.EventHandler(this.m_changeButton_Click);
            // 
            // m_selectButton
            // 
            this.m_selectButton.BackgroundImage = global::Version1_0.Properties.Resources.button_3;
            this.m_selectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_selectButton.FlatAppearance.BorderSize = 0;
            this.m_selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_selectButton.Location = new System.Drawing.Point(0, 217);
            this.m_selectButton.Name = "m_selectButton";
            this.m_selectButton.Size = new System.Drawing.Size(118, 30);
            this.m_selectButton.TabIndex = 5;
            this.m_selectButton.UseVisualStyleBackColor = true;
            this.m_selectButton.Click += new System.EventHandler(this.selectbutton_Click);
            // 
            // m_rankButton
            // 
            this.m_rankButton.BackgroundImage = global::Version1_0.Properties.Resources.button_2;
            this.m_rankButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_rankButton.Enabled = false;
            this.m_rankButton.FlatAppearance.BorderSize = 0;
            this.m_rankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_rankButton.Location = new System.Drawing.Point(0, 171);
            this.m_rankButton.Name = "m_rankButton";
            this.m_rankButton.Size = new System.Drawing.Size(118, 30);
            this.m_rankButton.TabIndex = 2;
            this.m_rankButton.UseVisualStyleBackColor = true;
            this.m_rankButton.Click += new System.EventHandler(this.rankbutton_Click);
            // 
            // m_searchButton
            // 
            this.m_searchButton.BackgroundImage = global::Version1_0.Properties.Resources.button_1;
            this.m_searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_searchButton.FlatAppearance.BorderSize = 0;
            this.m_searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_searchButton.Location = new System.Drawing.Point(0, 125);
            this.m_searchButton.Name = "m_searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(118, 30);
            this.m_searchButton.TabIndex = 1;
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // m_backgroundPictureBox
            // 
            this.m_backgroundPictureBox.BackgroundImage = global::Version1_0.Properties.Resources.initpintu_副本;
            this.m_backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_backgroundPictureBox.Name = "m_backgroundPictureBox";
            this.m_backgroundPictureBox.Size = new System.Drawing.Size(800, 90);
            this.m_backgroundPictureBox.TabIndex = 0;
            this.m_backgroundPictureBox.TabStop = false;
            // 
            // m_fundRankingPanel
            // 
            this.m_fundRankingPanel.BackColor = System.Drawing.Color.White;
            this.m_fundRankingPanel.Controls.Add(this.m_rankDataGridView);
            this.m_fundRankingPanel.Controls.Add(this.m_rankTypeComboBox);
            this.m_fundRankingPanel.Location = new System.Drawing.Point(133, 110);
            this.m_fundRankingPanel.Name = "m_fundRankingPanel";
            this.m_fundRankingPanel.Size = new System.Drawing.Size(648, 434);
            this.m_fundRankingPanel.TabIndex = 11;
            // 
            // m_rankDataGridView
            // 
            this.m_rankDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_rankDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.m_rankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_rankDataGridView.Location = new System.Drawing.Point(54, 76);
            this.m_rankDataGridView.Name = "m_rankDataGridView";
            this.m_rankDataGridView.RowTemplate.Height = 23;
            this.m_rankDataGridView.Size = new System.Drawing.Size(544, 333);
            this.m_rankDataGridView.TabIndex = 15;
            // 
            // m_rankTypeComboBox
            // 
            this.m_rankTypeComboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_rankTypeComboBox.FormattingEnabled = true;
            this.m_rankTypeComboBox.Items.AddRange(new object[] {
            "开放式基金",
            "封闭式基金",
            "货币式基金"});
            this.m_rankTypeComboBox.Location = new System.Drawing.Point(494, 23);
            this.m_rankTypeComboBox.Name = "m_rankTypeComboBox";
            this.m_rankTypeComboBox.Size = new System.Drawing.Size(99, 22);
            this.m_rankTypeComboBox.TabIndex = 3;
            this.m_rankTypeComboBox.Text = "基金类型";
            this.m_rankTypeComboBox.Visible = false;
            this.m_rankTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.m_typeComboBox_SelectedIndexChanged);
            // 
            // m_updateBtn
            // 
            this.m_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("m_updateBtn.Image")));
            this.m_updateBtn.Location = new System.Drawing.Point(0, 262);
            this.m_updateBtn.Name = "m_updateBtn";
            this.m_updateBtn.Size = new System.Drawing.Size(118, 33);
            this.m_updateBtn.TabIndex = 12;
            this.m_updateBtn.UseVisualStyleBackColor = true;
            this.m_updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_updatePanel
            // 
            this.m_updatePanel.BackColor = System.Drawing.Color.White;
            this.m_updatePanel.Controls.Add(this.m_updateNameRadioButton);
            this.m_updatePanel.Controls.Add(this.m_codeRadioButton);
            this.m_updatePanel.Controls.Add(this.m_confirmUpdateBtn);
            this.m_updatePanel.Controls.Add(this.m_updateTextBox);
            this.m_updatePanel.Controls.Add(this.m_updateLabel);
            this.m_updatePanel.Location = new System.Drawing.Point(130, 106);
            this.m_updatePanel.Name = "m_updatePanel";
            this.m_updatePanel.Size = new System.Drawing.Size(654, 440);
            this.m_updatePanel.TabIndex = 13;
            // 
            // m_updateNameRadioButton
            // 
            this.m_updateNameRadioButton.AutoSize = true;
            this.m_updateNameRadioButton.Location = new System.Drawing.Point(229, 258);
            this.m_updateNameRadioButton.Name = "m_updateNameRadioButton";
            this.m_updateNameRadioButton.Size = new System.Drawing.Size(59, 16);
            this.m_updateNameRadioButton.TabIndex = 11;
            this.m_updateNameRadioButton.Text = "按名称";
            this.m_updateNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_codeRadioButton
            // 
            this.m_codeRadioButton.AutoSize = true;
            this.m_codeRadioButton.Checked = true;
            this.m_codeRadioButton.Location = new System.Drawing.Point(136, 258);
            this.m_codeRadioButton.Name = "m_codeRadioButton";
            this.m_codeRadioButton.Size = new System.Drawing.Size(59, 16);
            this.m_codeRadioButton.TabIndex = 10;
            this.m_codeRadioButton.TabStop = true;
            this.m_codeRadioButton.Text = "按代码";
            this.m_codeRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_confirmUpdateBtn
            // 
            this.m_confirmUpdateBtn.Location = new System.Drawing.Point(449, 255);
            this.m_confirmUpdateBtn.Name = "m_confirmUpdateBtn";
            this.m_confirmUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.m_confirmUpdateBtn.TabIndex = 9;
            this.m_confirmUpdateBtn.Text = "确定";
            this.m_confirmUpdateBtn.UseVisualStyleBackColor = true;
            this.m_confirmUpdateBtn.Click += new System.EventHandler(this.m_confirmUpdateBtn_Click);
            // 
            // m_updateTextBox
            // 
            this.m_updateTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_updateTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.m_updateTextBox.Location = new System.Drawing.Point(136, 183);
            this.m_updateTextBox.Multiline = true;
            this.m_updateTextBox.Name = "m_updateTextBox";
            this.m_updateTextBox.Size = new System.Drawing.Size(388, 25);
            this.m_updateTextBox.TabIndex = 8;
            // 
            // m_updateLabel
            // 
            this.m_updateLabel.AutoSize = true;
            this.m_updateLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_updateLabel.Location = new System.Drawing.Point(69, 114);
            this.m_updateLabel.Name = "m_updateLabel";
            this.m_updateLabel.Size = new System.Drawing.Size(199, 19);
            this.m_updateLabel.TabIndex = 7;
            this.m_updateLabel.Text = "请输入要更新的基金：";
            // 
            // m_inputPanel
            // 
            this.m_inputPanel.BackColor = System.Drawing.Color.White;
            this.m_inputPanel.Controls.Add(this.m_nameRadioButton);
            this.m_inputPanel.Controls.Add(this.m_idRadioButton);
            this.m_inputPanel.Controls.Add(this.m_inputEnsureButton);
            this.m_inputPanel.Controls.Add(this.m_inputTextBox);
            this.m_inputPanel.Controls.Add(this.m_inputLabel);
            this.m_inputPanel.Location = new System.Drawing.Point(130, 106);
            this.m_inputPanel.Name = "m_inputPanel";
            this.m_inputPanel.Size = new System.Drawing.Size(654, 440);
            this.m_inputPanel.TabIndex = 6;
            // 
            // m_progressPanel
            // 
            this.m_progressPanel.BackColor = System.Drawing.Color.White;
            this.m_progressPanel.Controls.Add(this.m_tipLabel);
            this.m_progressPanel.Controls.Add(this.m_progressBar);
            this.m_progressPanel.Location = new System.Drawing.Point(130, 106);
            this.m_progressPanel.Name = "m_progressPanel";
            this.m_progressPanel.Size = new System.Drawing.Size(654, 440);
            this.m_progressPanel.TabIndex = 14;
            // 
            // m_tipLabel
            // 
            this.m_tipLabel.AutoSize = true;
            this.m_tipLabel.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_tipLabel.Location = new System.Drawing.Point(60, 133);
            this.m_tipLabel.Name = "m_tipLabel";
            this.m_tipLabel.Size = new System.Drawing.Size(165, 13);
            this.m_tipLabel.TabIndex = 1;
            this.m_tipLabel.Text = "系统提取数据中,请稍等...";
            // 
            // m_progressBar
            // 
            this.m_progressBar.Location = new System.Drawing.Point(61, 183);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(535, 20);
            this.m_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.m_progressBar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(796, 554);
            this.Controls.Add(this.m_updateBtn);
            this.Controls.Add(this.m_aboutButton);
            this.Controls.Add(this.m_exitButton);
            this.Controls.Add(this.m_changeButton);
            this.Controls.Add(this.m_selectButton);
            this.Controls.Add(this.m_rankButton);
            this.Controls.Add(this.m_searchButton);
            this.Controls.Add(this.m_backgroundPictureBox);
            this.Controls.Add(this.m_inputPanel);
            this.Controls.Add(this.m_progressPanel);
            this.Controls.Add(this.m_selectPanel);
            this.Controls.Add(this.m_fundRankingPanel);
            this.Controls.Add(this.m_updatePanel);
            this.Controls.Add(this.m_fundQueryPanel);
            this.Controls.Add(this.m_aboutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帮我选基金";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.m_fundQueryPanel.ResumeLayout(false);
            this.m_fundQueryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_baseMsgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridView2)).EndInit();
            this.m_selectPanel.ResumeLayout(false);
            this.m_selectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_selectDataGridView)).EndInit();
            this.m_aboutPanel.ResumeLayout(false);
            this.m_aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_aboutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_backgroundPictureBox)).EndInit();
            this.m_fundRankingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_rankDataGridView)).EndInit();
            this.m_updatePanel.ResumeLayout(false);
            this.m_updatePanel.PerformLayout();
            this.m_inputPanel.ResumeLayout(false);
            this.m_inputPanel.PerformLayout();
            this.m_progressPanel.ResumeLayout(false);
            this.m_progressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_backgroundPictureBox;
        private System.Windows.Forms.Button m_searchButton;
        private System.Windows.Forms.Button m_rankButton;
        private System.Windows.Forms.Button m_selectButton;
        private System.Windows.Forms.Panel m_inputPanel;
        private System.Windows.Forms.Button m_inputEnsureButton;
        private System.Windows.Forms.TextBox m_inputTextBox;
        private System.Windows.Forms.Label m_inputLabel;
        private System.Windows.Forms.Panel m_fundQueryPanel;
        private System.Windows.Forms.Button m_msgButton;
        private System.Windows.Forms.Button m_gainButton;
        private System.Windows.Forms.Button m_changeButton;
        private System.Windows.Forms.Button m_exitButton;
        private System.Windows.Forms.Button m_aboutButton;
        private System.Windows.Forms.Panel m_selectPanel;
        private System.Windows.Forms.ComboBox m_scaleComboBox;
        private System.Windows.Forms.ComboBox m_riskSelectComboBox;
        private System.Windows.Forms.ComboBox m_typeSelectComboBox;
        private System.Windows.Forms.Label m_sizeSelectLabel;
        private System.Windows.Forms.Label m_riskSelectLabel;
        private System.Windows.Forms.Label m_typeSelectLabel;
        private System.Windows.Forms.Label m_selectLabel;
        private System.Windows.Forms.Button m_selectEnsureButton;
        private System.Windows.Forms.Panel m_aboutPanel;
        private System.Windows.Forms.PictureBox m_aboutPictureBox;
        private System.Windows.Forms.Label m_aboutGroupLabel;
        private System.Windows.Forms.RadioButton m_nameRadioButton;
        private System.Windows.Forms.RadioButton m_idRadioButton;

        private FundQueryRT m_fundQueryRT;
        private FundMsgDownload m_funMsg;
        private FundLocalization m_fundLocalization;
        private FundQuery m_fundQuery;
        private FundMsgDownload m_fundMsgDownload;
        private FundRank m_funkRank;
        private DataTable m_selectedDT;
        private DataTable m_netValueDT;

        private DataTable m_openTypeRankDT;
        private DataTable m_closeTypeRankDT;
        private DataTable m_currencyTypeRankDT;

        private bool m_bFirstClickSelectedBtn = true;
        private bool m_bFirstClickRankBtn = true;
        //private bool m_bExtractHtmlCompleted = false;

        //窗体移动
        private bool m_moveFlag = false;
        private int x = 0;
        private int y = 0;

        private System.Windows.Forms.Panel m_fundRankingPanel;
        private System.Windows.Forms.ComboBox m_rankTypeComboBox;
        private System.Windows.Forms.DataGridView m_baseMsgDataGridView;
        private System.Windows.Forms.DataGridView m_dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_chart1;
        private System.Windows.Forms.Button m_updateBtn;
        private System.Windows.Forms.Panel m_updatePanel;
        private System.Windows.Forms.RadioButton m_updateNameRadioButton;
        private System.Windows.Forms.RadioButton m_codeRadioButton;
        private System.Windows.Forms.Button m_confirmUpdateBtn;
        private System.Windows.Forms.TextBox m_updateTextBox;
        private System.Windows.Forms.Label m_updateLabel;
        private System.Windows.Forms.DataGridView m_selectDataGridView;
        private System.Windows.Forms.Panel m_progressPanel;
        private System.Windows.Forms.Label m_tipLabel;
        private System.Windows.Forms.ProgressBar m_progressBar;
        private System.Windows.Forms.Label m_startLabel;
        private System.Windows.Forms.DateTimePicker m_startDateTimePicker;
        private System.Windows.Forms.Label m_endLabel;
        private System.Windows.Forms.DateTimePicker m_endDateTimePicker;
        private System.Windows.Forms.DataGridView m_rankDataGridView;
    }
}

