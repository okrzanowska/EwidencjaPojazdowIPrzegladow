namespace EwidencjaPojazdow
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNrRejestracyjny = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRokProdukcji = new System.Windows.Forms.Label();
            this.lblDataPrzegladu = new System.Windows.Forms.Label();
            this.lblWlasciciel = new System.Windows.Forms.Label();
            this.txtNrRejestracyjny = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numRokProdukcji = new System.Windows.Forms.NumericUpDown();
            this.dtpDataPrzegladu = new System.Windows.Forms.DateTimePicker();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.btnDodajPojazd = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.grpDanePojazdu = new System.Windows.Forms.GroupBox();
            this.btnRaport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRokProdukcji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.grpDanePojazdu.SuspendLayout();
            this.SuspendLayout();
            this.lblNrRejestracyjny.AutoSize = true;
            this.lblNrRejestracyjny.Location = new System.Drawing.Point(20, 30);
            this.lblNrRejestracyjny.Name = "lblNrRejestracyjny";
            this.lblNrRejestracyjny.Size = new System.Drawing.Size(85, 13);
            this.lblNrRejestracyjny.TabIndex = 0;
            this.lblNrRejestracyjny.Text = "Nr rejestracyjny:";
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(20, 60);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka:";
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(20, 90);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            this.lblRokProdukcji.AutoSize = true;
            this.lblRokProdukcji.Location = new System.Drawing.Point(20, 120);
            this.lblRokProdukcji.Name = "lblRokProdukcji";
            this.lblRokProdukcji.Size = new System.Drawing.Size(74, 13);
            this.lblRokProdukcji.TabIndex = 3;
            this.lblRokProdukcji.Text = "Rok produkcji:";
            this.lblDataPrzegladu.AutoSize = true;
            this.lblDataPrzegladu.Location = new System.Drawing.Point(20, 150);
            this.lblDataPrzegladu.Name = "lblDataPrzegladu";
            this.lblDataPrzegladu.Size = new System.Drawing.Size(82, 13);
            this.lblDataPrzegladu.TabIndex = 4;
            this.lblDataPrzegladu.Text = "Data przeglądu:";
            this.lblWlasciciel.AutoSize = true;
            this.lblWlasciciel.Location = new System.Drawing.Point(20, 180);
            this.lblWlasciciel.Name = "lblWlasciciel";
            this.lblWlasciciel.Size = new System.Drawing.Size(58, 13);
            this.lblWlasciciel.TabIndex = 5;
            this.lblWlasciciel.Text = "Właściciel:";
            this.txtNrRejestracyjny.Location = new System.Drawing.Point(120, 27);
            this.txtNrRejestracyjny.Name = "txtNrRejestracyjny";
            this.txtNrRejestracyjny.Size = new System.Drawing.Size(150, 20);
            this.txtNrRejestracyjny.TabIndex = 6;
            this.txtMarka.Location = new System.Drawing.Point(120, 57);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(150, 20);
            this.txtMarka.TabIndex = 7;
            this.txtModel.Location = new System.Drawing.Point(120, 87);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 20);
            this.txtModel.TabIndex = 8;
            this.numRokProdukcji.Location = new System.Drawing.Point(120, 117);
            this.numRokProdukcji.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numRokProdukcji.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numRokProdukcji.Name = "numRokProdukcji";
            this.numRokProdukcji.Size = new System.Drawing.Size(150, 20);
            this.numRokProdukcji.TabIndex = 9;
            this.numRokProdukcji.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.dtpDataPrzegladu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrzegladu.Location = new System.Drawing.Point(120, 147);
            this.dtpDataPrzegladu.Name = "dtpDataPrzegladu";
            this.dtpDataPrzegladu.Size = new System.Drawing.Size(150, 20);
            this.dtpDataPrzegladu.TabIndex = 10;
            this.txtWlasciciel.Location = new System.Drawing.Point(120, 177);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(150, 20);
            this.txtWlasciciel.TabIndex = 11;
            this.btnDodajPojazd.Location = new System.Drawing.Point(120, 210);
            this.btnDodajPojazd.Name = "btnDodajPojazd";
            this.btnDodajPojazd.Size = new System.Drawing.Size(150, 30);
            this.btnDodajPojazd.TabIndex = 12;
            this.btnDodajPojazd.Text = "Dodaj pojazd";
            this.btnDodajPojazd.UseVisualStyleBackColor = true;
            this.btnDodajPojazd.Click += new System.EventHandler(this.btnDodajPojazd_Click);
            this.dgvPojazdy.AllowUserToAddRows = false;
            this.dgvPojazdy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPojazdy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Location = new System.Drawing.Point(320, 12);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.ReadOnly = true;
            this.dgvPojazdy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPojazdy.Size = new System.Drawing.Size(560, 426);
            this.dgvPojazdy.TabIndex = 13;
            this.grpDanePojazdu.Controls.Add(this.lblNrRejestracyjny);
            this.grpDanePojazdu.Controls.Add(this.lblMarka);
            this.grpDanePojazdu.Controls.Add(this.lblModel);
            this.grpDanePojazdu.Controls.Add(this.lblRokProdukcji);
            this.grpDanePojazdu.Controls.Add(this.lblDataPrzegladu);
            this.grpDanePojazdu.Controls.Add(this.lblWlasciciel);
            this.grpDanePojazdu.Controls.Add(this.txtNrRejestracyjny);
            this.grpDanePojazdu.Controls.Add(this.txtMarka);
            this.grpDanePojazdu.Controls.Add(this.txtModel);
            this.grpDanePojazdu.Controls.Add(this.numRokProdukcji);
            this.grpDanePojazdu.Controls.Add(this.dtpDataPrzegladu);
            this.grpDanePojazdu.Controls.Add(this.txtWlasciciel);
            this.grpDanePojazdu.Controls.Add(this.btnDodajPojazd);
            this.grpDanePojazdu.Location = new System.Drawing.Point(12, 12);
            this.grpDanePojazdu.Name = "grpDanePojazdu";
            this.grpDanePojazdu.Size = new System.Drawing.Size(290, 260);
            this.grpDanePojazdu.TabIndex = 14;
            this.grpDanePojazdu.TabStop = false;
            this.grpDanePojazdu.Text = "Dane pojazdu";
            this.btnRaport.Location = new System.Drawing.Point(12, 290);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(290, 35);
            this.btnRaport.TabIndex = 15;
            this.btnRaport.Text = "Generuj raport przeglądów (ten miesiąc)";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.grpDanePojazdu);
            this.Controls.Add(this.dgvPojazdy);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ewidencja Pojazdów";
            ((System.ComponentModel.ISupportInitialize)(this.numRokProdukcji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.grpDanePojazdu.ResumeLayout(false);
            this.grpDanePojazdu.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblNrRejestracyjny;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRokProdukcji;
        private System.Windows.Forms.Label lblDataPrzegladu;
        private System.Windows.Forms.Label lblWlasciciel;
        private System.Windows.Forms.TextBox txtNrRejestracyjny;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numRokProdukcji;
        private System.Windows.Forms.DateTimePicker dtpDataPrzegladu;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.Button btnDodajPojazd;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.GroupBox grpDanePojazdu;
        private System.Windows.Forms.Button btnRaport;
    }
}

