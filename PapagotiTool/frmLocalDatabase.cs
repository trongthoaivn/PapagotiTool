using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using LiveChartsCore.SkiaSharpView;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using LiveChartsCore.Kernel;


namespace PapagotiTool
{
    public partial class frmLocalDatabase : MetroSetForm
    {
        public frmLocalDatabase()
        {
            InitializeComponent();
        }


        struct DataParameter
        {
            public List<Model.Floor> floorsList;
            public String fileName { get; set; }
        }

        public class Detail
        {
            public double Value { get; set; }
            public int Id { get; set; }
        }

        private Model.dbContext dbContext = new Model.dbContext();
        private List<Model.Floor> floors;
        private DataParameter inputdData;
        private void getValueFormDatabaseLocal()
        {
            try
            {
                gvData.DataSource = null;
                var floorName = txtFloorName.Text;
                if (!floorName.Equals(""))
                {
                    var atimeForm = DateTime.ParseExact(dbFrom.Text + " " + timeFrom.Text, "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    var btimeTo = DateTime.ParseExact(dbTo.Text+ " "+timeTo.Text, "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

                    var data = dbContext.Floors.Where(i => i.FloorName.Equals(floorName)
                    && (DateTime.Compare((DateTime)i.Time,btimeTo) < 0 || DateTime.Compare((DateTime)i.Time, btimeTo) == 0)
                    && (DateTime.Compare((DateTime)i.Time, atimeForm) > 0 || DateTime.Compare((DateTime)i.Time, atimeForm) == 0)).ToList();
                    
                    floors = data;
                  
                }
                else
                {
                    MessageBox.Show("Please input floor name");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.fileName);
            Environment.Exit(0);
        }

        private void frmLocalDatabase_Load(object sender, EventArgs e)
        {
            dbFrom.CustomFormat = "MM/dd/yyyy";
            dbTo.CustomFormat = "MM/dd/yyyy";
            timeTo.CustomFormat = "hh:mm tt";
            timeFrom.CustomFormat = "hh:mm tt";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gvData.DataSource = null;
            var floorName = txtFloorName.Text;
            if (!floorName.Equals(""))
            {
                backgroundWorkerGetData.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please input floor name");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gvData.DataSource = null ;
            chart.Series = null ;
            lbChartName.Text = "Chart Name :";
            lbForm.Text = "Form : ";
            lbTo.Text = "To : ";
            lbCount.Text = "Point Count : ";
        }

        private void gvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.ColumnIndex;
            chart.Series = null;
            if (index !=0 && index !=1 && index != 10) {
                try 
                {
                    lbChartName.Text = "Chart Name : " + gvData.Columns[index].Name;
                    lbForm.Text = "Form : " + dbFrom.Text + " " + timeFrom.Text;
                    lbTo.Text = "To : " + dbTo.Text + " " + timeTo.Text;
                    List<Detail> list = new List<Detail>();
                    foreach (DataGridViewRow item in gvData.Rows)
                    {
                        if(item.Cells[index].Value != null)
                        {
                            list.Add(new Detail
                            {
                                Value = Double.Parse(item.Cells[index].Value.ToString()),
                                Id = int.Parse(item.Cells[0].Value.ToString())
                            });
                        } 
                    }

                    lbCount.Text = "Point Count : " + list.Count;
                    var detailSeries = new LiveChartsCore.ISeries[]
                    {
                    new LineSeries<Detail>
                    {
                        Values = list,
                        Mapping = (detail , point) =>
                        {
                            point.PrimaryValue = (double) detail.Value;
                            point.SecondaryValue = point.Context.Index;
                            point.TertiaryValue = (double) detail.Id;
                        },
                        TooltipLabelFormatter = point => $"Value : {point.PrimaryValue}, ID: {point.TertiaryValue}  "
                    }
                    };
                    chart.Series = detailSeries;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerExport.IsBusy) return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                inputdData.fileName = saveFileDialog1.FileName;
                inputdData.floorsList = floors;
                progressBar1.Minimum = 0;   
                progressBar1.Value = 0;
                backgroundWorkerExport.RunWorkerAsync(inputdData);
            } 
            
        }

        private void backgroundWorkerExport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Update();
        }

        private void backgroundWorkerExport_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Model.Floor> list =((DataParameter)e.Argument).floorsList;
            if(list != null)
            {
                try
                {
                    string fileName = ((DataParameter)e.Argument).fileName;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet); ;
                    Worksheet ws = (Worksheet)excel.ActiveSheet;
                    int index = 1;
                    int process = list.Count;
                    ws.Cells[1, 1] = "ID";
                    ws.Cells[1, 2] = "FloorName";
                    ws.Cells[1, 3] = "Time";
                    ws.Cells[1, 4] = "Power";
                    ws.Cells[1, 5] = "Frequency";
                    ws.Cells[1, 6] = "Current";
                    ws.Cells[1, 7] = "Humidity";
                    ws.Cells[1, 8] = "Voltage";
                    ws.Cells[1, 9] = "Energy";
                    ws.Cells[1, 10] = "Temperature";
                    ws.Cells[1, 11] = "PF";
                    foreach (Model.Floor floor in list)
                    {
                        if (!backgroundWorkerExport.CancellationPending)
                        {
                            backgroundWorkerExport.ReportProgress(index++ * 100 / process);
                            ws.Cells[index, 1] = floor.ID;
                            ws.Cells[index, 2] = floor.FloorName;
                            ws.Cells[index, 3] = floor.Time;
                            ws.Cells[index, 4] = floor.Power;
                            ws.Cells[index, 5] = floor.Frequency;
                            ws.Cells[index, 6] = floor.Current;
                            ws.Cells[index, 7] = floor.Humidity;
                            ws.Cells[index, 8] = floor.Voltage;
                            ws.Cells[index, 9] = floor.Energy;
                            ws.Cells[index, 10] = floor.Temperature;
                            ws.Cells[index, 11] = floor.PF;
                        }
                    }
                    ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Type.Missing, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    excel.Quit();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please insert data to export");
            }
        }

        private void backgroundWorkerExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
            }
        }

        private void backgroundWorkerGetData_DoWork(object sender, DoWorkEventArgs e)
        {
            getValueFormDatabaseLocal();
        }

        private void backgroundWorkerGetData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gvData.DataSource = floors;
            gvData.Columns[gvData.ColumnCount - 1].Width = 175;
        }

        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void chart_ChartPointPointerDown(LiveChartsCore.Kernel.Sketches.IChartView chart, ChartPoint point)
        {
            gvData.FirstDisplayedScrollingRowIndex = point.Context.Index;
            gvData.ClearSelection();
            gvData.Rows[point.Context.Index].Selected = true; 
        }


    }
}
