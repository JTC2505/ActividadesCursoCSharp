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

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server= LAPTOP-HG165ILN\\SQLEXPRESS; database=DBActividadesCursoCSharp; integrated security=true");
            conexion.Open();
            SqlCommand cmd = new SqlCommand($"delete from Datos where id = {textBox1.Text}", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            textBox1.Text = "";
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.fillTable();
            this.Hide();
        }
    }
}
