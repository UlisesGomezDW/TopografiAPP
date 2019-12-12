namespace Topografía
{
    partial class D_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Dcontainer = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.FolioD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dcontainer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Dcontainer);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.FolioD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 237);
            this.panel1.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(113, 178);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 42;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Dcontainer
            // 
            this.Dcontainer.BackgroundColor = System.Drawing.Color.White;
            this.Dcontainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dcontainer.Location = new System.Drawing.Point(31, 75);
            this.Dcontainer.Name = "Dcontainer";
            this.Dcontainer.Size = new System.Drawing.Size(240, 75);
            this.Dcontainer.TabIndex = 41;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(175, 36);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(70, 20);
            this.Buscar.TabIndex = 40;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // FolioD
            // 
            this.FolioD.Location = new System.Drawing.Point(96, 36);
            this.FolioD.Name = "FolioD";
            this.FolioD.Size = new System.Drawing.Size(65, 20);
            this.FolioD.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Folio:";
            // 
            // D_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.panel1);
            this.Name = "D_user";
            this.Text = "D_user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dcontainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView Dcontainer;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox FolioD;
        private System.Windows.Forms.Label label5;

    }
}