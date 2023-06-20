﻿using Acro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для ViewMarket.xaml
    /// </summary>
    public partial class ViewMarket : Window
    {
        public ViewMarket()
        {
            InitializeComponent();
            //var status_in_lv = Connect.entities.status.Where(oo => oo.name == "арендована").Select(oo => oo.id).FirstOrDefault();
            //view_market_agent.ItemsSource = Connect.entities.flat.Where(oo => oo.flat_status == status_in_lv).ToList();
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void add_reprice_btn_Click(object sender, RoutedEventArgs e)
        {
            //var selected = ((flat)view_market_agent.SelectedItem).adress;
            //var flat = Connect.entities.flat.Where(u => u.adress == selected).FirstOrDefault();

            //flat.cad_price = Convert.ToDecimal(cadpr_tb.Text);
            //flat.market_price = Convert.ToDecimal(marketpr_tb.Text);
            //flat.rent_price = Convert.ToDecimal(rentpr_tb.Text);

            //Connect.entities.flat.AddOrUpdate(flat);
            //Connect.entities.SaveChanges();
            //MessageBox.Show("расценка успешно обновлена");
        }

        private void view_market_agent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var cadprice_change = Connect.entities.flat.Where(i => i.adress == ((flat)view_market_agent.SelectedItem).adress).Select(i => i.cad_price).FirstOrDefault();
            //var marketprice_change = Connect.entities.flat.Where(i => i.adress == ((flat)view_market_agent.SelectedItem).adress).Select(i => i.market_price).FirstOrDefault();
            //var rentprice_change = Connect.entities.flat.Where(i => i.adress == ((flat)view_market_agent.SelectedItem).adress).Select(i => i.rent_price).FirstOrDefault();

            //cadpr_tb.Text = Convert.ToString(cadprice_change);
            //marketpr_tb.Text = Convert.ToString(marketprice_change);
            //rentpr_tb.Text = Convert.ToString(rentprice_change);
        }

        private void check_money_Click(object sender, RoutedEventArgs e)
        {
            Period p = new Period();
            p.Show();
            this.Close();
        }
    }
}
