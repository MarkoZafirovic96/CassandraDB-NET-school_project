using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;

namespace Skola
{
    public partial class DodajCasForm : Form
    {
        //public int brojac = 0;
        public string id_odeljenja;
        public string id_prof;

        public DodajCasForm()
        {
            InitializeComponent();
        }

        public DodajCasForm(string id, string id_p)
        {
            this.id_odeljenja = id;
            this.id_prof = id_p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datum = dtpDatumCasa.Text;
            string opis = txtOpisCasa.Text;
            string id_casa = txtIdCasa.Text;
            string napomena = txtNapomena.Text;
            Profesor p = DataProvider.VratiProfesora(id_prof);
            if (id_casa == "" || datum == "" || opis == "")
            {
                MessageBox.Show("Niste ueli sve potrebne podatke za cas");
            }
            else
            {
                DataProvider.DodajCas(id_casa, datum, opis, id_prof, p.imeProfesor, p.prezimeProfesor, id_odeljenja, napomena);
                listView1.Items.Add(new ListViewItem(new string[] { datum, opis }));
            }
        }

        private void Popuni_Formu()
        {
            List<Cas> casovi = DataProvider.VratiCasove();
            foreach (Cas c in casovi)
            {
                ListViewItem item = new ListViewItem(new string[] { c.datumCas, c.opisCas });
                listView1.Items.Add(item);
            }
            listView1.Refresh();

            List<Ucenik> ucenici = DataProvider.VratiUcenikeIzOdeljenja(id_odeljenja);
            foreach(Ucenik u in ucenici)
            {
                ListViewItem item = new ListViewItem(new string[] {u.ucenikID, u.imeUcenik,u.prezimeUcenik });
                listViewOdsutni.Items.Add(item);
            }
            listViewOdsutni.Refresh();
        }

        private void DodajCasForm_Load(object sender, EventArgs e)
        {
            this.Popuni_Formu();
        }

        private void btnUpisisIzostanke_Click(object sender, EventArgs e)
        {
            if (listViewOdsutni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte ucenika koji nije na casu");
            }
            else
            {
                string s2 = listViewOdsutni.SelectedItems[0].SubItems[1].Text;
                string s3 = listViewOdsutni.SelectedItems[0].SubItems[2].Text;

                string s5 = listViewOdsutni.SelectedItems[0].Text;
                string s7 = dtpDatumCasa.Text;
                string izostanak = "Jos uvek nije opravdan";


                DataProvider.DodajIzostanak(txtIdCasa.Text, s7, s2, id_odeljenja, s3, izostanak, s5);
                listViewOdsutni.Items.Remove(listViewOdsutni.SelectedItems[0]);
            }
        }

        private void btnUpisiNapomene_Click(object sender, EventArgs e)
        {
            
        }
    }
}
