namespace Skola
{
    partial class Predmeti
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
            this.txtSifraPredmeta = new System.Windows.Forms.TextBox();
            this.lblSifraPredmeta = new System.Windows.Forms.Label();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifraPredmeta
            // 
            this.txtSifraPredmeta.Location = new System.Drawing.Point(341, 97);
            this.txtSifraPredmeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifraPredmeta.Name = "txtSifraPredmeta";
            this.txtSifraPredmeta.Size = new System.Drawing.Size(176, 22);
            this.txtSifraPredmeta.TabIndex = 0;
            // 
            // lblSifraPredmeta
            // 
            this.lblSifraPredmeta.AutoSize = true;
            this.lblSifraPredmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraPredmeta.Location = new System.Drawing.Point(340, 79);
            this.lblSifraPredmeta.Name = "lblSifraPredmeta";
            this.lblSifraPredmeta.Size = new System.Drawing.Size(173, 17);
            this.lblSifraPredmeta.TabIndex = 1;
            this.lblSifraPredmeta.Text = "Unesite sifru predmeta";
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Location = new System.Drawing.Point(373, 214);
            this.btnDodajPredmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(124, 64);
            this.btnDodajPredmet.TabIndex = 2;
            this.btnDodajPredmet.Text = "Dodaj predmet";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite naziv predmeta";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(344, 160);
            this.txtNazivPredmeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(176, 22);
            this.txtNazivPredmeta.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(81, 76);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(219, 290);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv predmeta";
            this.columnHeader2.Width = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista postojecih predmeta";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(112, 395);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(188, 42);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi predmet";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(373, 300);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(124, 57);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj naziv predmeta";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // Predmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.lblSifraPredmeta);
            this.Controls.Add(this.txtSifraPredmeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Predmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajPredmet";
            this.Load += new System.EventHandler(this.Predmeti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifraPredmeta;
        private System.Windows.Forms.Label lblSifraPredmeta;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}