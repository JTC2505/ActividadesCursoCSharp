using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2L1A1
{
    public partial class Form2 : Form
    {
        Usuario usuario = new Usuario();
        List<Usuario> userList = new List<Usuario>();
        public Form2(ref List<Usuario> usuarios)
        {
            userList = usuarios;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(ref userList);
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.Registro(ref userList, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
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
