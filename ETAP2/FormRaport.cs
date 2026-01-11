using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EwidencjaPojazdow
{
    public partial class FormRaport : Form
    {
        private DataTable danePojazdy;

        public FormRaport(DataTable tablePojazdy)
        {
            InitializeComponent();
            danePojazdy = tablePojazdy;
            this.Load += FormRaport_Load;
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
            WczytajRaport();
        }

        private void WczytajRaport()
        {
            try
            {
                reportViewer.ProcessingMode = ProcessingMode.Local;
                
                DateTime dzisiaj = DateTime.Now;
                int biezacyMiesiac = dzisiaj.Month;
                int biezacyRok = dzisiaj.Year;

                var pojazdyDoRaportu = danePojazdy.AsEnumerable()
                    .Where(row =>
                    {
                        DateTime dataPrzegladu = row.Field<DateTime>("Data przegl¹du");
                        return dataPrzegladu.Month == biezacyMiesiac && dataPrzegladu.Year == biezacyRok;
                    })
                    .Select(row => new
                    {
                        NrRejestracyjny = row.Field<string>("Nr rejestracyjny"),
                        Marka = row.Field<string>("Marka"),
                        Wlasciciel = row.Field<string>("W³aœciciel"),
                        DataPrzegladu = row.Field<DateTime>("Data przegl¹du")
                    })
                    .OrderBy(p => p.DataPrzegladu)
                    .ToList();

                DataTable tabelaRaportu = new DataTable("PojazdyPrzeglad");
                tabelaRaportu.Columns.Add("NrRejestracyjny", typeof(string));
                tabelaRaportu.Columns.Add("Marka", typeof(string));
                tabelaRaportu.Columns.Add("Wlasciciel", typeof(string));
                tabelaRaportu.Columns.Add("DataPrzegladu", typeof(DateTime));

                foreach (var pojazd in pojazdyDoRaportu)
                {
                    tabelaRaportu.Rows.Add(
                        pojazd.NrRejestracyjny,
                        pojazd.Marka,
                        pojazd.Wlasciciel,
                        pojazd.DataPrzegladu
                    );
                }

                if (tabelaRaportu.Rows.Count == 0)
                {
                    MessageBox.Show(
                        $"Brak pojazdów z przegl¹dem zaplanowanym na {dzisiaj:MMMM yyyy}.",
                        "Informacja",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportEmbeddedResource = "EwidencjaPojazdow.RaportPrzeglady.rdlc";
                reportViewer.LocalReport.DataSources.Add(
                    new ReportDataSource("PojazdyPrzegladDataSet", tabelaRaportu));

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Wyst¹pi³ b³¹d podczas generowania raportu:\n{ex.Message}\n\nStack trace:\n{ex.StackTrace}",
                    "B³¹d",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
