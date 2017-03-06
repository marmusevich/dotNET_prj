using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITexport
{
    public partial class frmDogovora : Form
    {
        public frmDogovora()
        {
            InitializeComponent();
        }

        private void frmDogovora_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iotDataSet.DOG". При необходимости она может быть перемещена или удалена.
            this.dOGTableAdapter.Fill(this.iotDataSet.DOG);

        }
    }
}
