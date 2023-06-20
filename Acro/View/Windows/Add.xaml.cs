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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        //flat f = new flat();
        public Add()
        {
            InitializeComponent();
            //winplace_cb.ItemsSource = Connect.entities.window.ToList();
            //toitype_cb.ItemsSource = Connect.entities.toilet_type.ToList();
            //flat_status.ItemsSource = Connect.entities.status.ToList();
        }

        private void add_new_record_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //f.floor = Convert.ToInt32(floor_tb.Text);
                //f.floor_apart = Convert.ToInt32(floor_apat_tb.Text);
                //f.date_build = (DateTime)ya_kalendar.SelectedDate;
                //f.window_placement = ((window)winplace_cb.SelectedItem).id;
                //f.amount_rooms = Convert.ToInt32(amount_rooms_tb.Text);
                //f.amount_toilet = Convert.ToInt32(amount_toilet_tb.Text);
                //f.toilet_type = ((toilet_type)toitype_cb.SelectedItem).id;
                //f.cad_price = Convert.ToDecimal(cad_price_tb.Text);
                //f.have_cond = conditer_chb.IsChecked;
                //f.market_price = Convert.ToDecimal(market_price_tb.Text);
                //f.rent_price = Convert.ToDecimal(rent_price_tb.Text);
                //f.flat_status = ((status)flat_status.SelectedItem).id;
                //f.adress = adres_tb.Text;



                //Connect.entities.flat.Add(f);
                //Connect.entities.SaveChanges();
                //MessageBox.Show("запись создана успешно!");

                //floor_tb.Text = "";
                //floor_apat_tb.Text = "";
                //ya_kalendar.Text = "";
                //winplace_cb.Text = "";
                //amount_rooms_tb.Text = "";
                //amount_toilet_tb.Text = "";
                //toitype_cb.Text = "";
                //cad_price_tb.Text = "";
                //conditer_chb.IsChecked = false;
                //market_price_tb.Text = "";
                //rent_price_tb.Text = "";
                //flat_status.Text = "";
                //adres_tb.Text = "";
            }
            catch
            {
                MessageBox.Show("неудачно! возникла ошибка");
            }
        }

        private void go_to_view_btn_Click(object sender, RoutedEventArgs e)
        {
            ViewWindow i = new ViewWindow();
            i.Show();
        }
    }
}
