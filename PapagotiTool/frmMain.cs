
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MetroSet_UI.Forms;

namespace PapagotiTool
{
    public partial class frmMain : MetroSetForm
    {
        public frmMain(String auth, string path)
        {
            InitializeComponent();
            
            //Lấy dữ liệu đăng nhập Firebase tạo config để đăng nhập
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = auth,
                BasePath = path
            };
            this.config = config;
            txtCount.Text = "0";

            //Tạo client để update dữ liệu
            this.client = new FirebaseClient(config);
            this.thread = new Thread(() => updateValueFirebase());
            thread.Start();
        }

       
        private IFirebaseConfig config;
        private bool active = true;
        private Thread thread;

        //Test
        private IFirebaseClient client;
        private Random random = new Random();
        private int timeRefresh = Properties.Settings.Default.timeRefreshData;

        //Test
        //Tạo dữ liệu random
        public double GetRandomNumber(double minimum, double maximum)
        {
            return Math.Round(( random.NextDouble() * (maximum - minimum) + minimum),3);
        }
        //Test
        //Update dữ liệu Firebase 3s/lần
        //Tạo dữ liệu mô phỏng
        private async void updateValueFirebase()
        {
            while (active)
            {
                Thread.Sleep(timeRefresh);
                Model.FloorFb floor = new Model.FloorFb();
                floor.Current = GetRandomNumber(0, 10);
                floor.Energy = GetRandomNumber(0, 10);
                floor.Power = GetRandomNumber(0, 10);
                floor.Frequency = GetRandomNumber(0, 10);
                floor.Humidity = GetRandomNumber(0, 100);
                floor.Voltage = GetRandomNumber(0, 220);
                floor.Temperature = GetRandomNumber(0, 100);
                floor.PF = GetRandomNumber(1,10);
                FirebaseResponse response = await client.UpdateAsync("floor1", floor);
                var data = response.ResultAs<Model.FloorFb>();
               // Console.WriteLine("Post new value !" );
            }

        }
        //incomplete
        // Kiểm tra internet
        public static bool CheckForInternetConnection()
        {
            return true;
        }
        //Thoát ứng dụng và đóng tiến trình
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //Thêm 1 block Floor vào main panel
        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                var nameFloor = txtNameFloor.Text;
                var ufrmFloor = new ufrmFloorcs(nameFloor, config, lvFloors);
                lvFloors.Controls.Add(ufrmFloor);
                txtCount.Text = lvFloors.Controls.Count.ToString();
                txtNameFloor.Clear();
            }
            else
            {
                MessageBox.Show("Internet is not connected!");
            }

        }
        //Thoát ứng dụng  và đóng tiến trình
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void localDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDatabase  database = new frmLocalDatabase();
            database.ShowDialog();
        }

        private void firebaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://firebase.google.com/");
        }
    }
}
