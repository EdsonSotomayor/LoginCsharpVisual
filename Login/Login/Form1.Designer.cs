namespace Login
{
    partial class Gral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gral));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pasw = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO DE SESIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.username.Location = new System.Drawing.Point(12, 128);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(299, 29);
            this.username.TabIndex = 1;
            this.username.Text = "NOMBRE DE USUARIO: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(36, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 2;
            // 
            // pasw
            // 
            this.pasw.AutoSize = true;
            this.pasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.pasw.Location = new System.Drawing.Point(12, 223);
            this.pasw.Name = "pasw";
            this.pasw.Size = new System.Drawing.Size(201, 29);
            this.pasw.TabIndex = 3;
            this.pasw.Text = "CONTRASEÑA: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Gral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 494);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pasw);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Gral";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pasw;
        private System.Windows.Forms.TextBox textBox2;
    }
}

