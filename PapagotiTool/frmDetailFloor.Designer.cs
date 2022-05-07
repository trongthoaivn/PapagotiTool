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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ggCurrent = new CodeArtEng.Gauge.CircularGauge();
            this.ggVoltage = new CodeArtEng.Gauge.CircularGauge();
            this.ggHumidity = new CodeArtEng.Gauge.CircularGauge();
            this.ggFrequency = new CodeArtEng.Gauge.CircularGauge();
            this.ggPower = new CodeArtEng.Gauge.CircularGauge();
            this.ggEnergy = new CodeArtEng.Gauge.CircularGauge();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.ggCurrent);
            this.panel1.Controls.Add(this.ggVoltage);
            this.panel1.Controls.Add(this.ggHumidity);
            this.panel1.Controls.Add(this.ggFrequency);
            this.panel1.Controls.Add(this.ggPower);
            this.panel1.Controls.Add(this.ggEnergy);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 656);
            this.panel1.TabIndex = 1;
            // 
            // ggCurrent
            // 
            this.ggCurrent.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggCurrent.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggCurrent.ErrorLimit = 1D;
            this.ggCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggCurrent.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggCurrent.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggCurrent.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggCurrent.Location = new System.Drawing.Point(51, 60);
            this.ggCurrent.Maximum = 0.1D;
            this.ggCurrent.Minimum = 0.001D;
            this.ggCurrent.Name = "ggCurrent";
            this.ggCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggCurrent.ScaleFactor = 1D;
            this.ggCurrent.Size = new System.Drawing.Size(201, 129);
            this.ggCurrent.TabIndex = 34;
            this.ggCurrent.Title = "Energy";
            this.ggCurrent.Unit = "(A)";
            this.ggCurrent.UserDefinedColors.Base = themeColors1;
            themeColors2.PointerColor = System.Drawing.Color.Red;
            this.ggCurrent.UserDefinedColors.Error = themeColors2;
            themeColors3.PointerColor = System.Drawing.Color.Orange;
            this.ggCurrent.UserDefinedColors.Warning = themeColors3;
            this.ggCurrent.Value = 0D;
            this.ggCurrent.WarningLimit = 0.05D;
            // 
            // ggVoltage
            // 
            this.ggVoltage.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggVoltage.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggVoltage.ErrorLimit = 1D;
            this.ggVoltage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggVoltage.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggVoltage.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggVoltage.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggVoltage.Location = new System.Drawing.Point(1086, 60);
            this.ggVoltage.Maximum = 0.1D;
            this.ggVoltage.Minimum = 0.001D;
            this.ggVoltage.Name = "ggVoltage";
            this.ggVoltage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggVoltage.ScaleFactor = 1D;
            this.ggVoltage.Size = new System.Drawing.Size(201, 129);
            this.ggVoltage.TabIndex = 33;
            this.ggVoltage.Title = "Voltage";
            this.ggVoltage.Unit = "(V)";
            this.ggVoltage.Value = 0D;
            this.ggVoltage.WarningLimit = 0.05D;
            // 
            // ggHumidity
            // 
            this.ggHumidity.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggHumidity.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggHumidity.ErrorLimit = 1D;
            this.ggHumidity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggHumidity.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggHumidity.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggHumidity.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggHumidity.Location = new System.Drawing.Point(879, 60);
            this.ggHumidity.Maximum = 0.1D;
            this.ggHumidity.Minimum = 0.001D;
            this.ggHumidity.Name = "ggHumidity";
            this.ggHumidity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggHumidity.ScaleFactor = 1D;
            this.ggHumidity.Size = new System.Drawing.Size(201, 129);
            this.ggHumidity.TabIndex = 32;
            this.ggHumidity.Title = "Humidity";
            this.ggHumidity.Unit = "(%)";
            this.ggHumidity.Value = 0D;
            this.ggHumidity.WarningLimit = 0.05D;
            // 
            // ggFrequency
            // 
            this.ggFrequency.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggFrequency.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggFrequency.ErrorLimit = 1D;
            this.ggFrequency.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggFrequency.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggFrequency.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggFrequency.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggFrequency.Location = new System.Drawing.Point(672, 60);
            this.ggFrequency.Maximum = 0.1D;
            this.ggFrequency.Minimum = 0.001D;
            this.ggFrequency.Name = "ggFrequency";
            this.ggFrequency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggFrequency.ScaleFactor = 1D;
            this.ggFrequency.Size = new System.Drawing.Size(201, 129);
            this.ggFrequency.TabIndex = 31;
            this.ggFrequency.Title = "Frequency";
            this.ggFrequency.Unit = "(Hz)";
            this.ggFrequency.Value = 0D;
            this.ggFrequency.WarningLimit = 0.05D;
            // 
            // ggPower
            // 
            this.ggPower.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggPower.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggPower.ErrorLimit = 1D;
            this.ggPower.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPower.FontTitle = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPower.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggPower.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggPower.Location = new System.Drawing.Point(465, 60);
            this.ggPower.Maximum = 0.1D;
            this.ggPower.Minimum = 0.001D;
            this.ggPower.Name = "ggPower";
            this.ggPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggPower.ScaleFactor = 1D;
            this.ggPower.Size = new System.Drawing.Size(201, 129);
            this.ggPower.TabIndex = 30;
            this.ggPower.Title = "Power";
            this.ggPower.Unit = "(W)";
            this.ggPower.Value = 0D;
            this.ggPower.WarningLimit = 0.05D;
            // 
            // ggEnergy
            // 
            this.ggEnergy.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ggEnergy.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.ggEnergy.ErrorLimit = 1D;
            this.ggEnergy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggEnergy.FontTitle = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggEnergy.FontUnitLabel = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggEnergy.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.ggEnergy.Location = new System.Drawing.Point(258, 60);
            this.ggEnergy.Maximum = 0.1D;
            this.ggEnergy.Minimum = 0.001D;
            this.ggEnergy.Name = "ggEnergy";
            this.ggEnergy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ggEnergy.ScaleFactor = 1D;
            this.ggEnergy.Size = new System.Drawing.Size(201, 129);
            this.ggEnergy.TabIndex = 29;
            this.ggEnergy.Title = "Energy";
            this.ggEnergy.Unit = "(kWh)";
            this.ggEnergy.Value = 0D;
            this.ggEnergy.WarningLimit = 0.05D;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(1086, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(236, 31);
            this.txtTime.TabIndex = 3;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel panel1;
        private CodeArtEng.Gauge.CircularGauge ggEnergy;
        private CodeArtEng.Gauge.CircularGauge ggPower;
        private CodeArtEng.Gauge.CircularGauge ggFrequency;
        private CodeArtEng.Gauge.CircularGauge ggHumidity;
        private CodeArtEng.Gauge.CircularGauge ggVoltage;
        private CodeArtEng.Gauge.CircularGauge ggCurrent;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timer1;
    }
}