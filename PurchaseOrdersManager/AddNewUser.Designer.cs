namespace PurchaseOrdersManager
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSacuvajKorisnika = new System.Windows.Forms.Button();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.labelPrivilegija = new System.Windows.Forms.Label();
            this.comboBoxPrivilegija = new System.Windows.Forms.ComboBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.listaKorisnika = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSacuvajKorisnika);
            this.panel1.Controls.Add(this.textBoxLozinka);
            this.panel1.Controls.Add(this.textBoxKorisnickoIme);
            this.panel1.Controls.Add(this.labelPrivilegija);
            this.panel1.Controls.Add(this.comboBoxPrivilegija);
            this.panel1.Controls.Add(this.labelLozinka);
            this.panel1.Controls.Add(this.labelKorisnickoIme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 302);
            this.panel1.TabIndex = 2;
            // 
            // buttonSacuvajKorisnika
            // 
            this.buttonSacuvajKorisnika.Location = new System.Drawing.Point(8, 249);
            this.buttonSacuvajKorisnika.Name = "buttonSacuvajKorisnika";
            this.buttonSacuvajKorisnika.Size = new System.Drawing.Size(229, 41);
            this.buttonSacuvajKorisnika.TabIndex = 6;
            this.buttonSacuvajKorisnika.Text = "Dodaj Korisnika";
            this.buttonSacuvajKorisnika.UseVisualStyleBackColor = true;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(4, 103);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(235, 29);
            this.textBoxLozinka.TabIndex = 5;
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(9, 40);
            this.textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(230, 29);
            this.textBoxKorisnickoIme.TabIndex = 4;
            // 
            // labelPrivilegija
            // 
            this.labelPrivilegija.AutoSize = true;
            this.labelPrivilegija.Location = new System.Drawing.Point(4, 141);
            this.labelPrivilegija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrivilegija.Name = "labelPrivilegija";
            this.labelPrivilegija.Size = new System.Drawing.Size(78, 21);
            this.labelPrivilegija.TabIndex = 3;
            this.labelPrivilegija.Text = "Privilegija";
            // 
            // comboBoxPrivilegija
            // 
            this.comboBoxPrivilegija.FormattingEnabled = true;
            this.comboBoxPrivilegija.Items.AddRange(new object[] {
            "Administrator",
            "Korisnik"});
            this.comboBoxPrivilegija.Location = new System.Drawing.Point(4, 166);
            this.comboBoxPrivilegija.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPrivilegija.Name = "comboBoxPrivilegija";
            this.comboBoxPrivilegija.Size = new System.Drawing.Size(235, 29);
            this.comboBoxPrivilegija.TabIndex = 2;
            this.comboBoxPrivilegija.Text = "Korisnik";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(4, 78);
            this.labelLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(63, 21);
            this.labelLozinka.TabIndex = 1;
            this.labelLozinka.Text = "Lozinka";
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(4, 15);
            this.labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(112, 21);
            this.labelKorisnickoIme.TabIndex = 0;
            this.labelKorisnickoIme.Text = "Korisničko Ime";
            // 
            // listaKorisnika
            // 
            this.listaKorisnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listaKorisnika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaKorisnika.FullRowSelect = true;
            this.listaKorisnika.GridLines = true;
            this.listaKorisnika.HideSelection = false;
            this.listaKorisnika.Location = new System.Drawing.Point(247, 0);
            this.listaKorisnika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaKorisnika.Name = "listaKorisnika";
            this.listaKorisnika.Size = new System.Drawing.Size(392, 302);
            this.listaKorisnika.TabIndex = 3;
            this.listaKorisnika.UseCompatibleStateImageBehavior = false;
            this.listaKorisnika.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Korisničko Ime";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lozinka";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Privilegija";
            this.columnHeader3.Width = 434;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 302);
            this.Controls.Add(this.listaKorisnika);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje Naloga";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSacuvajKorisnika;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.Label labelPrivilegija;
        private System.Windows.Forms.ComboBox comboBoxPrivilegija;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.ListView listaKorisnika;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}