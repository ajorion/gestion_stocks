using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Stocks
{
    class Fournisseurs
    {
        private string _nom_fournisseur;

        [Key]
        public int id_fournisseur { get; set; }

        public string nom_fournisseur
        {
            get { return _nom_fournisseur; }
            set { _nom_fournisseur = value; }
        }
    }
}
