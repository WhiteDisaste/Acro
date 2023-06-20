using Acro.View.Pages;
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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AddProizvoditel_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new ViewMagazine());
        }

        private void ToverBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new DoxodMagazine());
        }

        private void SotrudBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new AddMagazine());
        }

        

        private void OtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new ViewMarkets());
        }

        private void PeriodBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
