namespace PurchaseOrdersManager
{
    partial class DatabaseConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConfig));
            this.saveAll = new System.Windows.Forms.Button();
            this.buttonPDFpath = new System.Windows.Forms.Button();
            this.databasePathButton = new System.Windows.Forms.Button();
            this.pdfPathValue = new System.Windows.Forms.TextBox();
            this.databasePathValue = new System.Windows.Forms.TextBox();
            this.pdfPath = new System.Windows.Forms.Label();
            this.databasePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveAll
            // 
            this.saveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAll.Location = new System.Drawing.Point(305, 148);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(200, 34);
            this.saveAll.TabIndex = 13;
            this.saveAll.Text = "Sacuvaj Putanje";
            this.saveAll.UseVisualStyleBackColor = true;
            // 
            // buttonPDFpath
            // 
            this.buttonPDFpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPDFpath.Location = new System.Drawing.Point(697, 108);
            this.buttonPDFpath.Name = "buttonPDFpath";
            this.buttonPDFpath.Size = new System.Drawing.Size(125, 33);
            this.buttonPDFpath.TabIndex = 12;
            this.buttonPDFpath.Text = "Izaberi";
            this.buttonPDFpath.UseVisualStyleBackColor = true;
            // 
            // databasePathButton
            // 
            this.databasePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databasePathButton.Location = new System.Drawing.Point(697, 40);
            this.databasePathButton.Name = "databasePathButton";
            this.databasePathButton.Size = new System.Drawing.Size(125, 33);
            this.databasePathButton.TabIndex = 11;
            this.databasePathButton.Text = "Izaberi";
            this.databasePathButton.UseVisualStyleBackColor = true;
            // 
            // pdfPathValue
            // 
            this.pdfPathValue.Location = new System.Drawing.Point(12, 108);
            this.pdfPathValue.Name = "pdfPathValue";
            this.pdfPathValue.Size = new System.Drawing.Size(678, 33);
            this.pdfPathValue.TabIndex = 10;
            // 
            // databasePathValue
            // 
            this.databasePathValue.Location = new System.Drawing.Point(12, 40);
            this.databasePathValue.Name = "databasePathValue";
            this.databasePathValue.Size = new System.Drawing.Size(678, 33);
            this.databasePathValue.TabIndex = 9;
            // 
            // pdfPath
            // 
            this.pdfPath.AutoSize = true;
            this.pdfPath.Location = new System.Drawing.Point(7, 80);
            this.pdfPath.Name = "pdfPath";
            this.pdfPath.Size = new System.Drawing.Size(251, 25);
            this.pdfPath.TabIndex = 8;
            this.pdfPath.Text = "Putanja do PDF dokumenata";
            // 
            // databasePathLabel
            // 
            this.databasePathLabel.AutoSize = true;
            this.databasePathLabel.Location = new System.Drawing.Point(7, 11);
            this.databasePathLabel.Name = "databasePathLabel";
            this.databasePathLabel.Size = new System.Drawing.Size(148, 25);
            this.databasePathLabel.TabIndex = 7;
            this.databasePathLabel.Text = "Putanja do baze";
            // 
            // DatabaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 192);
            this.Controls.Add(this.saveAll);
            this.Controls.Add(this.buttonPDFpath);
            this.Controls.Add(this.databasePathButton);
            this.Controls.Add(this.pdfPathValue);
            this.Controls.Add(this.databasePathValue);
            this.Controls.Add(this.pdfPath);
            this.Controls.Add(this.databasePathLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DatabaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAll;
        private System.Windows.Forms.Button buttonPDFpath;
        private System.Windows.Forms.Button databasePathButton;
        private System.Windows.Forms.TextBox pdfPathValue;
        private System.Windows.Forms.TextBox databasePathValue;
        private System.Windows.Forms.Label pdfPath;
        private System.Windows.Forms.Label databasePathLabel;
    }
}