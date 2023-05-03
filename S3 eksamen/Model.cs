using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_eksamen
{
    public class Model : DbContext
    {
        public DbSet<Bog> Bøger { get; set; }
        public DbSet<Lån> Lånte { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Boghandler; Trusted_Connection = True; ");
        }

        public class Bog
        {
            public int Id { get; set; }
            public string Forfatter { get; set; }
            public string Titel { get; set; }
            public string Udgiver { get; set; }
            public int Eksemplarer { get; set; }
            public int ISBN { get; set; }

        }

        public class Lån
        {
            public int Id { get; set; }
            public int Dato { get; set; }
            public string Låner { get; set; }
            public string LånteBog { get; set; }
            public int Antal { get; set; }
        }
    }
}
