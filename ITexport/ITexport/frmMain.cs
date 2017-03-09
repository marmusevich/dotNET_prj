using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITexport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //tbConn.Text = ITexport.dbConnect.conStringIT;

            string connetionString = null;
            ;

            // to do: вырезать параметры из строки
            //connetionString = "DRIVER={SQLServer};SERVER={192.168.10.8};UID={sa};PWD={291263};DATABASE={IOT};Network={DBMSSOCN};APP={IT.%DATABASE%};WSID={%WSID%}";
            //connetionString="Data Source=IP_ADDRESS,PORT;Network Library=DBMSSOCN;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
            connetionString = "Data Source=192.168.10.8;Network Library=DBMSSOCN;Initial Catalog=iot;User ID=sa;Password=291263";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();

                    //cnn.CreateCommand();

                    MessageBox.Show("Connection Open ! ");

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
