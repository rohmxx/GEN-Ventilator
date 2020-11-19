namespace Balancing_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_logger = new System.Windows.Forms.Timer(this.components);
            this.label_tanggal = new System.Windows.Forms.Label();
            this.label_jam = new System.Windows.Forms.Label();
            this.timer_Plotting = new System.Windows.Forms.Timer(this.components);
            this.waveformGraph_Current = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.waveformGraph_Temperature = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot3 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis3 = new NationalInstruments.UI.XAxis();
            this.yAxis3 = new NationalInstruments.UI.YAxis();
            this.PIP_in = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RRr_in = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PEEP_in = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RR_in = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.VTe_in = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.waveformGraph_Voltage = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.label15 = new System.Windows.Forms.Label();
            this.led_blue = new NationalInstruments.UI.WindowsForms.Led();
            this.led_green = new NationalInstruments.UI.WindowsForms.Led();
            this.led_yellow = new NationalInstruments.UI.WindowsForms.Led();
            this.button_SettingParam = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RunStopButton = new Guna.UI2.WinForms.Guna2Button();
            this.TuningSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_Current)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIP_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRr_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEEP_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RR_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VTe_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_Voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_yellow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "GEN-I Ventilator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(999, 572);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 26);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Connect_btn
            // 
            this.Connect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Connect_btn.Location = new System.Drawing.Point(1093, 610);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(82, 57);
            this.Connect_btn.TabIndex = 55;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Disconnect_btn
            // 
            this.Disconnect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Disconnect_btn.Location = new System.Drawing.Point(999, 610);
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.Size = new System.Drawing.Size(87, 57);
            this.Disconnect_btn.TabIndex = 56;
            this.Disconnect_btn.Text = "Disconnect";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(832, 557);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 15);
            this.label25.TabIndex = 61;
            this.label25.Text = "ari@garda-energi.com";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_logger
            // 
            this.timer_logger.Enabled = true;
            this.timer_logger.Interval = 500;
            this.timer_logger.Tick += new System.EventHandler(this.timer_logger_Tick);
            // 
            // label_tanggal
            // 
            this.label_tanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tanggal.AutoSize = true;
            this.label_tanggal.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_tanggal.Location = new System.Drawing.Point(42, 86);
            this.label_tanggal.Name = "label_tanggal";
            this.label_tanggal.Size = new System.Drawing.Size(89, 19);
            this.label_tanggal.TabIndex = 155;
            this.label_tanggal.Text = "2020-03-03";
            this.label_tanggal.Click += new System.EventHandler(this.label_tanggal_Click);
            // 
            // label_jam
            // 
            this.label_jam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_jam.AutoSize = true;
            this.label_jam.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_jam.Location = new System.Drawing.Point(42, 109);
            this.label_jam.Name = "label_jam";
            this.label_jam.Size = new System.Drawing.Size(73, 19);
            this.label_jam.TabIndex = 156;
            this.label_jam.Text = "00:00:00";
            // 
            // timer_Plotting
            // 
            this.timer_Plotting.Enabled = true;
            this.timer_Plotting.Interval = 1000;
            this.timer_Plotting.Tick += new System.EventHandler(this.timer_Plotting_Tick);
            // 
            // waveformGraph_Current
            // 
            this.waveformGraph_Current.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waveformGraph_Current.Border = NationalInstruments.UI.Border.None;
            this.waveformGraph_Current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.waveformGraph_Current.Location = new System.Drawing.Point(14, 315);
            this.waveformGraph_Current.Name = "waveformGraph_Current";
            this.waveformGraph_Current.PlotAreaBorder = NationalInstruments.UI.Border.None;
            this.waveformGraph_Current.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph_Current.Size = new System.Drawing.Size(947, 162);
            this.waveformGraph_Current.TabIndex = 158;
            this.waveformGraph_Current.UseColorGenerator = true;
            this.waveformGraph_Current.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph_Current.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.waveformPlot2.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.BaseLineVisible = true;
            this.xAxis2.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis2.Range = new NationalInstruments.UI.Range(0D, 20000D);
            // 
            // yAxis2
            // 
            this.yAxis2.BaseLineVisible = true;
            this.yAxis2.CaptionFont = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis2.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis2.Range = new NationalInstruments.UI.Range(-90D, 90D);
            // 
            // waveformGraph_Temperature
            // 
            this.waveformGraph_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waveformGraph_Temperature.Border = NationalInstruments.UI.Border.None;
            this.waveformGraph_Temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.waveformGraph_Temperature.Location = new System.Drawing.Point(14, 483);
            this.waveformGraph_Temperature.Name = "waveformGraph_Temperature";
            this.waveformGraph_Temperature.PlotAreaBorder = NationalInstruments.UI.Border.None;
            this.waveformGraph_Temperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot3});
            this.waveformGraph_Temperature.Size = new System.Drawing.Size(947, 162);
            this.waveformGraph_Temperature.TabIndex = 159;
            this.waveformGraph_Temperature.UseColorGenerator = true;
            this.waveformGraph_Temperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis3});
            this.waveformGraph_Temperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis3});
            // 
            // waveformPlot3
            // 
            this.waveformPlot3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.waveformPlot3.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot3.XAxis = this.xAxis3;
            this.waveformPlot3.YAxis = this.yAxis3;
            // 
            // xAxis3
            // 
            this.xAxis3.BaseLineVisible = true;
            this.xAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis3.Range = new NationalInstruments.UI.Range(0D, 20000D);
            // 
            // yAxis3
            // 
            this.yAxis3.BaseLineVisible = true;
            this.yAxis3.CaptionFont = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis3.Range = new NationalInstruments.UI.Range(0D, 600D);
            this.yAxis3.Tag = "";
            // 
            // PIP_in
            // 
            this.PIP_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIP_in.BackColor = System.Drawing.Color.Black;
            this.PIP_in.CoercionIntervalBase = 2D;
            this.PIP_in.Font = new System.Drawing.Font("Modern No. 20", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIP_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PIP_in.Location = new System.Drawing.Point(999, 157);
            this.PIP_in.Name = "PIP_in";
            this.PIP_in.Range = new NationalInstruments.UI.Range(15D, 40D);
            this.PIP_in.Size = new System.Drawing.Size(176, 51);
            this.PIP_in.TabIndex = 160;
            this.PIP_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PIP_in.Value = 30D;
            this.PIP_in.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.PIP_in_AfterChangeValue);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(994, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 161;
            this.label2.Text = "PIP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1053, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 162;
            this.label3.Text = "( cmH2O )";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(1101, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 165;
            this.label4.Text = "( Tex/Tin )";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(994, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 164;
            this.label5.Text = "RR ratio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RRr_in
            // 
            this.RRr_in.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RRr_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RRr_in.BackColor = System.Drawing.Color.Black;
            this.RRr_in.CoercionIntervalBase = 2D;
            this.RRr_in.Font = new System.Drawing.Font("Modern No. 20", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRr_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RRr_in.Location = new System.Drawing.Point(999, 337);
            this.RRr_in.Name = "RRr_in";
            this.RRr_in.Range = new NationalInstruments.UI.Range(1D, 4D);
            this.RRr_in.Size = new System.Drawing.Size(176, 51);
            this.RRr_in.TabIndex = 163;
            this.RRr_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RRr_in.Value = 2D;
            this.RRr_in.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.RRr_in_AfterChangeValue);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(1076, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 168;
            this.label6.Text = "( cmH2O )";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(994, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 167;
            this.label7.Text = "PEEP";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PEEP_in
            // 
            this.PEEP_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PEEP_in.BackColor = System.Drawing.Color.Black;
            this.PEEP_in.CoercionIntervalBase = 2D;
            this.PEEP_in.Font = new System.Drawing.Font("Modern No. 20", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEEP_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PEEP_in.Location = new System.Drawing.Point(999, 247);
            this.PEEP_in.Name = "PEEP_in";
            this.PEEP_in.Range = new NationalInstruments.UI.Range(5D, 15D);
            this.PEEP_in.Size = new System.Drawing.Size(176, 51);
            this.PEEP_in.TabIndex = 166;
            this.PEEP_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PEEP_in.Value = 10D;
            this.PEEP_in.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.PEEP_in_AfterChangeValue);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(1045, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 171;
            this.label8.Text = "/min";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(994, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 21);
            this.label9.TabIndex = 170;
            this.label9.Text = "RR";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RR_in
            // 
            this.RR_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RR_in.BackColor = System.Drawing.Color.Black;
            this.RR_in.CoercionIntervalBase = 2D;
            this.RR_in.Font = new System.Drawing.Font("Modern No. 20", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RR_in.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.RR_in.Location = new System.Drawing.Point(999, 427);
            this.RR_in.Name = "RR_in";
            this.RR_in.Range = new NationalInstruments.UI.Range(6D, 40D);
            this.RR_in.Size = new System.Drawing.Size(176, 51);
            this.RR_in.TabIndex = 169;
            this.RR_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RR_in.Value = 20D;
            this.RR_in.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.RR_in_AfterChangeValue);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(1055, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 174;
            this.label10.Text = "( mL )";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(994, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 173;
            this.label11.Text = "VTe";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // VTe_in
            // 
            this.VTe_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VTe_in.BackColor = System.Drawing.Color.Black;
            this.VTe_in.CoercionIntervalBase = 2D;
            this.VTe_in.Font = new System.Drawing.Font("Modern No. 20", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTe_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VTe_in.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.VTe_in.Location = new System.Drawing.Point(999, 515);
            this.VTe_in.Name = "VTe_in";
            this.VTe_in.Range = new NationalInstruments.UI.Range(200D, 800D);
            this.VTe_in.Size = new System.Drawing.Size(176, 51);
            this.VTe_in.TabIndex = 172;
            this.VTe_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VTe_in.Value = 300D;
            this.VTe_in.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.VTe_in_AfterChangeValue);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(44, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 175;
            this.label12.Text = "Volume (mL)";
            // 
            // xAxis1
            // 
            this.xAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis1.Range = new NationalInstruments.UI.Range(0D, 20000D);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(43, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 177;
            this.label14.Text = "Pressure (cmH2O)";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(44, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 176;
            this.label13.Text = "Flow (L/min)";
            // 
            // waveformGraph_Voltage
            // 
            this.waveformGraph_Voltage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waveformGraph_Voltage.Border = NationalInstruments.UI.Border.None;
            this.waveformGraph_Voltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.waveformGraph_Voltage.Location = new System.Drawing.Point(14, 149);
            this.waveformGraph_Voltage.Name = "waveformGraph_Voltage";
            this.waveformGraph_Voltage.PlotAreaBorder = NationalInstruments.UI.Border.None;
            this.waveformGraph_Voltage.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph_Voltage.Size = new System.Drawing.Size(948, 162);
            this.waveformGraph_Voltage.TabIndex = 178;
            this.waveformGraph_Voltage.UseColorGenerator = true;
            this.waveformGraph_Voltage.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis4});
            this.waveformGraph_Voltage.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot1.XAxis = this.xAxis4;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis4
            // 
            this.xAxis4.BaseLineVisible = true;
            this.xAxis4.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis4.Range = new NationalInstruments.UI.Range(0D, 20000D);
            // 
            // yAxis1
            // 
            this.yAxis1.BaseLineVisible = true;
            this.yAxis1.CaptionFont = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis1.Range = new NationalInstruments.UI.Range(-10D, 60D);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(448, 648);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 179;
            this.label15.Text = "Time (mS)";
            // 
            // led_blue
            // 
            this.led_blue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led_blue.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led_blue.Location = new System.Drawing.Point(1121, 15);
            this.led_blue.Name = "led_blue";
            this.led_blue.Size = new System.Drawing.Size(57, 57);
            this.led_blue.TabIndex = 180;
            // 
            // led_green
            // 
            this.led_green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led_green.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led_green.Location = new System.Drawing.Point(1058, 14);
            this.led_green.Name = "led_green";
            this.led_green.OffColor = System.Drawing.Color.CadetBlue;
            this.led_green.OnColor = System.Drawing.Color.Aqua;
            this.led_green.Size = new System.Drawing.Size(57, 57);
            this.led_green.TabIndex = 181;
            this.led_green.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.led_green_StateChanged);
            // 
            // led_yellow
            // 
            this.led_yellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led_yellow.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led_yellow.Location = new System.Drawing.Point(997, 14);
            this.led_yellow.Name = "led_yellow";
            this.led_yellow.OffColor = System.Drawing.Color.Olive;
            this.led_yellow.OnColor = System.Drawing.Color.Yellow;
            this.led_yellow.Size = new System.Drawing.Size(57, 57);
            this.led_yellow.TabIndex = 182;
            // 
            // button_SettingParam
            // 
            this.button_SettingParam.AutoEllipsis = true;
            this.button_SettingParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SettingParam.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SettingParam.Location = new System.Drawing.Point(812, 102);
            this.button_SettingParam.Name = "button_SettingParam";
            this.button_SettingParam.Size = new System.Drawing.Size(142, 35);
            this.button_SettingParam.TabIndex = 183;
            this.button_SettingParam.Text = "Set Parameter";
            this.button_SettingParam.UseVisualStyleBackColor = true;
            this.button_SettingParam.Click += new System.EventHandler(this.button_SettingParam_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(537, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 21);
            this.label16.TabIndex = 188;
            this.label16.Text = "MODE Selection";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(366, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 189;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(366, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 190;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RunStopButton
            // 
            this.RunStopButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.RunStopButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.RunStopButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.RunStopButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.RunStopButton.CheckedState.Parent = this.RunStopButton;
            this.RunStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunStopButton.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.RunStopButton.CustomImages.Parent = this.RunStopButton;
            this.RunStopButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.RunStopButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunStopButton.ForeColor = System.Drawing.Color.Black;
            this.RunStopButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.RunStopButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.RunStopButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.RunStopButton.HoverState.Parent = this.RunStopButton;
            this.RunStopButton.Location = new System.Drawing.Point(812, 29);
            this.RunStopButton.Name = "RunStopButton";
            this.RunStopButton.ShadowDecoration.Parent = this.RunStopButton;
            this.RunStopButton.Size = new System.Drawing.Size(142, 51);
            this.RunStopButton.TabIndex = 193;
            this.RunStopButton.Text = "RUN";
            this.RunStopButton.TextChanged += new System.EventHandler(this.guna2Button1_Click);
            this.RunStopButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // TuningSwitch
            // 
            this.TuningSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TuningSwitch.Animated = true;
            this.TuningSwitch.CheckedState.BorderColor = System.Drawing.Color.White;
            this.TuningSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TuningSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TuningSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TuningSwitch.CheckedState.Parent = this.TuningSwitch;
            this.TuningSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TuningSwitch.Location = new System.Drawing.Point(1132, 85);
            this.TuningSwitch.Name = "TuningSwitch";
            this.TuningSwitch.ShadowDecoration.Parent = this.TuningSwitch;
            this.TuningSwitch.Size = new System.Drawing.Size(43, 20);
            this.TuningSwitch.TabIndex = 194;
            this.TuningSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TuningSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TuningSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TuningSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TuningSwitch.UncheckedState.Parent = this.TuningSwitch;
            this.TuningSwitch.CheckedChanged += new System.EventHandler(this.TuningSwitch_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(993, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 25);
            this.label17.TabIndex = 195;
            this.label17.Text = "TUNING";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton3.Location = new System.Drawing.Point(541, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(178, 21);
            this.radioButton3.TabIndex = 187;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pressure + Assist Control";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton2.Location = new System.Drawing.Point(541, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(223, 21);
            this.radioButton2.TabIndex = 186;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pressure Control (PEEP Thres.)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton1.Location = new System.Drawing.Point(541, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 21);
            this.radioButton1.TabIndex = 185;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pressure Control";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1204, 684);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TuningSwitch);
            this.Controls.Add(this.RunStopButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button_SettingParam);
            this.Controls.Add(this.led_yellow);
            this.Controls.Add(this.led_green);
            this.Controls.Add(this.led_blue);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.waveformGraph_Voltage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VTe_in);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RR_in);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PEEP_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RRr_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PIP_in);
            this.Controls.Add(this.waveformGraph_Temperature);
            this.Controls.Add(this.waveformGraph_Current);
            this.Controls.Add(this.label_jam);
            this.Controls.Add(this.label_tanggal);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Disconnect_btn);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1220, 723);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEN-I Medical Ventilator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_Current)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIP_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRr_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEEP_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RR_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VTe_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_Voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_yellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button Disconnect_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer_logger;
        private System.Windows.Forms.Label label_tanggal;
        private System.Windows.Forms.Label label_jam;
        private System.Windows.Forms.Timer timer_Plotting;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph_Current;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph_Temperature;
        private NationalInstruments.UI.WaveformPlot waveformPlot3;
        private NationalInstruments.UI.XAxis xAxis3;
        private NationalInstruments.UI.YAxis yAxis3;
        private NationalInstruments.UI.WindowsForms.NumericEdit PIP_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private NationalInstruments.UI.WindowsForms.NumericEdit RRr_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private NationalInstruments.UI.WindowsForms.NumericEdit PEEP_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private NationalInstruments.UI.WindowsForms.NumericEdit RR_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private NationalInstruments.UI.WindowsForms.NumericEdit VTe_in;
        private System.Windows.Forms.Label label12;
        private NationalInstruments.UI.XAxis xAxis1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph_Voltage;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Label label15;
        private NationalInstruments.UI.WindowsForms.Led led_blue;
        private NationalInstruments.UI.WindowsForms.Led led_green;
        private NationalInstruments.UI.WindowsForms.Led led_yellow;
        private System.Windows.Forms.Button button_SettingParam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2Button RunStopButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TuningSwitch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

