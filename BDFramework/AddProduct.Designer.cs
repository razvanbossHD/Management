namespace BDFramework
{
    partial class AddProduct
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
            this.lblDenumire = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDataIntrare = new System.Windows.Forms.Label();
            this.dtpDataIntrare = new System.Windows.Forms.DateTimePicker();
            this.lblDataExpirare = new System.Windows.Forms.Label();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.nrCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnAdaugare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(54, 67);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(52, 13);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(128, 64);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 1;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(54, 107);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(52, 13);
            this.lblDescriere.TabIndex = 2;
            this.lblDescriere.Text = "Descriere";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(128, 104);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(243, 85);
            this.txtDescriere.TabIndex = 3;
            // 
            // lblDataIntrare
            // 
            this.lblDataIntrare.AutoSize = true;
            this.lblDataIntrare.Location = new System.Drawing.Point(54, 217);
            this.lblDataIntrare.Name = "lblDataIntrare";
            this.lblDataIntrare.Size = new System.Drawing.Size(63, 13);
            this.lblDataIntrare.TabIndex = 4;
            this.lblDataIntrare.Text = "Data Intrare";
            // 
            // dtpDataIntrare
            // 
            this.dtpDataIntrare.Location = new System.Drawing.Point(128, 211);
            this.dtpDataIntrare.Name = "dtpDataIntrare";
            this.dtpDataIntrare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataIntrare.TabIndex = 5;
            // 
            // lblDataExpirare
            // 
            this.lblDataExpirare.AutoSize = true;
            this.lblDataExpirare.Location = new System.Drawing.Point(54, 258);
            this.lblDataExpirare.Name = "lblDataExpirare";
            this.lblDataExpirare.Size = new System.Drawing.Size(71, 13);
            this.lblDataExpirare.TabIndex = 6;
            this.lblDataExpirare.Text = "Data Expirare";
            // 
            // dtpDataExpirare
            // 
            this.dtpDataExpirare.Location = new System.Drawing.Point(128, 258);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataExpirare.TabIndex = 7;
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(54, 305);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(49, 13);
            this.lblCantitate.TabIndex = 8;
            this.lblCantitate.Text = "Cantitate";
            // 
            // nrCantitate
            // 
            this.nrCantitate.Location = new System.Drawing.Point(128, 305);
            this.nrCantitate.Name = "nrCantitate";
            this.nrCantitate.Size = new System.Drawing.Size(120, 20);
            this.nrCantitate.TabIndex = 9;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAdaugare.Location = new System.Drawing.Point(309, 345);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(199, 93);
            this.btnAdaugare.TabIndex = 10;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.nrCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.dtpDataExpirare);
            this.Controls.Add(this.lblDataExpirare);
            this.Controls.Add(this.dtpDataIntrare);
            this.Controls.Add(this.lblDataIntrare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblDenumire);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nrCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblDataIntrare;
        private System.Windows.Forms.DateTimePicker dtpDataIntrare;
        private System.Windows.Forms.Label lblDataExpirare;
        private System.Windows.Forms.DateTimePicker dtpDataExpirare;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.NumericUpDown nrCantitate;
        private System.Windows.Forms.Button btnAdaugare;
    }
}