namespace Topografía
{
    partial class C_Personal
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
            this.txtFolioC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailC = new System.Windows.Forms.TextBox();
            this.NumC = new System.Windows.Forms.TextBox();
            this.DirC = new System.Windows.Forms.TextBox();
            this.NameC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtFolioC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmailC);
            this.panel1.Controls.Add(this.NumC);
            this.panel1.Controls.Add(this.DirC);
            this.panel1.Controls.Add(this.NameC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 328);
            this.panel1.TabIndex = 0;
            // 
            // txtFolioC
            // 
            this.txtFolioC.Location = new System.Drawing.Point(93, 20);
            this.txtFolioC.Name = "txtFolioC";
            this.txtFolioC.Size = new System.Drawing.Size(65, 20);
            this.txtFolioC.TabIndex = 32;
            this.txtFolioC.TextChanged += new System.EventHandler(this.FBD);
            this.txtFolioC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FKey);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Folio:";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(93, 284);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 30;
            this.Register.Text = "Registrar";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dirección:";
            // 
            // EmailC
            // 
            this.EmailC.Location = new System.Drawing.Point(58, 238);
            this.EmailC.Name = "EmailC";
            this.EmailC.Size = new System.Drawing.Size(100, 20);
            this.EmailC.TabIndex = 26;
            // 
            // NumC
            // 
            this.NumC.Location = new System.Drawing.Point(58, 180);
            this.NumC.Name = "NumC";
            this.NumC.Size = new System.Drawing.Size(100, 20);
            this.NumC.TabIndex = 25;
            this.NumC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumKey);
            this.NumC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // DirC
            // 
            this.DirC.Location = new System.Drawing.Point(58, 124);
            this.DirC.Name = "DirC";
            this.DirC.Size = new System.Drawing.Size(100, 20);
            this.DirC.TabIndex = 24;
            this.DirC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirKey);
            // 
            // NameC
            // 
            this.NameC.Location = new System.Drawing.Point(58, 68);
            this.NameC.Name = "NameC";
            this.NameC.Size = new System.Drawing.Size(100, 20);
            this.NameC.TabIndex = 23;
            this.NameC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameKey);
            this.NameC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre completo:";
            // 
            // C_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.panel1);
            this.Name = "C_Personal";
            this.Text = "Registrar Personal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFolioC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailC;
        private System.Windows.Forms.TextBox NumC;
        private System.Windows.Forms.TextBox DirC;
        private System.Windows.Forms.TextBox NameC;
        private System.Windows.Forms.Label label1;

    }
}