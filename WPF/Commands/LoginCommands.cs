using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class LoginCommand : ICommand
    {
        private LoginViewModel _viewModel;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return this._viewModel.SelectedPersonnel != null;
        }

        public void Execute(object? parameter)
        {
            if (_viewModel.SelectedPersonnel == null)
                return;
            var loginwindow = App.Current.Windows[0];
            //BooksViewModel booksViewModel = new BooksViewModel();
            //MainWindow mainWindow = new MainWindow(booksViewModel, _viewModel.SelectedPersonnel);
            // mainWindow.Show();
            loginwindow.Close();
            //MessageBox.Show(_viewModel.SelectedPersonnel.ToString());
        }

        public LoginCommand(LoginViewModel model)
        {
            _viewModel = model;
        }
    }
}
