namespace BDFramework
{
    partial class Form1
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dgvVizualizare = new System.Windows.Forms.DataGridView();
            this.btnCautare = new System.Windows.Forms.Button();
            this.lblCautare = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizualizare)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(544, 179);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(181, 76);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare Produs";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dgvVizualizare
            // 
            this.dgvVizualizare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVizualizare.Location = new System.Drawing.Point(105, 261);
            this.dgvVizualizare.Name = "dgvVizualizare";
            this.dgvVizualizare.Size = new System.Drawing.Size(610, 177);
            this.dgvVizualizare.TabIndex = 1;
            this.dgvVizualizare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVizualizare_CellContentClick);
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(325, 179);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(177, 76);
            this.btnCautare.TabIndex = 3;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // lblCautare
            // 
            this.lblCautare.AutoSize = true;
            this.lblCautare.Location = new System.Drawing.Point(322, 112);
            this.lblCautare.Name = "lblCautare";
            this.lblCautare.Size = new System.Drawing.Size(44, 13);
            this.lblCautare.TabIndex = 4;
            this.lblCautare.Text = "Cautare";
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(384, 109);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(100, 20);
            this.txtCautare.TabIndex = 5;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(116, 179);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(171, 76);
            this.btnAfisare.TabIndex = 6;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.Location = new System.Drawing.Point(116, 97);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(171, 76);
            this.btnComenzi.TabIndex = 7;
            this.btnComenzi.Text = "Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = true;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.lblCautare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.dgvVizualizare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizualizare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dgvVizualizare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Label lblCautare;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnComenzi;
    }
}

