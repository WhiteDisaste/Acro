using Acro.Model;
using Acro.View.Windows;
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
using Menu = Acro.View.Windows.Menu;

namespace Acro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void au_btn_Click(object sender, RoutedEventArgs e)
        {
            var usr = Connect.entities.Users.Where(i => i.Login == login_tbx.Text && i.Password == password_pbx.Password).FirstOrDefault();

            if (usr != null)
            {
                
                    MessageBox.Show($"Добро пожаловать сотрудник");
                    Menu r = new Menu();
                    r.Show();
                    this.Close();
                
            }
            else
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }
    }
}
