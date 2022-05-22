using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using LiveChartsCore.SkiaSharpView;
using MetroSet_UI.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PapagotiTool
{
    public partial class frmDetailFloor : MetroSetForm
    {
        public frmDetailFloor(String nameFloor , IFirebaseConfig config )
        {
        

            InitializeComponent();

            this.Text ="["+ nameFloor + "] Detail";
            this.config = config;
            this.nameFloor = nameFloor;
            
            _ = requestDataFirebaseAsync();

            this.thread = new Thread(() => theardRequest());
            this.thread.Start();
        }

        private IFirebaseConfig config;
        private String nameFloor;
        private Thread thread;
        private bool active = true;
        private System.Timers.Timer timer;
        private int mode = 1;
        private ObservableCollection<double> ObsList = new ObservableCollection<double>();

        private void addPoint(Model.FloorFb floor)
        {
            ObsList.Add(0);
            if(ObsList.Count > 20)
            {
                ObsList.RemoveAt(0);
            }
            if(mode == 1)
                ObsList.Add((double)floor.Current);
            else if( mode == 2)
                ObsList.Add((double)floor.Energy);
            else if(mode == 3)
                ObsList.Add((double)floor.Voltage);
        }

        private void theardRequest()
        {
            while (active)
            {
                Thread.Sleep(Properties.Settings.Default.timeRefreshData);
                _ = requestDataFirebaseAsync();

            }
        }

        private void setValueUi(Model.FloorFb floor)
        {
            Invoke(new Action(() =>
            {
                ggCurrent.Value = (double)floor.Current;
                ggEnergy.Value = (double)floor.Energy;
                ggFrequency.Value = (double)floor.Frequency;
                ggHumidity.Value = (double)floor.Humidity;
                ggPower.Value = (double)floor.Power;
                ggVoltage.Value = (double)floor.Voltage;
                ggTemperature.Value = (double)floor.Temperature;
                ggPF.Value = (double)floor.PF;
                addPoint(floor);
            }));
        }

        private async Task requestDataFirebaseAsync()
        {

            IFirebaseClient client = new FirebaseClient(config);
            if (client != null)
            {
                try
                {
                    FirebaseResponse response = await client.GetAsync(nameFloor);
                    Model.FloorFb floor = response.ResultAs<Model.FloorFb>();
                    if (floor != null )
                    {
                        setValueUi(floor);
                    }
                }
                catch (Exception ex)
                {
                    active = false;
                    thread.Abort();
                    MessageBox.Show("Floor error :" + ex.Message);
                }

            }

        }

        private void settingGauge()
        {
            ggCurrent.Maximum = Properties.Settings.Default.CurrentMax;
            ggCurrent.Minimum = Properties.Settings.Default.CurrentMin;
            ggCurrent.WarningLimit = Properties.Settings.Default.CurrentAlert;
            ggEnergy.Maximum = Properties.Settings.Default.EnergyMax;
            ggEnergy.Minimum = Properties.Settings.Default.EnergyMin;
            ggEnergy.WarningLimit = Properties.Settings.Default.EnergyAlert;
            ggVoltage.Maximum = Properties.Settings.Default.VoltageMax;
            ggVoltage.Minimum = Properties.Settings.Default.VoltageMin;
            ggVoltage.WarningLimit = Properties.Settings.Default.VoltageAlert;
            ggHumidity.Maximum = Properties.Settings.Default.HumidityMax;
            ggHumidity.Minimum = Properties.Settings.Default.HumidityMin;
            ggHumidity.WarningLimit = Properties.Settings.Default.HumidityAlert;
            ggPower.Minimum = Properties.Settings.Default.PowerMin;
            ggPower.Maximum = Properties.Settings.Default.PowerMax;
            ggPower.WarningLimit = Properties.Settings.Default.PowerAlert;
            ggFrequency.Maximum = Properties.Settings.Default.FrequencyMax;
            ggFrequency.Minimum = Properties.Settings.Default.FrequencyMin;
            ggFrequency.WarningLimit = Properties.Settings.Default.FrequencyAlert;
            ggTemperature.Maximum = Properties.Settings.Default.TemperatureMax;
            ggTemperature.Minimum = Properties.Settings.Default.TemperatureMin;
            ggTemperature.WarningLimit = Properties.Settings.Default.TemperatureAlert;
            ggPF.Maximum = Properties.Settings.Default.PFMax;
            ggPF.Minimum = Properties.Settings.Default.PFMin;
            ggPF.WarningLimit = Properties.Settings.Default.PFAlert;
        }

        private void frmDetailFloor_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;
            thread.Abort();
            timer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void frmDetailFloor_Load(object sender, EventArgs e)
        {
            this.timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            label1.Text = "Chart Name : Current";
            var line = new LiveChartsCore.ISeries[]
            {
               new LineSeries<double>()
               {
                   Values = ObsList
               }
            };
           cartesianChart1.Series = line;
            settingGauge();
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new MethodInvoker(delegate ()
            {
                txtTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            }));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ObsList.Clear();
            label1.Text = "Chart Name : Current";
            mode = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ObsList.Clear();
            label1.Text = "Chart Name : Energy";
            mode = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ObsList.Clear();
            label1.Text = "Chart Name : Voltage";
            mode = 3;
        }

        private void ggCurrent_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Current : " + control.Value + " (A)");
            msg.Show();
        }

        private void ggEnergy_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Energy : " + control.Value + " (kWh)");
            msg.Show();
        }

        private void ggVoltage_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Voltage : " + control.Value + " (V)");
            msg.Show();
        }

        private void ggHumidity_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Humidity : " + control.Value + " (%)");
            msg.Show();
        }

        private void ggPower_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Power : " + control.Value + " (W)");
            msg.Show();
        }

        private void ggFrequency_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Frequency : " + control.Value + " (Hz)");
            msg.Show();
        }

        private void ggTemperature_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning Temperature : " + control.Value + " (° C)");
            msg.Show();
        }

        private void ggPF_WarningLimitReached(object sender, EventArgs e)
        {
            var control = (CodeArtEng.Gauge.CircularGauge)sender;
            var msg = new ToastContentBuilder().AddText("Warning PF : " + control.Value + " ()");
            msg.Show();
        }
    }
}
