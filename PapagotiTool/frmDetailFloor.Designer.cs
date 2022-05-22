namespace PapagotiTool
{
    partial class frmDetailFloor
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
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ggPF = new CodeArtEng.Gauge.CircularGauge();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ggTemperature = new CodeArtEng.Gauge.CircularGauge();
            this.ggCurrent = new CodeArtEng.Gauge.CircularGauge();
            this.ggVoltage = new CodeArtEng.Gauge.CircularGauge();
            this.ggHumidity = new CodeArtEng.Gauge.CircularGauge();
            this.ggFrequency = new CodeArtEng.Gauge.CircularGauge();
            this.ggPower = new CodeArtEng.Gauge.CircularGauge();
            this.ggEnergy = new CodeArtEng.Gauge.CircularGauge();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1223, 34);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(1017, 222);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(236, 31);
            this.txtTime.TabIndex = 3;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(14, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 656);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Chart Name : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.ggPF);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ggTemperature);
            this.panel2.Controls.Add(this.ggCurrent);
            this.panel2.Controls.Add(this.ggVoltage);
            this.panel2.Controls.Add(this.ggHumidity);
            this.panel2.Controls.Add(this.ggFrequency);
            this.panel2.Controls.Add(this.ggPower);
            this.panel2.Controls.Add(this.ggEnergy);
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 198);
            this.panel2.TabIndex = 36;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PapagotiTool.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(434, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 28);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ggPF
            // 
            this.ggPF.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggPF.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggPF.ErrorLimit = 1000D;
            this.ggPF.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPF.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPF.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPF.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggPF.Location = new System.Drawing.Point(1122, 28);
            this.ggPF.Maximum = 100D;
            this.ggPF.Name = "ggPF";
            this.ggPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggPF.ScaleFactor = 1D;
            this.ggPF.Size = new System.Drawing.Size(197, 129);
            this.ggPF.TabIndex = 45;
            this.ggPF.Title = "PF";
            this.ggPF.Unit = "()";
            this.ggPF.UserDefinedColors.Base = themeColors1;
            themeColors2.PointerColor = System.Drawing.Color.Red;
            this.ggPF.UserDefinedColors.Error = themeColors2;
            themeColors3.PointerColor = System.Drawing.Color.Orange;
            this.ggPF.UserDefinedColors.Warning = themeColors3;
            this.ggPF.Value = 0D;
            this.ggPF.WarningLimit = 50D;
            this.ggPF.WarningLimitReached += new System.EventHandler(this.ggPF_WarningLimitReached);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PapagotiTool.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(270, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 28);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PapagotiTool.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(100, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 28);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ggTemperature
            // 
            this.ggTemperature.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggTemperature.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggTemperature.ErrorLimit = 1000D;
            this.ggTemperature.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggTemperature.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggTemperature.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggTemperature.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggTemperature.Location = new System.Drawing.Point(960, 28);
            this.ggTemperature.Maximum = 100D;
            this.ggTemperature.Name = "ggTemperature";
            this.ggTemperature.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggTemperature.ScaleFactor = 1D;
            this.ggTemperature.Size = new System.Drawing.Size(195, 129);
            this.ggTemperature.TabIndex = 42;
            this.ggTemperature.Title = "Temperature";
            this.ggTemperature.Unit = "(° C)";
            this.ggTemperature.Value = 0D;
            this.ggTemperature.WarningLimit = 50D;
            this.ggTemperature.WarningLimitReached += new System.EventHandler(this.ggTemperature_WarningLimitReached);
            // 
            // ggCurrent
            // 
            this.ggCurrent.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggCurrent.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggCurrent.ErrorLimit = 1000D;
            this.ggCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggCurrent.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggCurrent.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggCurrent.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggCurrent.Location = new System.Drawing.Point(-15, 28);
            this.ggCurrent.Maximum = 1D;
            this.ggCurrent.Name = "ggCurrent";
            this.ggCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggCurrent.ScaleFactor = 1D;
            this.ggCurrent.Size = new System.Drawing.Size(201, 129);
            this.ggCurrent.TabIndex = 41;
            this.ggCurrent.Title = "Current";
            this.ggCurrent.Unit = "(A)";
            this.ggCurrent.Value = 0D;
            this.ggCurrent.WarningLimit = 0.5D;
            this.ggCurrent.WarningLimitReached += new System.EventHandler(this.ggCurrent_WarningLimitReached);
            // 
            // ggVoltage
            // 
            this.ggVoltage.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggVoltage.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggVoltage.ErrorLimit = 1000D;
            this.ggVoltage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggVoltage.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggVoltage.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggVoltage.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggVoltage.Location = new System.Drawing.Point(314, 28);
            this.ggVoltage.Maximum = 220D;
            this.ggVoltage.Name = "ggVoltage";
            this.ggVoltage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggVoltage.ScaleFactor = 1D;
            this.ggVoltage.Size = new System.Drawing.Size(192, 129);
            this.ggVoltage.TabIndex = 40;
            this.ggVoltage.Title = "Voltage";
            this.ggVoltage.Unit = "(V)";
            this.ggVoltage.Value = 0D;
            this.ggVoltage.WarningLimit = 200D;
            this.ggVoltage.WarningLimitReached += new System.EventHandler(this.ggVoltage_WarningLimitReached);
            // 
            // ggHumidity
            // 
            this.ggHumidity.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggHumidity.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggHumidity.ErrorLimit = 1000D;
            this.ggHumidity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggHumidity.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggHumidity.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggHumidity.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggHumidity.Location = new System.Drawing.Point(476, 28);
            this.ggHumidity.Maximum = 100D;
            this.ggHumidity.Name = "ggHumidity";
            this.ggHumidity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggHumidity.ScaleFactor = 1D;
            this.ggHumidity.Size = new System.Drawing.Size(194, 129);
            this.ggHumidity.TabIndex = 39;
            this.ggHumidity.Title = "Humidity";
            this.ggHumidity.Unit = "(%)";
            this.ggHumidity.Value = 0D;
            this.ggHumidity.WarningLimit = 100D;
            this.ggHumidity.WarningLimitReached += new System.EventHandler(this.ggHumidity_WarningLimitReached);
            // 
            // ggFrequency
            // 
            this.ggFrequency.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggFrequency.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggFrequency.ErrorLimit = 1000D;
            this.ggFrequency.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggFrequency.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggFrequency.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggFrequency.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggFrequency.Location = new System.Drawing.Point(799, 28);
            this.ggFrequency.Maximum = 100D;
            this.ggFrequency.Name = "ggFrequency";
            this.ggFrequency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggFrequency.ScaleFactor = 1D;
            this.ggFrequency.Size = new System.Drawing.Size(195, 129);
            this.ggFrequency.TabIndex = 38;
            this.ggFrequency.Title = "Frequency";
            this.ggFrequency.Unit = "(Hz)";
            this.ggFrequency.Value = 0D;
            this.ggFrequency.WarningLimit = 100D;
            this.ggFrequency.WarningLimitReached += new System.EventHandler(this.ggFrequency_WarningLimitReached);
            // 
            // ggPower
            // 
            this.ggPower.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggPower.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggPower.ErrorLimit = 1000D;
            this.ggPower.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPower.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPower.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPower.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggPower.Location = new System.Drawing.Point(633, 28);
            this.ggPower.Maximum = 100D;
            this.ggPower.Name = "ggPower";
            this.ggPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggPower.ScaleFactor = 1D;
            this.ggPower.Size = new System.Drawing.Size(201, 129);
            this.ggPower.TabIndex = 37;
            this.ggPower.Title = "Power";
            this.ggPower.Unit = "(W)";
            this.ggPower.Value = 0D;
            this.ggPower.WarningLimit = 100D;
            this.ggPower.WarningLimitReached += new System.EventHandler(this.ggPower_WarningLimitReached);
            // 
            // ggEnergy
            // 
            this.ggEnergy.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggEnergy.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggEnergy.ErrorLimit = 1000D;
            this.ggEnergy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggEnergy.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggEnergy.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggEnergy.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggEnergy.Location = new System.Drawing.Point(149, 28);
            this.ggEnergy.Maximum = 1D;
            this.ggEnergy.Name = "ggEnergy";
            this.ggEnergy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggEnergy.ScaleFactor = 1D;
            this.ggEnergy.Size = new System.Drawing.Size(201, 129);
            this.ggEnergy.TabIndex = 36;
            this.ggEnergy.Title = "Energy";
            this.ggEnergy.Unit = "(kWh)";
            this.ggEnergy.Value = 0D;
            this.ggEnergy.WarningLimit = 0.5D;
            this.ggEnergy.WarningLimitReached += new System.EventHandler(this.ggEnergy_WarningLimitReached);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartesianChart1.Location = new System.Drawing.Point(5, 261);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(5);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1317, 375);
            this.cartesianChart1.TabIndex = 37;
            // 
            // frmDetailFloor
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmDetailFloor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floor Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetailFloor_FormClosing);
            this.Load += new System.EventHandler(this.frmDetailFloor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CodeArtEng.Gauge.CircularGauge ggTemperature;
        private CodeArtEng.Gauge.CircularGauge ggCurrent;
        private CodeArtEng.Gauge.CircularGauge ggVoltage;
        private CodeArtEng.Gauge.CircularGauge ggHumidity;
        private CodeArtEng.Gauge.CircularGauge ggFrequency;
        private CodeArtEng.Gauge.CircularGauge ggPower;
        private CodeArtEng.Gauge.CircularGauge ggEnergy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private CodeArtEng.Gauge.CircularGauge ggPF;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}