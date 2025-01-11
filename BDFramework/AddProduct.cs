using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFramework
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext ctx = new ProdusDbContext()) {
                Produs p = new Produs();
                p.Denumire = txtDenumire.Text;
                p.Descriere = txtDescriere.Text;
                p.DataIntrarii = dtpDataIntrare.Value.ToString();
                p.DataExpirarii = dtpDataExpirare.Value.ToString();
                p.Cantitate = (int)nrCantitate.Value;

                ctx.Produse.Add(p);
                ctx.SaveChanges();
             }
            this.Close();
        }
    }
}
