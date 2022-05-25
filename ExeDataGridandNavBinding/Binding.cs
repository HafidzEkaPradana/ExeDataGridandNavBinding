using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Binding : Form
    {
        public Binding()
        {
            InitializeComponent();
        }

        SqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        string connstring = "database=ProdiIT;server=LAPTOP-8MKEQ456;user=sa;password=mentepermaib20";
        private void Form2_Load(object sender, EventArgs e)
        {
            dadapter = new SqlDataAdapter("select * from HRD.Mahasiswa", connstring);
            dset = new DataSet();
            dadapter.Fill(dset);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bindingNavigator1.BindingSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
