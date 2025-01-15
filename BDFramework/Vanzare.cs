﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFramework
{
    public partial class Vanzare : Form
    {
        Produs produs;
        public Vanzare(Produs produs)
        {
            InitializeComponent();

            this.produs=produs;

            lblID.Text= lblID.Text+produs.Id.ToString();
            lblNume.Text= lblNume.Text+produs.Denumire.ToString();
            lblDescriere.Text = lblDescriere.Text + produs.Descriere.ToString();
            lblIntrare.Text = lblIntrare.Text + produs.DataIntrarii.ToString();
            lblIesire.Text = lblIesire.Text + produs.DataExpirarii.ToString();
            lblCantitate.Text = "Cantitate:" + produs.Cantitate.ToString();

        }


        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private async Task vizualizareAsync()
        {
            if (nrVanzare.Value <= produs.Cantitate)
            {
                lblRezultat.Visible = true;
                lblRezultat.Text = "Au fost vandute " + nrVanzare.Value.ToString() + " produse.";
                produs.Cantitate -= (int)nrVanzare.Value;
                lblCantitate.Text = "Cantitate:" + produs.Cantitate.ToString();
                if((int)nrVanzare.Value>0)
                    using (ComandaDbContext ctx = new ComandaDbContext())
                    {
                        Comanda comanda = new Comanda();
                        comanda.Denumire = produs.Denumire;
                        comanda.Cantitate = (int)nrVanzare.Value;
                        DateTime currentDateTime = DateTime.Now;
                        comanda.Data = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                        ctx.Comenzi.Add(comanda);
                        ctx.SaveChanges();
                    }
            }
            if (produs.Cantitate > 0)
            {
                using (ComenziDbContext ctx = new ComenziDbContext())
                {
                    var produsnou = ctx.Produse.FirstOrDefault(o => o.Id == produs.Id);
                    if (produsnou != null)
                    {
                        produsnou.Cantitate = produs.Cantitate;
                    }
                    ctx.SaveChanges();
                }
            }
            else
            {
                using (ComenziDbContext ctx = new ComenziDbContext())
                {
                    var produsdesters = ctx.Produse.FirstOrDefault(o => o.Id == produs.Id);
                    if (produsdesters != null)
                    {
                        ctx.Produse.Remove(produsdesters);
                    }
                    ctx.SaveChanges();
                }
            }
        }
        private async void BtnVanzare_Click(object sender, EventArgs e)
        {
            await vizualizareAsync();

        }

        private async Task adaugareAsync()
        {
            if (nrVanzare.Value > 0)
            {
                using (ComenziDbContext ctx = new ComenziDbContext())
                {
                    var produsnou = ctx.Produse.FirstOrDefault(o => o.Id == produs.Id);
                    if (produsnou != null)
                    {
                        produsnou.Cantitate += (int)nrVanzare.Value;
                        produs.Cantitate += (int)nrVanzare.Value;
                    }
                    ctx.SaveChanges();
                }
                lblRezultat.Text = "Au fost adaugate " + nrVanzare.Value.ToString() + " produse.";
                lblCantitate.Text = "Cantitate:" + produs.Cantitate.ToString();
                lblRezultat.Visible = true;

            }
        }

        private async void btnAdaugare_Click(object sender, EventArgs e)
        {
            await adaugareAsync();
        }
    }
}
