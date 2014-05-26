using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Gestion_Stocks
{
    class GSContext : DbContext
    {
        public DbSet<Articles> produits { get; set; }
        public DbSet<References> ref_produit { get; set; }
        public DbSet<Fournisseurs> fournisseurs { get; set; }
        public DbSet<Categories> categories { get; set; }
    }
}
