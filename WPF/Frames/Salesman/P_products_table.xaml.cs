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
using ClassLibrary;
using WPF.Frames.Manager;

namespace WPF.Frames.Salesman
{
    /// <summary>
    /// Логика взаимодействия для P_products_table.xaml
    /// </summary>
    public partial class P_products_table : Page
    {
        P_products prod;
        public P_products_table(P_products pr)
        {
            prod = pr;
            InitializeComponent();
            dataGrid.ItemsSource = Product.GetProducts();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Product product = dataGrid.SelectedValue as Product;
            prod.To_update(product);
/*            W_products_update def_W = new W_products_update(product, this);
            def_W.Show();*/
        }
        public void Refresn()
        {
            dataGrid.ItemsSource = Product.GetProducts();
        }
    }
}
