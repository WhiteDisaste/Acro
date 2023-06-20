using Acro.Model;
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

namespace Acro.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtUser.Text))
                mes += "Введите логин\n";
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
                mes += "Выберите пароль\n";

            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
                mes += "Введите телефон\n";
            if (txtPassword.Password != txtPassword2.Password)
                mes += "Пароли не совпадают\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Users accounting = new Users()
            {
                Login = txtUser.Text,
                Password = txtPassword.Password,
                Telephone = txtTelephone.Text
            };
            Connect.entities.Users.Add(accounting);
            Connect.entities.SaveChanges();
            MessageBox.Show("пользователь добавлен");
            txtPassword.Password = "";
            txtUser.Text = "";
            txtTelephone.Text = "";
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
