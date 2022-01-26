using ClassLibrary;
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
using WPF.Frames.Manager;

namespace WPF.Frames.Salesman
{
    /// <summary>
    /// Логика взаимодействия для P_orders_update.xaml
    /// </summary>
    public partial class P_orders_update : Page
    {
        private Order order;
        P_orders p_or;

        public P_orders_update(Order or, P_orders p_ord)
        {
            InitializeComponent();
            order = or;
            p_or = p_ord;

            TB_id.Text = Convert.ToString(or.IdOrder);
            TB_Status.Text = or.IdOrderStatus;
            TB_PhNumb.Text = or.PhoneNumber;
            TB_IdClient.Text = Convert.ToString(or.IdClient);
            TB_Adress.Text = or.Address;
            TB_Date.Text = Convert.ToString(or.OrderDate);
        }
        private void B_update(object sender, RoutedEventArgs e)
        {
            if (TB_id.Text != "" &&
               TB_Status.Text != "" &&
               TB_PhNumb.Text != "" &&
               TB_IdClient.Text != "" &&
               TB_Adress.Text != "" &&
               TB_Date.Text != ""
                )
            {
                Order ordr = Order.GetOrder(order.IdOrder);
                ordr.IdOrder = Convert.ToInt32(TB_id.Text);
                ordr.OrderDate = Convert.ToDateTime(TB_Date.Text);
                ordr.PhoneNumber = TB_PhNumb.Text;
                ordr.Address = TB_Adress.Text;
                ordr.IdClient = Convert.ToInt32(TB_IdClient.Text);
                ordr.IdOrderStatus = TB_Status.Text;

                Context.Db2.SaveChanges();
                MessageBox.Show("Сохранения применены");
                p_or.Refresh();
            }
            else
            MessageBox.Show("Не все поля заполнены");
        }
        private void InputOnlyNumbs(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        bool del = false;
        private void B_delete(object sender, RoutedEventArgs e)
        {
            Order ordr = Order.GetOrder(order.IdOrder);
            switch (del)
            {
                case false:
                    MessageBox.Show("Повторное нажатие на кнопку УДАЛИТ заказ");
                    del = true;
                    break;
                default:
                    MessageBox.Show("Товар удален");
                    Context.Db2.Orders.Remove(ordr);
                    Context.Db2.SaveChanges();
                    p_or.Refresh();
                    break;
            }
        }
    }
}
