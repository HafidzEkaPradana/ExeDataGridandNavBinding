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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "hafidz";
            string password = "hafidz123";



            if (textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi !!");
            }
            else if (textBoxUser.Text != username || textBoxPass.Text != password)
            {
                MessageBox.Show("Username atau password yang anda masukkan salah !!");
            }
            else
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
