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

            DodajPrzykladoweDane();

            dgvPojazdy.DataSource = tablePojazdy;
        }

        private void DodajPrzykladoweDane()
        {
            DateTime dzisiaj = DateTime.Now;
            int rok = dzisiaj.Year;
            int miesiac = dzisiaj.Month;

            tablePojazdy.Rows.Add("WA 12345", "Toyota", "Corolla", 2019, new DateTime(rok, miesiac, 5), "Jan Kowalski");
            tablePojazdy.Rows.Add("KR 98765", "Volkswagen", "Golf", 2020, new DateTime(rok, miesiac, 12), "Anna Nowak");
            tablePojazdy.Rows.Add("GD 55555", "Ford", "Focus", 2018, new DateTime(rok, miesiac, 20), "Piotr Wiśniewski");
            tablePojazdy.Rows.Add("PO 11111", "Skoda", "Octavia", 2021, new DateTime(rok, miesiac, 25), "Maria Kowalczyk");
            tablePojazdy.Rows.Add("WR 77777", "Opel", "Astra", 2017, new DateTime(rok, miesiac, 28), "Tomasz Zieliński");

            int nastepnyMiesiac = miesiac == 12 ? 1 : miesiac + 1;
            int rokNastepny = miesiac == 12 ? rok + 1 : rok;
            tablePojazdy.Rows.Add("LU 22222", "BMW", "320d", 2020, new DateTime(rokNastepny, nastepnyMiesiac, 10), "Katarzyna Wójcik");
            tablePojazdy.Rows.Add("SZ 33333", "Audi", "A4", 2019, new DateTime(rokNastepny, nastepnyMiesiac, 15), "Michał Kamiński");

            int poprzedniMiesiac = miesiac == 1 ? 12 : miesiac - 1;
            int rokPoprzedni = miesiac == 1 ? rok - 1 : rok;
            tablePojazdy.Rows.Add("KA 44444", "Mercedes", "C200", 2021, new DateTime(rokPoprzedni, poprzedniMiesiac, 8), "Agnieszka Lewandowska");
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

        private void btnRaport_Click(object sender, EventArgs e)
        {
            if (tablePojazdy.Rows.Count == 0)
            {
                MessageBox.Show("Brak danych do wygenerowania raportu. Dodaj najpierw pojazdy.", 
                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormRaport formRaport = new FormRaport(tablePojazdy);
            formRaport.ShowDialog();
        }
    }
}
