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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            // TODO: This line of code loads data into the 'prodiTIDataSet.Periode' table. You can move, or remove it, as needed.
            this.periodeTableAdapter.Fill(this.prodiTIDataSet.Periode);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.prodiTIDataSet.MataKuliah);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["sexDataGrid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["nimDataGrid"].DefaultCellStyle.SelectionBackColor = Color.Crimson;
            dataGridView1.Columns["nimDataGrid"].DefaultCellStyle.ForeColor = Color.DarkRed;

            dataGridView1.Columns["namaMhsDataGrid"].DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
            dataGridView1.Columns["namaMhsDataGrid"].DefaultCellStyle.ForeColor = Color.DarkOliveGreen;

            dataGridView1.Columns["alamatMhsDataGrid"].DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView1.Columns["alamatMhsDataGrid"].DefaultCellStyle.ForeColor = Color.DeepSkyBlue;

            dataGridView1.Columns["sexDataGrid"].DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            dataGridView1.Columns["sexDataGrid"].DefaultCellStyle.ForeColor = Color.Maroon;

            dataGridView1.Columns["phoneMhsDataGrid"].DefaultCellStyle.SelectionBackColor = Color.SaddleBrown;
            dataGridView1.Columns["phoneMhsDataGrid"].DefaultCellStyle.ForeColor = Color.SandyBrown;

            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView data = new DataView();
            data.labelNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            data.labelNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            data.labelAlmt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            data.labelJk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            data.labelNop.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            data.Show();
            this.Hide();
        }
    }
    
}
