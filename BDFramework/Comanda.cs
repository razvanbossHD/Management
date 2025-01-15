using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFramework
{
    [Table ("Istoric")]
    public class Comanda
    {
        public int ID { get; set; }
        public string Denumire { get; set; }

        public int Cantitate { get; set; }

        public string Data { get; set; }
    }
    public class ComandaDbContext : DbContext
    {
        public ComandaDbContext() : base("name=MagazinDbContext")
        { }

        public DbSet<Comanda> Comenzi { get; set; }


    }
}
