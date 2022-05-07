using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using MetroSet_UI.Forms;

namespace PapagotiTool
{
    public partial class frmDetailFloor : MetroSetForm
    {
        public frmDetailFloor(String nameFloor , IFirebaseConfig config)
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

        private void theardRequest()
        {
            while (active)
            {
                Thread.Sleep(3000);
                _ = requestDataFirebaseAsync();

            }
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
                    if (floor != null)
                    {
                        Invoke(new Action(() =>
                        {
                            Console.WriteLine("+1");
                            ggCurrent.Value = (double)floor.Current;
                            ggEnergy.Value = (double)floor.Energy;
                            ggFrequency.Value = (double)floor.Frequency;
                            ggHumidity.Value = (double)floor.Humidity;
                            ggPower.Value = (double)floor.Power;
                            ggVoltage.Value = (double)floor.Voltage;
                        }));
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Floor error " + ex.Message);
                }

            }

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
            
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new MethodInvoker(delegate ()
            {
                txtTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            }));
        }
    }
}
