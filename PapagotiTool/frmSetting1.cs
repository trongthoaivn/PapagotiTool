using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapagotiTool
{
    public partial class frmSetting1 : Form
    {
        public frmSetting1()
        {
            InitializeComponent();
        }

        private void frmSetting1_Load(object sender, EventArgs e)
        {
            txtTimeRefresh.Text = Properties.Settings.Default.timeRefreshData.ToString();
            txtPoint.Text = Properties.Settings.Default.pointChart.ToString();
            txtCurrentMin.Text = Properties.Settings.Default.CurrentMin.ToString();
            txtCurrentMax.Text = Properties.Settings.Default.CurrentMax.ToString();
            txtCurrentAlert.Text = Properties.Settings.Default.CurrentAlert.ToString();
            txtEnergyAlert.Text = Properties.Settings.Default.EnergyAlert.ToString();
            txtEnergyMax.Text = Properties.Settings.Default.EnergyMax.ToString();
            txtEnergyMin.Text = Properties.Settings.Default.EnergyMin.ToString();
            txtFrequencyAlert.Text = Properties.Settings.Default.FrequencyAlert.ToString();
            txtFrequencyMax.Text = Properties.Settings.Default.FrequencyMax.ToString();
            txtFrequencyMin.Text = Properties.Settings.Default.FrequencyMin.ToString();
            txtHumidityAlert.Text = Properties.Settings.Default.HumidityAlert.ToString();
            txtHumidityMax.Text = Properties.Settings.Default.HumidityMax.ToString();
            txtHumidityMin.Text = Properties.Settings.Default.HumidityMin.ToString();
            txtPFAlert.Text = Properties.Settings.Default.PFAlert.ToString();
            txtPFMax.Text = Properties.Settings.Default.PFMax.ToString();
            txtPFMin.Text = Properties.Settings.Default.PFMin.ToString();
            txtPowerAlert.Text = Properties.Settings.Default.PowerAlert.ToString();
            txtPowerMax.Text = Properties.Settings.Default.PowerMax.ToString();
            txtPowerMin.Text = Properties.Settings.Default.PowerMin.ToString();
            txtTemperatureAlert.Text = Properties.Settings.Default.TemperatureAlert.ToString();
            txtTemperatureMax.Text = Properties.Settings.Default.TemperatureMax.ToString();
            txtTemperatureMin.Text = Properties.Settings.Default.TemperatureMin.ToString();
            txtVoltageAlert.Text = Properties.Settings.Default.VoltageAlert.ToString();
            txtVoltageMax.Text = Properties.Settings.Default.VoltageMax.ToString();
            txtVoltageMin.Text = Properties.Settings.Default.VoltageMin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool group1 = groupBox1.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text));
            bool group2 = groupBox2.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text));
            if (group1 || group2)
            {
                MessageBox.Show("All field is required!");
            }
            else
            {
                Properties.Settings.Default.timeRefreshData = int.Parse(txtTimeRefresh.Text);
                Properties.Settings.Default.pointChart = int.Parse(txtPoint.Text);
                Properties.Settings.Default.CurrentMax = float.Parse(txtCurrentMax.Text);
                Properties.Settings.Default.CurrentMin = float.Parse(txtCurrentMin.Text);
                Properties.Settings.Default.CurrentAlert = float.Parse(txtCurrentAlert.Text);
                Properties.Settings.Default.EnergyAlert = float.Parse(txtEnergyAlert.Text);
                Properties.Settings.Default.EnergyMax = float.Parse(txtEnergyMax.Text);
                Properties.Settings.Default.EnergyMin = float.Parse(txtEnergyMin.Text);
                Properties.Settings.Default.FrequencyAlert = float.Parse(txtFrequencyAlert.Text);
                Properties.Settings.Default.FrequencyMax = float.Parse(txtFrequencyMax.Text);
                Properties.Settings.Default.FrequencyMin = float.Parse(txtFrequencyMin.Text);
                Properties.Settings.Default.HumidityAlert = float.Parse(txtHumidityAlert.Text);
                Properties.Settings.Default.HumidityMax = float.Parse(txtHumidityMax.Text);
                Properties.Settings.Default.HumidityMin = float.Parse(txtHumidityMin.Text);
                Properties.Settings.Default.PFAlert = float.Parse(txtPFAlert.Text);
                Properties.Settings.Default.PFMax = float.Parse(txtPFMax.Text);
                Properties.Settings.Default.PFMin = float.Parse(txtPFMin.Text);
                Properties.Settings.Default.PowerAlert = float.Parse(txtPowerAlert.Text);
                Properties.Settings.Default.PowerMax = float.Parse(txtPowerMax.Text);
                Properties.Settings.Default.PowerMin = float.Parse(txtPowerMin.Text);
                Properties.Settings.Default.TemperatureAlert = float.Parse(txtTemperatureAlert.Text);
                Properties.Settings.Default.TemperatureMax = float.Parse(txtTemperatureMax.Text);
                Properties.Settings.Default.TemperatureMin = float.Parse(txtTemperatureMin.Text);
                Properties.Settings.Default.VoltageAlert = float.Parse(txtVoltageAlert.Text);
                Properties.Settings.Default.VoltageMax = float.Parse(txtVoltageMax.Text);
                Properties.Settings.Default.VoltageMin = float.Parse(txtVoltageMin.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Save complete \n Restart application to apply changes to your privacy settings");
            }
            
        }
    }
}
