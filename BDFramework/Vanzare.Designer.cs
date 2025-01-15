namespace BDFramework
{
    partial class Vanzare
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.lblIntrare = new System.Windows.Forms.Label();
            this.lblIesire = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.BtnVanzare = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.nrVanzare = new System.Windows.Forms.NumericUpDown();
            this.btnAdaugare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrVanzare)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(137, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(265, 25);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(55, 20);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "Nume:";
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriere.Location = new System.Drawing.Point(12, 60);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(81, 20);
            this.lblDescriere.TabIndex = 3;
            this.lblDescriere.Text = "Descriere:";
            // 
            // lblIntrare
            // 
            this.lblIntrare.AutoSize = true;
            this.lblIntrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrare.Location = new System.Drawing.Point(12, 93);
            this.lblIntrare.Name = "lblIntrare";
            this.lblIntrare.Size = new System.Drawing.Size(99, 20);
            this.lblIntrare.TabIndex = 4;
            this.lblIntrare.Text = "Data Intrare:";
            // 
            // lblIesire
            // 
            this.lblIesire.AutoSize = true;
            this.lblIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIesire.Location = new System.Drawing.Point(12, 131);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(91, 20);
            this.lblIesire.TabIndex = 5;
            this.lblIesire.Text = "Data Iesire:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(12, 168);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(78, 20);
            this.lblCantitate.TabIndex = 6;
            this.lblCantitate.Text = "Cantitate:";
            // 
            // BtnVanzare
            // 
            this.BtnVanzare.Location = new System.Drawing.Point(11, 233);
            this.BtnVanzare.Name = "BtnVanzare";
            this.BtnVanzare.Size = new System.Drawing.Size(75, 23);
            this.BtnVanzare.TabIndex = 7;
            this.BtnVanzare.Text = "Vanzare";
            this.BtnVanzare.UseVisualStyleBackColor = true;
            this.BtnVanzare.Click += new System.EventHandler(this.BtnVanzare_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(205, 210);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(46, 13);
            this.lblRezultat.TabIndex = 8;
            this.lblRezultat.Text = "Rezultat";
            this.lblRezultat.Visible = false;
            // 
            // nrVanzare
            // 
            this.nrVanzare.Location = new System.Drawing.Point(47, 203);
            this.nrVanzare.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nrVanzare.Name = "nrVanzare";
            this.nrVanzare.Size = new System.Drawing.Size(120, 20);
            this.nrVanzare.TabIndex = 9;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(109, 233);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 10;
            this.btnAdaugare.Text = "adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 298);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.nrVanzare);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.BtnVanzare);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.lblIntrare);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblID);
            this.Name = "Vanzare";
            this.Text = "Vanzare";
            ((System.ComponentModel.ISupportInitialize)(this.nrVanzare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Label lblIntrare;
        private System.Windows.Forms.Label lblIesire;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Button BtnVanzare;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.NumericUpDown nrVanzare;
        private System.Windows.Forms.Button btnAdaugare;
    }
}