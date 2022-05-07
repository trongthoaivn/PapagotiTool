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
using MetroSet_UI.Forms;


namespace PapagotiTool
{
    public partial class frmLogin : MetroSetForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private  void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var Database = txtDatabase.Text;
                var AuthSecret = txtAuthSecret.Text;
                if (string.IsNullOrEmpty(Database)||string.IsNullOrEmpty(AuthSecret))
                {
                    MessageBox.Show(this, "Input is required");
                }
                else
                {
                    this.Hide();
                    frmMain frmMain = new frmMain(Database, AuthSecret);
                    frmMain.ShowDialog();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(this, "Login error"+ ex.Message);
            }
        }

        
    }
}
