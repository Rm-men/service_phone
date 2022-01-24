using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Commands;
using WPF.ViewModels;

namespace WPF.ViewModels
{
    public class LoginViewModel
    {
        public ICollection<EmployeeOfCompany> Employees { get; set; }

        public EmployeeOfCompany? SelectedPersonnel { get; set; }

        public LoginCommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new LoginCommand(this);
        }
    }
}
