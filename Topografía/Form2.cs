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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 win = new Form1();
            win.Visible = true;
            Visible = false;
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form C_user = new C_user();
            C_user.ShowDialog();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form R_user = new R_user();
            R_user.ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form U_user = new U_user();
            U_user.ShowDialog();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form D_user = new D_user();
            D_user.ShowDialog();
        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form C_Personal = new C_Personal();
            C_Personal.ShowDialog();
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form R_Personal = new R_Personal();
            R_Personal.ShowDialog();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form U_Personal = new U_Personal();
            U_Personal.ShowDialog();
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form D_Personal = new D_Personal();
            D_Personal.ShowDialog();
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form services = new services();
            services.ShowDialog();
        }

    }
}
