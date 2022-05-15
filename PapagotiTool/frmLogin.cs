using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MetroSet_UI.Forms;
using PapagotiTool.DataConfig;

namespace PapagotiTool
{
    public partial class frmLogin : MetroSetForm
    {
        public frmLogin()
        {
            InitializeComponent();
            txtAuthSecret.Text = Properties.Settings.Default.PassWord;
            txtDatabase.Text = Properties.Settings.Default.UserName;
        }

        private String DatabaseFirebase;
        private String AuthSecret;

        private bool nullUiCheck()
        {
            if (string.IsNullOrEmpty(DatabaseFirebase) || string.IsNullOrEmpty(AuthSecret))
            {
                MessageBox.Show(this, "Input is required");
                return false;
            }else
            return true;
        }

        private async void logginFirebaseCheck()
        {
            try
            {
                if (nullUiCheck())
                {
                    IFirebaseConfig config = new FirebaseConfig
                    {
                        AuthSecret = AuthSecret,
                        BasePath = DatabaseFirebase
                    };
                    IFirebaseClient client = new FirebaseClient(config);

                    Model.LoginMachine machine = new Model.LoginMachine
                    {
                        MachineName = Environment.MachineName
                    };

                    PushResponse push = await client.PushAsync("LoginLog", machine);

                    if (push.Result.name != null||SqlConnectionCheck())
                    {
                        tofrmMain();
                    }
                    else
                    {
                        MessageBox.Show(this, "Firebase authencation error!");
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Firebase authencation error!");
            }
        }


        private bool SqlConnectionCheck()
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", txtServer.Text, txtDatabaseLocal.Text, txtUserName.Text, txtPassword.Text);
            try
            {
                DataConfig.SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void tofrmMain()
        {
            Properties.Settings.Default.UserName = DatabaseFirebase;
            Properties.Settings.Default.PassWord = AuthSecret;
            Properties.Settings.Default.Save();

            this.Hide();
            frmMain frmMain = new frmMain(Properties.Settings.Default.PassWord, Properties.Settings.Default.UserName);
            frmMain.ShowDialog();
        }
        
        private  void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseFirebase = txtDatabase.Text;
            AuthSecret = txtAuthSecret.Text;
            logginFirebaseCheck();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataConfig.AppSetting setting = new AppSetting();
            Properties.Settings.Default.fileName = System.Reflection.Assembly.GetEntryAssembly().Location;
            txtConnectionString.Text = setting.GetConnectionString("dbContext");
            txtDatabaseLocal.Text = Properties.Settings.Default.DatabaseName;
            txtServer.Text = Properties.Settings.Default.Server;
            txtUserName.Text = Properties.Settings.Default.UsDatabase;
            txtPassword.Text = Properties.Settings.Default.PwDatabase;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (SqlConnectionCheck())
            {
                Properties.Settings.Default.Server = txtServer.Text;
                Properties.Settings.Default.UsDatabase = txtUserName.Text;
                Properties.Settings.Default.PwDatabase = txtPassword.Text;
                Properties.Settings.Default.DatabaseName = txtDatabaseLocal.Text;
                Properties.Settings.Default.Save();

                string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", txtServer.Text, txtDatabaseLocal.Text, txtUserName.Text, txtPassword.Text);
                DataConfig.AppSetting setting = new DataConfig.AppSetting();
                setting.SaveConnectionString("dbContext", connectionString);
            }
        }
    }
}
