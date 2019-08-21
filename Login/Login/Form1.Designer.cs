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
            this.User = new System.Windows.Forms.TextBox();
            this.pasw = new System.Windows.Forms.Label();
            this.Pasword = new System.Windows.Forms.TextBox();
            this.buttoniN = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
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
            // User
            // 
            this.User.BackColor = System.Drawing.Color.White;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.User.Location = new System.Drawing.Point(36, 170);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(177, 23);
            this.User.TabIndex = 2;
            this.User.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            // Pasword
            // 
            this.Pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pasword.Location = new System.Drawing.Point(36, 264);
            this.Pasword.Name = "Pasword";
            this.Pasword.PasswordChar = '*';
            this.Pasword.Size = new System.Drawing.Size(177, 26);
            this.Pasword.TabIndex = 4;
            // 
            // buttoniN
            // 
            this.buttoniN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttoniN.Location = new System.Drawing.Point(273, 407);
            this.buttoniN.Name = "buttoniN";
            this.buttoniN.Size = new System.Drawing.Size(141, 51);
            this.buttoniN.TabIndex = 5;
            this.buttoniN.Text = "INICIA SESION";
            this.buttoniN.UseVisualStyleBackColor = false;
            this.buttoniN.Click += new System.EventHandler(this.ButtoniN_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonS.Location = new System.Drawing.Point(565, 407);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(141, 51);
            this.buttonS.TabIndex = 6;
            this.buttonS.Text = "SALIR";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.ButtonS_Click);
            // 
            // Gral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 494);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttoniN);
            this.Controls.Add(this.Pasword);
            this.Controls.Add(this.pasw);
            this.Controls.Add(this.User);
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
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label pasw;
        private System.Windows.Forms.TextBox Pasword;
        private System.Windows.Forms.Button buttoniN;
        private System.Windows.Forms.Button buttonS;
    }
}

