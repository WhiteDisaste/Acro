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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acro.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DoxodMagazine.xaml
    /// </summary>
    public partial class DoxodMagazine : Page
    {
        public DoxodMagazine()
        {
            InitializeComponent();
           viewLV.ItemsSource = Connect.entities.Magazin.ToList();
        }



        private void sort_btn_Click(object sender, RoutedEventArgs e)
        {
            decimal low_price = Convert.ToDecimal(low_price_tb.Text);
            decimal high_price = Convert.ToDecimal(high_price_tb.Text);

            

            viewLV.ItemsSource = Connect.entities.Magazin.Where(i => i.StartDoxod <= high_price && i.EndDoxod >= low_price
            )
               .OrderByDescending(i => i.StartDoxod).ToList();
        }
    }
}
