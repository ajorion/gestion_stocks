using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Gestion_Stocks
{
    class Categories
    {

        private string _nom_categorie;

        [Key]
        public int id_categorie { get; set; }


        public string nom_categorie
        {
            get { return _nom_categorie; }
            set { _nom_categorie = value; }
        }

    }
}
