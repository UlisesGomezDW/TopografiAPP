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
    public partial class D_Personal : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.TopografiaConnectionString1);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public D_Personal()
        {
            InitializeComponent();
        }


        private void Buscar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT FolioPersonal FROM Personal WHERE (FolioPersonal='" + FolioD.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            string date = Convert.ToString(cmd.ExecuteScalar());
            if (date == "")
            {
                MessageBox.Show("No existe registro con el folio: " + FolioD.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                FolioD.Clear();
            }
            else if (FolioD.Text == "")
            {
                MessageBox.Show("Ingrese el Folio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            else
            {
                da = new SqlDataAdapter("SELECT * FROM Personal WHERE (FolioPersonal='" + FolioD.Text + "')", con);
                dt = new DataTable();
                da.Fill(dt);
                Dcontainer.DataSource = dt;
                con.Close();
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este registro?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Personal WHERE (FolioPersonal= '" + FolioD.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    da = new SqlDataAdapter("SELECT * FROM Personal WHERE (FolioPersonal='" + FolioD.Text + "')", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    Dcontainer.DataSource = dt;
                    con.Close();
                    FolioD.Clear();
                }
                catch
                {
                    MessageBox.Show("No se pudo borrar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
            }
            
        }
    }
}
