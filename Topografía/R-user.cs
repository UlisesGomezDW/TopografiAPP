using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Topografía
{
    public partial class R_user : Form
    {
        SqlDataAdapter adactador;
        SqlCommand sqlselect;
        SqlConnection conexion;
        DataSet dataset1;

        SqlConnection con = new SqlConnection(Properties.Settings.Default.TopografiaConnectionString1);

        SqlDataAdapter da;
        DataTable dt;
        public R_user()
        {
            InitializeComponent();
            adactador = new SqlDataAdapter();
            sqlselect = new SqlCommand();
            conexion = new SqlConnection();
            dataset1 = new DataSet();

            conexion.ConnectionString = Connect.stringConecction();

            adactador.SelectCommand = sqlselect;
            sqlselect.Connection = conexion;

            sqlselect.CommandText = "SELECT * FROM Cliente";
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la base de datos" + ex.Message);
            }
            adactador.Fill(dataset1, "Cliente");
            
            conexion.Close();
            UContainer.DataSource = dataset1.Tables["Cliente"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT FolioCliente FROM Cliente WHERE (FolioCliente='" + textBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            string date = Convert.ToString(cmd.ExecuteScalar());
            if (date == "")
            {
                MessageBox.Show("No existe registro con el folio: " + textBox1.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Cliente WHERE FolioCliente='" + textBox1.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                Ccontainer.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar");
            }

            textBox1.Clear();
        }

        
    }
}
