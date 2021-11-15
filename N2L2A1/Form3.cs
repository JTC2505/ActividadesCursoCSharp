using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2L2A1
{
    public partial class Form3 : Form
    {
        private ConexionUsuariosDataContext conexion = new ConexionUsuariosDataContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exist = 0;
            var loginMatch = from user in conexion.Usuarios
                             where user.usuario == textBox1.Text && user.password == textBox2.Text
                             select 1;
            foreach (int num in loginMatch)
            {
                exist = num;
            }
            if (exist == 1)
            {
                MessageBox.Show("Usuario existente");
            }
            else
            {
                MessageBox.Show("Usuario no existente");
            }
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.textBox1.Focus();
                }
            }
        }
    }
}
