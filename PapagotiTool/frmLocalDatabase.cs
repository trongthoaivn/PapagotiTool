using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;

namespace PapagotiTool
{
    public partial class frmLocalDatabase : MetroSetForm
    {
        public frmLocalDatabase()
        {
            InitializeComponent();
        }


        private Model.dbContext dbContext = new Model.dbContext();
        private List<Model.Floor> floors;

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.fileName);
            Environment.Exit(0);
        }

        private void frmLocalDatabase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gvData.DataSource = null;
                var floorName = txtFloorName.Text;
                var timeForm = DateTime.Parse(dbFrom.Value.ToString());
                var timeTo = DateTime.Parse(dbTo.Value.ToString());
                
                var data = dbContext.Floors.Where(i => i.FloorName.Equals(floorName)
                && i.Time.Value.Day <= timeTo.Day && i.Time.Value.Day >= timeForm.Day).ToList();
                
                floors = data;

                BindingSource binding = new BindingSource();
                binding.DataSource = data;
                gvData.DataSource = binding;


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gvData.DataSource = null ;
            chart.Series = null ;
        }

        private void gvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = gvData.CurrentCell.ColumnIndex;
            chart.Series = null;
            if (index !=0 && index !=1 && index!=8) {
                List<double> list = new List<double>();
                foreach (DataGridViewRow item in gvData.Rows)
                {
                    list.Add(Double.Parse(item.Cells[gvData.CurrentCell.ColumnIndex].Value.ToString()));
                }

                double[] arr = list.ToArray();
                Model.ViewModel view = new Model.ViewModel();
                view.Series = new LiveChartsCore.ISeries[] {
                new LineSeries<double>{Values = arr,Fill = null}
            };
                chart.Series = view.Series;
            }
        }
    }
}
