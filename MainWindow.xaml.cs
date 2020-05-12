using System;
using System.Text;
using System.Windows;
using System.IO;
using NLog;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Diagnostics;
using Color = System.Windows.Media.Color;
using System.Collections.Generic;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;


namespace practic_2020
{

    public partial class MainWindow : Window
    {
        private void Button_Click_Op(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            TextBox tb = new TextBox();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                tb.Text = File.ReadAllText(openFileDialog.FileName);
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Запущено");
            logger.Info(Prefix_App + "Открыт");

        }

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MainWindow()
        {
            InitializeComponent();
            {
                string Prefix_App = "Приложение"; 
                logger.Info(Prefix_App + "Запуск");
            }
            StackPanel sp2 = new StackPanel();
            TextBox tb2 = new TextBox();
            sp2.Children.Add(tb2);
            stackPanelAdd.Children.Add(sp2);                                                     
        }

        private void Button_Click_Cl(object sender, RoutedEventArgs e)
        {

            string Prefix_App = "Приложение";
            if (stackPanelAdd.Children.Count > 0)
            {
                stackPanelAdd.Children.RemoveAt(stackPanelAdd.Children.Count - 1);
                logger.Info(Prefix_App + "Очищено");
            }
        }

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {

            string Prefix_App = "Приложение";
            Environment.Exit(0);
            logger.Info(Prefix_App+"Закрыто");
        }
        private void Button_Click_avtor(object sender, RoutedEventArgs e)
        {
            string Prefix_App = "Приложение";
            var information = new StringBuilder();
            information.AppendLine("Выполнили:");
            information.AppendLine("Саетягфаров Э.С");
            information.AppendLine("...");
            information.AppendLine("Группа 9ИСП-391к-17");
            information.AppendLine("Проверяют");
            information.AppendLine("Кашина.М.А");
            information.AppendLine("Гурьянова С.В");
            information.AppendLine("Лебедев В.Н");
            MessageBox.Show(information.ToString());
            logger.Info(Prefix_App + "Информация просмотрена");
        }


        private void Button_Click_con(object sender, RoutedEventArgs e)
        {

            string Prefix_App = "Приложение";
            string Prefix = "DBConnection";
            this.Hide();
            DBConnectionForm frm = new DBConnectionForm();
            frm.Owner = this; 
            frm.Show();
            logger.Info(Prefix_App + Prefix+"Открыт");
        }

        private void Site(object sender, RoutedEventArgs e)
        {

            string Prefix_App = "Приложение"; 
            Process.Start("explorer.exe", "https://github.com/Emil1001");
            try
            {
                InitializeComponent();
                logger.Info(Prefix_App + "Успешно перешли на GitHub");
            }
            catch
            {
                logger.Error(Prefix_App + "Ошибка");
                logger.Fatal(Prefix_App + "Ошибка");
            }
        }

        private void Button_Click_Mp(object sender, RoutedEventArgs e)
        {
            MP3_Player taskWindow = new MP3_Player();
            taskWindow.Owner = this;
            taskWindow.Show();
        }

        private void Edit_Fon(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Background = brush;
        }

        private void Button_Click_open_foto(object sender, RoutedEventArgs e)
          {

            string Prefix_Foto = "Модуль открытия фотографий: ";
            logger.Info(Prefix_Foto + "Открытие...");
            StackPanel sp = new StackPanel();
            Image tb = new Image();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                tb.Source = new BitmapImage(new Uri(openDialog.FileName));
                logger.Info(Prefix_Foto+"Успешно");
            }

        }

        private void Setting_size_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 320;
            Application.Current.MainWindow.Height = 240;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 320x240");
        }

        private void Setting_size_2(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 640;
            Application.Current.MainWindow.Height = 360;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 640x360");
        }

        private void Setting_size_3(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 960;
            Application.Current.MainWindow.Height = 540;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 960х540");

        }

        private void Setting_size_4(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1280;
            Application.Current.MainWindow.Height = 720;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 1280×720");
        }

        private void Setting_size_5(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1366;
            Application.Current.MainWindow.Height = 768;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 1366×768");

        }

        private void Setting_size_6(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1600;
            Application.Current.MainWindow.Height = 900;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 1600×900");
        }

        private void Setting_size_7(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1680;
            Application.Current.MainWindow.Height = 1050;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 1680×1050");
        }

        private void Setting_size_8(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1920;
            Application.Current.MainWindow.Height = 1080;
            string Prefix_App = "Приложение";
            logger.Info(Prefix_App + "Размер изменен на 1920×1080");
        }

    }
}
