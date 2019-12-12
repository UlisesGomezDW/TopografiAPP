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
    public partial class C_Personal : Form
    {
        SqlDataAdapter adactador;
        SqlCommand sqlselect;
        SqlConnection conexion;
        DataSet dataset1;

        SqlConnection con = new SqlConnection(Properties.Settings.Default.TopografiaConnectionString1);
        SqlCommand cmd;
        public C_Personal()
        {
            InitializeComponent();
            this.ActiveControl = txtFolioC;
            txtFolioC.Focus();
            adactador = new SqlDataAdapter();
            sqlselect = new SqlCommand();
            conexion = new SqlConnection();
            dataset1 = new DataSet();

            //Llamado a la clase del String Principal
            conexion.ConnectionString = Connect.stringConecction();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtFolioC.Text == "")
            {
                MessageBox.Show("Ingrese el Folio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NameC.Text == "")
            {
                MessageBox.Show("Ingrese su nombre completo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DirC.Text == "")
            {
                MessageBox.Show("Ingrese su dirección", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumC.Text == "")
            {
                MessageBox.Show("Ingrese su número de teléfono", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmailC.Text == "")
            {
                MessageBox.Show("Ingrese su correo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int Folio = int.Parse(txtFolioC.Text);
                String Nombre = NameC.Text;
                String Direccion = DirC.Text;
                String Telefono = NumC.Text;
                String Correo = EmailC.Text;
                
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Personal (FolioPersonal, NombreCompleto, Direccion, Telefono, Correo) VALUES (@FolioPersonal, @NombreCompleto, @Direccion, @Telefono, @Correo)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@FolioPersonal", Folio);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error en la base de datos" + ex.Message);
                }
                MessageBox.Show("Datos guardados exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtFolioC.Clear();
                NameC.Clear();
                DirC.Clear();
                NumC.Clear();
                EmailC.Clear();
            }
        }


        private void NameKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DirC.Focus();
            }
        }

        private void DirKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumC.Focus();
            }
        }

        private void NumKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailC.Focus();
            }
        }

        private void Number(object sender, KeyPressEventArgs e)
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

        private void NameValidation(object sender, KeyPressEventArgs e)
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

        private void FKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NameC.Focus();
            }
        }

        private void FBD(object sender, EventArgs e)
        {
            if (txtFolioC.Text == "")
            {
                MessageBox.Show("Ingresa un folio para comenzar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            string query = "SELECT FolioPersonal FROM Personal WHERE (FolioPersonal='" + txtFolioC.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            string date = Convert.ToString(cmd.ExecuteScalar());

            if (date == txtFolioC.Text)
            {
                MessageBox.Show("Ya existe un registro con el folio " + txtFolioC.Text + ". Por favor, ingrese otro folio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            else
            {
                MessageBox.Show("El Folio " + txtFolioC.Text + " disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            con.Close();
        }

    }
}
