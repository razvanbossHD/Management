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
using System.Xml.Linq;

namespace BDFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (ProdusDbContext ctx = new ProdusDbContext())
            {
                var res = from s in ctx.Produse
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Descriere,
                              s.DataIntrarii,
                              s.DataExpirarii,
                              s.Cantitate
                          };
                dgvVizualizare.DataSource = res.ToList();
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void dgvVizualizare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            var idselected = dgvVizualizare.Rows[dgvVizualizare.CurrentCell.RowIndex].Cells[0].Value;
            using (ProdusDbContext ctx = new ProdusDbContext())
            {
                Produs produs = ctx.Produse.Find(idselected);
                if (produs != null) {
                    
                    
                    Vanzare vanzare = new Vanzare(produs);
                    vanzare.ShowDialog();
                
                }

            }

        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext ctx = new ProdusDbContext())
            {
                var produs = from p in ctx.Produse
                            where p.Denumire==txtCautare.Text
                            select p;

                dgvVizualizare.DataSource = produs.ToList();

            }
            
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext ctx = new ProdusDbContext())
            {
                var res = from s in ctx.Produse
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Descriere,
                              s.DataIntrarii,
                              s.DataExpirarii,
                              s.Cantitate
                          };
                dgvVizualizare.DataSource = res.ToList();
            }
        }

        private void dgvFiltrare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
