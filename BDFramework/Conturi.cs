using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFramework
{[  
    Table("Conturi")]
    public class Conturi
    {

        
            public int ID { get; set; }
            public string Cont {  get; set; }

            public string Parola { get; set; }

            public int Nivel { get; set; }
        }
        public class ConturiDbContext : DbContext
        {
            public ConturiDbContext() : base("name=MagazinDbContext")
            { }

            public DbSet<Conturi> Conturis { get; set; }


        }
}
