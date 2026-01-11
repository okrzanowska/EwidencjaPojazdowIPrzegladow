using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        private DataTable tablePojazdy;

        public Form1()
        {
            InitializeComponent();
            InicjalizujTabelePojazdy();
        }

        private void InicjalizujTabelePojazdy()
        {
            tablePojazdy = new DataTable();
            tablePojazdy.Columns.Add("Nr rejestracyjny", typeof(string));
            tablePojazdy.Columns.Add("Marka", typeof(string));
            tablePojazdy.Columns.Add("Model", typeof(string));
            tablePojazdy.Columns.Add("Rok produkcji", typeof(int));
            tablePojazdy.Columns.Add("Data przeglądu", typeof(DateTime));
            tablePojazdy.Columns.Add("Właściciel", typeof(string));

            dgvPojazdy.DataSource = tablePojazdy;
        }

        private void btnDodajPojazd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNrRejestracyjny.Text))
            {
                MessageBox.Show("Proszę podać numer rejestracyjny.", "Błąd walidacji", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNrRejestracyjny.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Proszę podać markę pojazdu.", "Błąd walidacji", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarka.Focus();
                return;
            }

            DataRow nowyPojazd = tablePojazdy.NewRow();
            nowyPojazd["Nr rejestracyjny"] = txtNrRejestracyjny.Text.Trim();
            nowyPojazd["Marka"] = txtMarka.Text.Trim();
            nowyPojazd["Model"] = txtModel.Text.Trim();
            nowyPojazd["Rok produkcji"] = (int)numRokProdukcji.Value;
            nowyPojazd["Data przeglądu"] = dtpDataPrzegladu.Value.Date;
            nowyPojazd["Właściciel"] = txtWlasciciel.Text.Trim();

            tablePojazdy.Rows.Add(nowyPojazd);

            WyczyscPola();

            MessageBox.Show("Pojazd został dodany pomyślnie.", "Sukces", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WyczyscPola()
        {
            txtNrRejestracyjny.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            numRokProdukcji.Value = DateTime.Now.Year;
            dtpDataPrzegladu.Value = DateTime.Now;
            txtWlasciciel.Clear();
            txtNrRejestracyjny.Focus();
        }
    }
}
