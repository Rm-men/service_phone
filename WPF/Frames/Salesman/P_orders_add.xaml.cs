using ClassLibrary;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF.Frames.Manager;

namespace WPF.Frames.Salesman
{
    /// <summary>
    /// Логика взаимодействия для P_orders_add.xaml
    /// </summary>
    public partial class P_orders_add : Page
    {
        P_orders prod;
        public P_orders_add(P_orders pr)
        {
            prod = pr;
            InitializeComponent();
            TB_Status.Text = "s_5";
            TB_Date.Text = Convert.ToString(DateTime.Now);
        }
        private void InputOnlyNumbs(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void B_add(object sender, RoutedEventArgs e)
        {
            if (TB_id.Text != "" &&
              TB_Status.Text != "" &&
              TB_PhNumb.Text != "" &&
              TB_IdClient.Text != "" &&
              TB_Adress.Text != "" &&
              TB_Date.Text != ""
               )
            {
                try
                {
                    if (Client.FindClient(TB_cl_Phone.Text, TB_cl_email.Text) == null)
                    {
                        Context.Db2.Clients.Add(
                            new Client
                            {
                                IdClient = Convert.ToInt32(TB_IdClient.Text),
                                Name = TB_cl_Name.Text,
                                Family = TB_cl_Family.Text,
                                Patronymic = TB_cl_Patron.Text,
                                Phone = TB_cl_Phone.Text,
                                Email = TB_cl_email.Text,
                            });
                    }
                    else
                    {

                    }
                    Context.Db2.Orders.Add(new Order
                    {
                        IdOrder = Convert.ToInt32(TB_id.Text),
                        OrderDate = Convert.ToDateTime(TB_Date.Text),
                        PhoneNumber = TB_PhNumb.Text,
                        Address = TB_Adress.Text,
                        IdClient = Convert.ToInt32(TB_IdClient.Text),
                        IdOrderStatus = TB_Status.Text,
                    });

                    Context.Db2.SaveChanges();
                    MessageBox.Show("Заказ добавлен!");
                    prod.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка заноса данных: " + ex.Message);
                }
            }
            else MessageBox.Show("Не все поля заполнены");
        }

        private void B_fing_Client(object sender, RoutedEventArgs e)
        {
            Client cl = Client.FindClient(TB_cl_Phone.Text, TB_cl_email.Text);
            if (cl != null)
            {
                TB_cl_id.Text = Convert.ToString(cl.IdClient);
                TB_cl_Name.Text = cl.Name;
                TB_cl_Family.Text = cl.Family;
                TB_cl_Patron.Text = cl.Patronymic;
                TB_cl_Phone.Text = cl.Phone;
                TB_cl_email.Text = cl.Email;

                TB_PhNumb.Text = cl.Phone;
                TB_IdClient.Text = Convert.ToString(cl.IdClient);
            }
            else MessageBox.Show("Клиент не найден");
        }

    }

}
