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
    public partial class U_Personal : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.TopografiaConnectionString1);
        SqlCommand cmd;
        public U_Personal()
        {
            InitializeComponent();
            this.ActiveControl = FolioU;
            FolioU.Focus();
        }


        private void NameUV(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else
            {
                e.Handled = false;
                MessageBox.Show("Solo se admiten letras", "Validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void NumUV(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else
            {
                e.Handled = false;
                MessageBox.Show("Solo se admiten números", "Validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (NameU.Text == "")
            {
                MessageBox.Show("Nombre completo vacío, ingrese el dato.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DirU.Text == "")
            {
                MessageBox.Show("Dirección vacía, ingrese el dato.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumU.Text == "")
            {
                MessageBox.Show("Número de teléfono vacío, ingrese el dato.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmailU.Text == "")
            {
                MessageBox.Show("Correo vacío, ingrese el dato.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                String Nombre = NameU.Text;
                String Direccion = DirU.Text;
                String Telefono = NumU.Text;
                String Correo = EmailU.Text;

                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Personal SET  NombreCompleto = @NombreCompleto, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo WHERE (FolioPersonal='" + FolioU.Text + "')", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NombreCompleto", Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    FolioU.Clear();
                    NameU.Clear();
                    DirU.Clear();
                    NumU.Clear();
                    EmailU.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al modificar.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Datos actualizados exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void view(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT FolioPersonal FROM Personal WHERE (FolioPersonal='" + FolioU.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            string date = Convert.ToString(cmd.ExecuteScalar());
            if (date == "")
            {
                MessageBox.Show("No existe registro con el folio: " + FolioU.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                FolioU.Clear();
                NameU.Clear();
                DirU.Clear();
                NumU.Clear();
                EmailU.Clear();
            }else if (FolioU.Text == "")
            {
                MessageBox.Show("Ingrese el Folio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            else
            {
                string d1 = "SELECT NombreCompleto FROM Personal WHERE (FolioPersonal='" + FolioU.Text + "')";
                SqlCommand c1 = new SqlCommand(d1, con);
                NameU.Text = Convert.ToString(c1.ExecuteScalar());

                string d2 = "SELECT Direccion FROM Personal WHERE (FolioPersonal='" + FolioU.Text + "')";
                SqlCommand c2 = new SqlCommand(d2, con);
                DirU.Text = Convert.ToString(c2.ExecuteScalar());

                string d3 = "SELECT Telefono FROM Personal WHERE (FolioPersonal='" + FolioU.Text + "')";
                SqlCommand c3 = new SqlCommand(d3, con);
                NumU.Text = Convert.ToString(c3.ExecuteScalar());

                string d4 = "SELECT Correo FROM Personal WHERE (FolioPersonal='" + FolioU.Text + "')";
                SqlCommand c4 = new SqlCommand(d4, con);
                EmailU.Text = Convert.ToString(c4.ExecuteScalar());
                con.Close();
            }
            
        }

        private void FolioKeyU(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NameU.Focus();
            }
        }

        private void NameUKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DirU.Focus();
            }
        }

        private void DirUKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumU.Focus();
            }
        }

        private void NumUKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailU.Focus();
            }
        }
    }
}
