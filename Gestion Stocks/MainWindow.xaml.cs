using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestion_Stocks
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
                


        
        public MainWindow()
        {
            InitializeComponent();

            var context = new GSContext();
            
            /*var articles = from a in context.produits
                           join r in context.ref_produit
                           on a.id_article
                           equals r.id_produit
                           join f in context.fournisseurs
                           on r.id_fournisseur
                           equals f.id_fournisseur
                           select new
                           {
                               r.reference,
                               f.nom_fournisseur,
                               a.designation,
                               a.conditionnement,
                               a.stock,
                               a.stock_mini
                           };
             */
            var articles = from a in context.produits
                           join c in context.categories
                           on a.id_categorie
                          equals c.id_categorie
                           select new
                           {
                               a.designation,
                               a.conditionnement,
                               a.stock,
                               a.stock_mini,
                               c.nom_categorie
                           };


            this.listeArticles.ItemsSource = articles.ToList();



            }



    }

    public class listeArticles : DataGrid
    {

        public DataTemplateSelector CellTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(CellTemplateSelectorProperty); }
            set { SetValue(CellTemplateSelectorProperty, value); }
        }

        public static readonly DependencyProperty CellTemplateSelectorProperty =
            DependencyProperty.Register("Selector", typeof(DataTemplateSelector), typeof(listeArticles),
            new FrameworkPropertyMetadata(null));



        protected override void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Cancel = true;
            Columns.Add(new DataGridTemplateColumn
            {
                Header = e.Column.Header,
                CellTemplateSelector = CellTemplateSelector
            });
        }
    }
 
}
