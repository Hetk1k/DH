using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using DH.Views;

namespace DH.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
           /*
           string user, pass;
            user = txtUser.Text;
            pass = txtPassword.Password;

            if(user == "admin" && pass == "admin")
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(user), null);
                
                var mainView = new MainView();
                mainView.Show();
                var loginView = Application.Current.Windows[0];
                loginView.Close();

            }
            else
            {
                MessageBox.Show("error");
            } 
            */
        }
    }
}
