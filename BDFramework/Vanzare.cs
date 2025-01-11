using System;
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
            lblCantitate.Text = lblCantitate.Text + produs.Cantitate.ToString();
            nrVanzare.Maximum = produs.Cantitate;

        }


        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void BtnVanzare_Click(object sender, EventArgs e)
        {
            if (nrVanzare.Value <= produs.Cantitate)
            {
                lblRezultat.Visible = true;
                lblRezultat.Text = "Au fost vandute " + produs.Cantitate + " Produse.";
                produs.Cantitate -= (int)nrVanzare.Value;
                lblCantitate.Text = produs.Cantitate.ToString();
            }
            if(produs.Cantitate>0)
            {
                using (ProdusDbContext ctx = new ProdusDbContext())
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
                using (ProdusDbContext ctx = new ProdusDbContext())
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
    }
}
