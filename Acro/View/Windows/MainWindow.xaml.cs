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
            var usr = Connect.entities.login.Where(i => i.login1 == login_tbx.Text && i.password == password_pbx.Password).FirstOrDefault();

            if (usr != null)
            {
                if (usr.role == "rent")
                {
                    MessageBox.Show($"вы вошли как менеджер по аренде");
                    ViewMarket r = new ViewMarket();
                    r.Show();
                    this.Close();
                }
                else if (usr.role == "market")
                {
                    MessageBox.Show($"вы вошли как менеджер по продажам");
                    Add a = new Add();
                    a.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("ты кто такой?!");
            }
        }
    }
}
