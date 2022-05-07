using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace PapagotiTool
{
    public partial class ufrmFloorcs : UserControl
    {
        public ufrmFloorcs( String nameFloor, IFirebaseConfig config, FlowLayoutPanel panel)
        {
            InitializeComponent();
            this.nameFloor = nameFloor;
            this.config = config;
            this.panel = panel;
        

            _=requestDataFirebaseAsync();

            this.thread = new Thread(() => theardRequest());
            this.thread.Start();
           
        }

        private String nameFloor;
        private IFirebaseConfig config;
        private FlowLayoutPanel panel;
        private Thread thread;
        private bool active = true;
        private int countTimeToWriteSQL = 0;
        private Model.dbContext dbContext = new Model.dbContext();

        private void theardRequest()
        {
            while (active)
            {
                Thread.Sleep(3000);
               _ = requestDataFirebaseAsync();

                if(countTimeToWriteSQL == 10)
                {
                        Model.Floor  record = new Model.Floor();
                        record.FloorName = nameFloor;
                        record.Current = Double.Parse(txtCurrent.Text);
                        record.Power = Double.Parse(txtPower.Text);
                        record.Frequency = Double.Parse(txtFrequency.Text);
                        record.Humidity = Double.Parse(txtHumidity.Text);
                        record.Energy = Double.Parse(txtEnergy.Text);
                        record.Voltage = Double.Parse(txtVoltage.Text);
                        record.Time = DateTime.Parse(txtTime.Text);
                        dbContext.Floors.Add(record);
                        dbContext.SaveChanges();
                        countTimeToWriteSQL=0;
                }
               countTimeToWriteSQL++;
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
                            Console.WriteLine("update " +nameFloor);
                            gbFloor.Text = "[ " +nameFloor+ " ]";
                            txtCurrent.Text = floor.Current.ToString();
                            txtEnergy.Text = floor.Energy.ToString();
                            txtFrequency.Text = floor.Frequency.ToString();
                            txtHumidity.Text = floor.Humidity.ToString();
                            txtPower.Text = floor.Power.ToString();
                            txtVoltage.Text = floor.Voltage.ToString();
                            txtTime.Text = floor.Time.ToString();
                        }));
                    }
                    else
                    {
                        active = false;
                        this.thread.Abort();
                        panel.Controls.Remove(this);
                        MessageBox.Show(nameFloor + " is not exist!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Floor error "+ ex.Message);
                }
                
            }

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmDetailFloor frmDetailFloor = new frmDetailFloor(nameFloor,config);
            frmDetailFloor.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            active = false;
            this.thread.Abort();
            panel.Controls.Remove(this);
        }
    }
}
