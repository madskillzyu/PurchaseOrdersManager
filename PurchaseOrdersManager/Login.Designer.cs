namespace PurchaseOrdersManager
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.lozinkaValues = new System.Windows.Forms.TextBox();
            this.korisnickoImeValue = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 263);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinka.Location = new System.Drawing.Point(89, 388);
            this.labelLozinka.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(95, 32);
            this.labelLozinka.TabIndex = 16;
            this.labelLozinka.Text = "Lozinka";
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoIme.Location = new System.Drawing.Point(89, 293);
            this.labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(172, 32);
            this.labelKorisnickoIme.TabIndex = 15;
            this.labelKorisnickoIme.Text = "Korianičko Ime";
            // 
            // lozinkaValues
            // 
            this.lozinkaValues.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaValues.Location = new System.Drawing.Point(95, 427);
            this.lozinkaValues.Margin = new System.Windows.Forms.Padding(7);
            this.lozinkaValues.Name = "lozinkaValues";
            this.lozinkaValues.PasswordChar = '*';
            this.lozinkaValues.Size = new System.Drawing.Size(419, 39);
            this.lozinkaValues.TabIndex = 14;
            this.lozinkaValues.UseSystemPasswordChar = true;
            // 
            // korisnickoImeValue
            // 
            this.korisnickoImeValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeValue.Location = new System.Drawing.Point(95, 332);
            this.korisnickoImeValue.Margin = new System.Windows.Forms.Padding(7);
            this.korisnickoImeValue.Name = "korisnickoImeValue";
            this.korisnickoImeValue.Size = new System.Drawing.Size(419, 39);
            this.korisnickoImeValue.TabIndex = 13;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(95, 528);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(7);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(419, 57);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Prijavi Se";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.lozinkaValues);
            this.Controls.Add(this.korisnickoImeValue);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.TextBox lozinkaValues;
        private System.Windows.Forms.TextBox korisnickoImeValue;
        private System.Windows.Forms.Button buttonLogin;
    }
}