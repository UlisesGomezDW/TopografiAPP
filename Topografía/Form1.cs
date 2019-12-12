using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Topografía
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = user;
            user.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                MessageBox.Show("Ingrese el usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Form2 obj = new Form2();
                obj.Visible = true;
                Visible = false;
            }
            
        }

        private void ChangeText(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else {
                e.Handled = false;
                MessageBox.Show("Solo se admiten letras", "Validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UserKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                password.Focus();
            }
        }
        private void PassKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }
    }
}
