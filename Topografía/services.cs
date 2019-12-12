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
    public partial class services : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.TopografiaConnectionString1);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public services()
        {
            InitializeComponent();
            
        }

        private void btnAgregar(object sender, EventArgs e)
        {
            if (NoServicio.Text == "")
            {
                MessageBox.Show("Ingresa un número de servicio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Service.Text == "")
            {
                MessageBox.Show("Ingresa un nombre de servicio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                String Nombre = Service.Text;
                String ID = NoServicio.Text;
                try {

                con.Open();
                cmd = new SqlCommand("INSERT INTO Servicio VALUES ('" + ID + "','" + Nombre +"')", con);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter("SELECT * FROM Servicio", con);
                dt = new DataTable();
                da.Fill(dt);
                SContainer.DataSource = dt;
                con.Close();
                }
                catch { MessageBox.Show("Error al registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                Service.Clear();
                NoServicio.Clear();
            }
        } 
}
