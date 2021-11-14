using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server= LAPTOP-HG165ILN\\SQLEXPRESS; database=DBActividadesCursoCSharp; integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Persona persona = new Persona();
            persona.id = int.Parse(txtId.Text);
            persona.nombre = txtNombre.Text;
            persona.apellidos = txtApellido.Text;
            persona.edad = int.Parse(txtEdad.Text);
            persona.fecha = DateTime.Now.ToString("yyyy-MM-dd");

            string sql = $"insert into Datos(id, nombres, apellidos, edad, fecha) values ({persona.id},'{persona.nombre}','{persona.apellidos}','{persona.edad}', '{persona.fecha}')";
            SqlCommand commando = new SqlCommand(sql, conexion);
            Console.WriteLine(sql);
            commando.ExecuteNonQuery();
            conexion.Close();
            clearTxt();
            fillTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");
                fillTable();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }
        }

        private void dtgvNombres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            fillTable();
            conexion.Close();
        }
        public void fillTable()
        {
            SqlCommand comando = new SqlCommand("exec sp_datos", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dtgvNombres.DataSource = tabla;
        }

        public void clearTxt()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtId.Focus();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
