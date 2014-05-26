using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Stocks
{
    class Articles
    {
        #region private variables
        private string _designation;
        private string _conditionnement;
        private int _stock;
        private int _stock_mini;
        private bool _stock_final;
        #endregion

        #region public variables
        [Key]
        public Int64 id_article { get; set; }
        
        public Int64 id_categorie { get; set; }
        #endregion


        public string designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public string conditionnement
        {
            get { return _conditionnement; }
            set { _conditionnement = value; }
        }

        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int stock_mini
        {
            get { return _stock_mini; }
            set { _stock_mini = value; }
        }

        public bool stock_final
        {
            get
            {
                if (_stock_mini > _stock)
                {
                    return false;
                }
                return true;
            }

        }
        
    }
}
