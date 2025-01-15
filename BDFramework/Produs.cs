using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BDFramework
{
    [Table("Produs")]
    public class Produs
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string DataIntrarii { get; set; }
        public string DataExpirarii { get; set; }
        public int Cantitate { get; set; }

    }
    public class ComenziDbContext : DbContext
    {
        public ComenziDbContext() : base("name=MagazinDbContext")
        {}

        public DbSet<Produs> Produse { get; set; }


    }
}
