﻿using Acro.Model;
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
    /// Логика взаимодействия для Period.xaml
    /// </summary>
    public partial class Period : Window
    {
        public Period()
        {
            InitializeComponent();
        }
        private void check_period_btn_Click(object sender, RoutedEventArgs e)
        {
            var rent_of_cost = Connect.entities.Magazin.ToList();

            List<string> GAP = new List<string>();

            foreach (Magazin ha in rent_of_cost)
            {
                GAP.Add($"{ha.Name} принесла прибыль в начале периода: {ha.StartDoxod}");
            }

            string final_sting = "";

            foreach (string str in GAP)
            {
                final_sting += str + "\n";
            }

            var summary_price = Connect.entities.Magazin.Sum(o => o.EndDoxod).ToString();

            MessageBox.Show($"{final_sting} \n общая прибыль:{summary_price}");


        }

        private void start_period_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var start_money = (DateTime)start_period.SelectedDate;
        }

        private void end_period_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var end_money = (DateTime)end_period.SelectedDate;
        }

        private void back_to_market_view_btn_Click(object sender, RoutedEventArgs e)
        {           
            this.Close();
        }
    }
}
