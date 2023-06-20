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
    /// Логика взаимодействия для AddMagazine.xaml
    /// </summary>
    public partial class AddMagazine : Page
    {
        
        public AddMagazine()
        {

            InitializeComponent();
            txtstatus.ItemsSource = Connect.entities.Status.ToList();
        }

        private void add_new_record_button_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtname.Text))
                mes += "Введите имя\n";
            if (string.IsNullOrWhiteSpace(txtdescrip.Text))
                mes += "Введите описание магазина\n";

            if (string.IsNullOrWhiteSpace(txtvlad.Text))
                mes += "Введите владельца\n";

            if (string.IsNullOrWhiteSpace(txtstatus.Text))
                mes += "Выберите статус\n";

            if (string.IsNullOrWhiteSpace(ya_kalendar.Text))
                mes += "Введите дату создания \n";
           
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Magazin magazin = new Magazin()
                {
                    Name = txtname.Text,
                    Description = txtdescrip.Text,
                    Vladelez = txtvlad.Text,
                    Status = txtstatus.SelectedItem as Status,
                    DateCreate = Convert.ToDateTime(ya_kalendar.Text)
                };


                Connect.entities.Magazin.Add(magazin);
                Connect.entities.SaveChanges();
                MessageBox.Show("запись создана успешно!");
            txtname.Text = "";
            txtdescrip.Text = "";
            txtvlad.Text = "";
            txtstatus.Text = "";
            ya_kalendar.Text = "";



        }
    }
}
