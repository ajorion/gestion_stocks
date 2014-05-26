using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Stocks
{
    class References
    {
        private string _reference;

        [Key]
        public Int64 id_produit { get; set; }
        public Int64 id_fournisseur { get; set; }

        public string reference
        {
            get { return _reference; }
            set { _reference = value; }
        }


    }
}
