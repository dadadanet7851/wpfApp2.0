using System;
using System.Text;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Diagnostics;
using Color = System.Windows.Media.Color;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Windows.Data;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Navigation;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Drawing;


namespace practic_2020
{
    public partial class View_Table : Window
    {
        public View_Table()
        {
            InitializeComponent();
        }
        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow frm1 = new MainWindow();
            frm1.Owner = this;
            frm1.Show();
        }

        private void Button_Click_podrobnee(object sender, RoutedEventArgs e)
        {
            var information = new StringBuilder();
            information.AppendLine("Модуль подключения базы данных");
            MessageBox.Show(information.ToString());
        }
        private void Button_Click_fon(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Background = brush;
        }


        private void Arenda_View(object sender, RoutedEventArgs e)
        {

        }
    }
}