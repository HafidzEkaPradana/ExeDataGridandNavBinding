using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DataGrid data = new DataGrid();
            data.Show();
            this.Hide();
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
