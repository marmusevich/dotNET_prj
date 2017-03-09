using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using DgvFilterPopup;


namespace ITexport
{
    public partial class frmMain : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  variable
        //---------------------------------------------------------------------------------------------------------------------------------------------
        protected bool enable_dtpDataEvent = true;        

        #endregion
       
        

        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  --
        //---------------------------------------------------------------------------------------------------------------------------------------------

        #endregion

        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  form event 1
        //---------------------------------------------------------------------------------------------------------------------------------------------
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtpDataOt.Value = SharedClass.GetFirstMonthDayDate(DateTime.Now);
            dtpDatePo.Value = SharedClass.GetLastMonthDayDate(DateTime.Now);
        }

        
        
        private void dtpDataOt_ValueChanged(object sender, EventArgs e)
        {
            //if (tableWrapper != null && enable_dtpDataEvent)
            //{
            ////    tableWrapper.QueryFilter = BuildConditions();
            //    Reflesh();
            //}
        }
        private void dtpDatePo_ValueChanged(object sender, EventArgs e)
        {
            //if (tableWrapper != null && enable_dtpDataEvent)
            //{
            ////    tableWrapper.QueryFilter = BuildConditions();
            //    Reflesh();
            //}
        }

        private void btnChangePeriod(object sender, EventArgs e)
        {
            Button but = sender as Button;
            if (but != null && but.Tag != null)
            {
                try
                {
                    short add = Convert.ToInt16(but.Tag);
                    enable_dtpDataEvent = false;
                    dtpDataOt.Value = SharedClass.GetFirstMonthDayDate(new DateTime(dtpDataOt.Value.Year, dtpDataOt.Value.Month + add, 15));
                    dtpDatePo.Value = SharedClass.GetLastMonthDayDate(new DateTime(dtpDatePo.Value.Year, dtpDatePo.Value.Month + add, 15));
                    //tableWrapper.QueryFilter = BuildConditions();
                    Reflesh();
                }
                catch { }
                finally
                {
                    enable_dtpDataEvent = true;
                }
            }
        }

        #endregion


        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  function
        //---------------------------------------------------------------------------------------------------------------------------------------------
        protected void Reflesh()
        {
            //tableWrapper.UpdateData();
            //dgvDoc.Refresh();
        }

        #endregion


        public DataTable GetData(string strSQL)
        {
            //OleDbDataAdapter DataAdapter = new OleDbDataAdapter(strSQL, Properties.Settings.Default.SampleDBConnectionString);
            DataTable dtable = new DataTable();
            //DataAdapter.Fill(dtable);
            //DataAdapter.SelectCommand.Connection.Close();

            dtable.Columns.Add("IsCheck", typeof(Boolean));

            return dtable;
        }

        public void InitGrid()
        {
            //dataGridView1.DataSource = GetData("SELECT * FROM Orders");

            //dataGridView1.Columns["IsCheck"].DisplayIndex = 0;
            //dataGridView1.Columns["IsCheck"].Frozen = true;
        }

        private void Sample1_Load(object sender, EventArgs e)
        {
            //InitGrid();
            //new DgvFilterManager(dataGridView1);


            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //col = dataGridView1.Columns["IsCheck"].Index;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == col && e.RowIndex != -1)
            //{
            //    object b = ((System.Windows.Forms.DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[col]).EditingCellFormattedValue;
            //    //MessageBox.Show(" row " + b);
            //    //dataGridView1.Rows[e.RowIndex].Cells[1].Value = " row " + b;
            //}
        }



        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  form event 2
        //---------------------------------------------------------------------------------------------------------------------------------------------
        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbContractKazna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbContractTender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbContractAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvContracts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

    }
}
