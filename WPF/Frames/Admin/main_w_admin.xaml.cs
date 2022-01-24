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
using System.Windows.Shapes;
using WPF.Frames.Manager;

namespace WPF.Frames.Admin
{
    /// <summary>
    /// Логика взаимодействия для main_w.xaml
    /// </summary>
    public partial class main_w_admin : Window
    {
#warning  вынести методы переходов кнопок
        public main_w_admin()
        {
            InitializeComponent();
        }
        public void B_To_Product(object sender, RoutedEventArgs e)
        {
            View_frame.Content = new P_products();
            //this.Close();
        }
        public void B_to_Employees(object sender, RoutedEventArgs e)
        {

        }
        public void B_to_Supply (object sender, RoutedEventArgs e)
        {

        }
        public void B_to_Ordes(object sender, RoutedEventArgs e)
        {

        }
    }
}
