﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace Skola
{
    public partial class RazredniOceneFormVladanje : Form
    {
        public Ucenik ucenik;

        public RazredniOceneFormVladanje()
        {
            InitializeComponent();
        }

        public RazredniOceneFormVladanje(Ucenik uc)
        {
            this.ucenik = uc;
            InitializeComponent();
        }

        private void RazredniOceneForm_Load(object sender, EventArgs e)
        {
            string uspeh = "Uspeh: ";
            int br = 0;
            double sum = 0;
            double prosek = 0;
            bool nedovoljan = false;
            lblIme.Text = ucenik.imeUcenik;
            lblPrezime.Text = ucenik.prezimeUcenik;
            List<OdeljenjeSlusaPredmet> predmeti = DataProvider.VratiPredmeteZaOdeljenje(ucenik.odeljenjeID);
            foreach (OdeljenjeSlusaPredmet osp in predmeti)
            {
                Ocene oc = DataProvider.VratiOcenu(osp.predmetID, ucenik.ucenikID);
                ListViewItem item = new ListViewItem(new string[] { osp.nazivPredmeta, oc.test1, oc.test2, oc.test3, oc.test4, oc.prosek, oc.zakljucnaOcena });
                listView1.Items.Add(item);
                if (oc.zakljucnaOcena != String.Empty && oc.zakljucnaOcena != null)
                {
                    br++;
                    sum += Double.Parse(oc.zakljucnaOcena);
                    if (oc.zakljucnaOcena.Equals("1"))
                    {
                        nedovoljan = true;
                    }
                }
            }
            if (br == predmeti.Count)
            {
                

                if (nedovoljan)
                {
                    uspeh += " ";
                    uspeh += "(Nedovoljan)";
                }
                else
                {
                    prosek = (sum + Double.Parse(ucenik.vladanje)) / (double)(predmeti.Count + 1);
                    uspeh += prosek.ToString();

                    if (prosek >= 4.5 && prosek <= 5.0)
                    {
                        uspeh += " ";
                        uspeh += "(Odlican)";

                    }
                    else if (prosek >= 3.5 && prosek < 4.5)
                    {
                        uspeh += " ";
                        uspeh += "(Vrlo dobar)";
                    }
                    else if (prosek >= 2.5 && prosek < 3.5)
                    {
                        uspeh += " ";
                        uspeh += "(Dobar)";
                    }
                    else if (prosek >= 2.0 && prosek < 2.5)
                    {
                        uspeh += " ";
                        uspeh += "(Dovoljan)";
                    }

                }
                
            }

            List<Izostanak> listaIzostanka = DataProvider.VratiIzostankeZaUcenika(ucenik.ucenikID);
            int opravdani = 0,neopravdani = 0;
            foreach(Izostanak i in listaIzostanka)
            {
                if (i.tip == "Opravdani")
                    opravdani++;
                else if (i.tip == "Neopravdani")
                    neopravdani++;
                else
                {
                    
                    ListViewItem izostanak = new ListViewItem(new string[] {i.datumIzostanak });
                    listViewIzostanci.Items.Add(izostanak);
                }
            }

            lblUspeh.Text = uspeh;
            lblOpravdani.Text = "Opravdani " + opravdani.ToString();
            lblNeopravdani.Text = "Neopravdani" + neopravdani.ToString();
            lblVladanje.Text = "Vladanje: " + ucenik.vladanje;
        }

        private void btnSmanji_Click(object sender, EventArgs e)
        {
            if (ucenik.vladanje == "1")
                return;
            ucenik.vladanje = (Int32.Parse(ucenik.vladanje) - 1).ToString();
            DataProvider.AzurirajOcenuIzVladanja(ucenik.ucenikID, ucenik.vladanje);
            lblVladanje.Text = "Vladanje " + ucenik.vladanje;
        }

        private void btnPovecaj_Click(object sender, EventArgs e)
        {
            if (ucenik.vladanje == "5")
                return;
            ucenik.vladanje = (Int32.Parse(ucenik.vladanje) + 1).ToString(); 
            DataProvider.AzurirajOcenuIzVladanja(ucenik.ucenikID, ucenik.vladanje);
            lblVladanje.Text = "Vladanje " + ucenik.vladanje;
        }
    }
}
