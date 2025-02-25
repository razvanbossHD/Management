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
        public int Nivel = 1;
        public Form1()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();

            if (this.Nivel > 0)
            {
                this.btnAdaugare.Visible = false;
                this.btnComenzi.Visible = false;
            }
            using (ComenziDbContext ctx = new ComenziDbContext())
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

        private async Task Vizualizareasync()
        {
            var idselected = dgvVizualizare.Rows[dgvVizualizare.CurrentCell.RowIndex].Cells[0].Value;
            using (ComenziDbContext ctx = new ComenziDbContext())
            {
                Produs produs = ctx.Produse.Find(idselected);
                if (produs != null)
                {


                    Vanzare vanzare = new Vanzare(produs);
                    vanzare.ShowDialog();

                }

            }
        }

        private async void dgvVizualizare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            await Vizualizareasync();
        }

        private async Task CautareAsync()
        {
            using (ComenziDbContext ctx = new ComenziDbContext())
            {
                var produs = from p in ctx.Produse
                             where p.Denumire == txtCautare.Text
                             select p;

                dgvVizualizare.DataSource = produs.ToList();

            }
            return;
        }

        private async void btnCautare_Click(object sender, EventArgs e)
        {

            await CautareAsync();

        }
        private async Task AfisareAsync()
        {
            using (ComenziDbContext ctx = new ComenziDbContext())
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

        private async void btnAfisare_Click(object sender, EventArgs e)
        {
            await AfisareAsync();
        }

        private void dgvFiltrare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task ComenziAsync()
        {
            using (ComandaDbContext ctx = new ComandaDbContext())
            {
                var res = from s in ctx.Comenzi
                          select new
                          {
                              s.ID,
                              s.Denumire,
                              s.Cantitate,
                              s.Data,
                          };
                dgvVizualizare.DataSource = res.ToList();
            }
        }

        private async void btnComenzi_Click(object sender, EventArgs e)
        {
            await ComenziAsync();
        }
    }
}
