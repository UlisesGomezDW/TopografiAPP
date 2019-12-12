namespace Topografía
{
    partial class U_user
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
            this.Buscar = new System.Windows.Forms.Button();
            this.FolioU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailU = new System.Windows.Forms.TextBox();
            this.NumU = new System.Windows.Forms.TextBox();
            this.DirU = new System.Windows.Forms.TextBox();
            this.NameU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.FolioU);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmailU);
            this.panel1.Controls.Add(this.NumU);
            this.panel1.Controls.Add(this.DirU);
            this.panel1.Controls.Add(this.NameU);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 311);
            this.panel1.TabIndex = 0;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(152, 11);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(70, 20);
            this.Buscar.TabIndex = 34;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.view);
            // 
            // FolioU
            // 
            this.FolioU.Location = new System.Drawing.Point(73, 11);
            this.FolioU.Name = "FolioU";
            this.FolioU.Size = new System.Drawing.Size(65, 20);
            this.FolioU.TabIndex = 33;
            this.FolioU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FoliokeyU);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Folio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dirección:";
            // 
            // EmailU
            // 
            this.EmailU.Location = new System.Drawing.Point(38, 229);
            this.EmailU.Name = "EmailU";
            this.EmailU.Size = new System.Drawing.Size(100, 20);
            this.EmailU.TabIndex = 27;
            // 
            // NumU
            // 
            this.NumU.Location = new System.Drawing.Point(38, 171);
            this.NumU.Name = "NumU";
            this.NumU.Size = new System.Drawing.Size(100, 20);
            this.NumU.TabIndex = 26;
            this.NumU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumUkey);
            this.NumU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUV);
            // 
            // DirU
            // 
            this.DirU.Location = new System.Drawing.Point(38, 115);
            this.DirU.Name = "DirU";
            this.DirU.Size = new System.Drawing.Size(100, 20);
            this.DirU.TabIndex = 25;
            this.DirU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirUkey);
            // 
            // NameU
            // 
            this.NameU.Location = new System.Drawing.Point(38, 59);
            this.NameU.Name = "NameU";
            this.NameU.Size = new System.Drawing.Size(100, 20);
            this.NameU.TabIndex = 24;
            this.NameU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameUkey);
            this.NameU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameUV);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre completo:";
            // 
            // U_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(281, 335);
            this.Controls.Add(this.panel1);
            this.Name = "U_user";
            this.Text = "Actualizar usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox FolioU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailU;
        private System.Windows.Forms.TextBox NumU;
        private System.Windows.Forms.TextBox DirU;
        private System.Windows.Forms.TextBox NameU;
        private System.Windows.Forms.Label label1;


    }
}