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
            //nhận config từ frmMain request dữ liệu từ Firebase
            _=requestDataFirebaseAsync();
            //Tiến trình request dữ liệu Firebase 
            this.thread = new Thread(() => theardRequest());
            this.thread.Start();
           
        }

        private String nameFloor;
        private IFirebaseConfig config;
        private FlowLayoutPanel panel;
        private Thread thread;
        private bool active = true;
        private int timeRefresh = Properties.Settings.Default.timeRefreshData; // thời gian refesh dữ liệu giây*1000
        private Model.dbContext dbContext = new Model.dbContext();

        private void theardRequest()
        {
            while (active)
            {
                Thread.Sleep(timeRefresh);
               _ = requestDataFirebaseAsync();
                addNewRecord();
            }
        }

        //tạo dữ liệu mới 
        private void addNewRecord()
        {
            try
            {
                Model.Floor record = new Model.Floor();
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
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }
        // ghi dữ liệu vào Ui
        private void setValueUi(Model.FloorFb floor)
        {
            Invoke(new Action(() =>
            {
               
                gbFloor.Text = "[ " + nameFloor + " ]";
                txtCurrent.Text = floor.Current.ToString();
                txtEnergy.Text = floor.Energy.ToString();
                txtFrequency.Text = floor.Frequency.ToString();
                txtHumidity.Text = floor.Humidity.ToString();
                txtPower.Text = floor.Power.ToString();
                txtVoltage.Text = floor.Voltage.ToString();
                txtTime.Text = floor.Time.ToString();
            }));
        }
        

        private async Task requestDataFirebaseAsync()
        {
            
            IFirebaseClient client = new FirebaseClient(config);
            if (client != null)
            {
                try
                {
                    //Lấy dữ liệu từ Firebase dựa theo tên block được tạo
                    FirebaseResponse response = await client.GetAsync(nameFloor);
                    Model.FloorFb floor = response.ResultAs<Model.FloorFb>();
                    if (floor != null)
                    {
                        setValueUi(floor);
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
        // Dẫn đến frmDetail
        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmDetailFloor frmDetailFloor = new frmDetailFloor(nameFloor,config);
            frmDetailFloor.Show();
        }

        //xóa block
        private void btnRemove_Click(object sender, EventArgs e)
        {
            active = false;
            this.thread.Abort();
            panel.Controls.Remove(this);
        }
    }
}
