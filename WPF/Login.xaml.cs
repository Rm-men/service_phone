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
using WPF.Frames.User;
using WPF.Frames.Manager;
using WPF.Frames.Admin;
using ClassLibrary;
using System.Security.Cryptography;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public ICollection<EmployeeOfCompany> Employees { get; set; }


        public Window1()
        {
            InitializeComponent();
        }
        public void Enter_admin()
        {
            main_w_admin main_W = new main_w_admin();
            main_W.Show();
            this.Close();
        }
        public void Enter_manager()
        {
            ManagerW mngr_W = new ManagerW();
            mngr_W.Show();
            this.Close();
        }        
        public void Enter_user()
        {
            UserW user_W = new UserW();
            user_W.Show();
            this.Close();
        }

        public void click(object sender, RoutedEventArgs e)
        {
        #warning Пароли не захэшированы!

            EmployeeOfCompany employee = EmployeeOfCompany.GetEmployee(TextBoxLogin.Text.Trim(), paswordbox.Password.Trim());
            if (employee != null)
            {
                switch (employee.IdEmployeeType)
                {
                    case "main_1":
                        Enter_admin();
                        break;
                    case "mngr_logistic_1":
                        Enter_manager();
                        break;
                    default:
                        Enter_user();
                        break;
                }
 
            }
            else MessageBox.Show("Введен неверный логин или пароль.");
        }
        private static string GetHash(string input)
        {
            byte[] data = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void Clikc_a(object sender, RoutedEventArgs e)
        {
            Enter_admin();
        }

        private void Click_m(object sender, RoutedEventArgs e)
        {
            Enter_manager();
        }

        private void Click_u(object sender, RoutedEventArgs e)
        {
            Enter_user();
        }
    }
}
