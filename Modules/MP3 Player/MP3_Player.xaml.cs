using System;   //nlog
using NLog;     //nlog
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;  //для имени модуля
using System.Windows.Controls.Primitives;
using System.Windows.Threading;


namespace practic_2020
{
        public partial class MP3_Player : Window
         {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MP3_Player()
        {
            string Prefix = "MP3";
            try
            {
                InitializeComponent();
                logger.Info(Prefix+"Успешный запуск");
            }
            catch
            {
                logger.Error(Prefix + "Ошибка");
                logger.Fatal(Prefix + "Ошибка");
            }

        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;

        private void Button_ClickOpen(object sender, RoutedEventArgs e)
        {
            string Prefix = "MP3";

            try
            {
                logger.Info(Prefix+"Открытие файла...");
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Multiselect = false,
                    DefaultExt = ".mp3"
                };
                bool? dialogOk = fileDialog.ShowDialog();
                if (dialogOk == true)
                {
                    filename = fileDialog.FileName;
                    FileName.Text = fileDialog.SafeFileName;
                    mediaPlayer.Open(new Uri(filename));
                    logger.Info(Prefix+"Успешно");
                }
            }
            catch
            {
                logger.Error(Prefix + "Ошибка");
                logger.Fatal(Prefix + "Ошибка");
            }

        }
        
        private void Play(object sender, RoutedEventArgs e)
        {
            string Prefix = "MP3";

            mediaPlayer.Play();
            try
            {
                logger.Info(Prefix + "Успешно");
            }
            catch
            {
                logger.Error(Prefix + "Ошибка");
                logger.Fatal(Prefix + "Ошибка");
            }

        }
        private void Pause(object sender, RoutedEventArgs e)
        {
            string Prefix = "MP3";
            mediaPlayer.Pause();
            try
            {
                logger.Info(Prefix + "Ошибка");
            }
            catch
            {
                logger.Error(Prefix + "Ошибка");
                logger.Fatal(Prefix + "Ошибка");
            }
        }
        private void Stop(object sender, RoutedEventArgs e)
        {
            string Prefix = "MP3";
            FileName.Text = "";
            mediaPlayer.Stop();
            try
            {
                logger.Info(Prefix + "Аудио остановлена");
            }
            catch
            {
                logger.Error(Prefix + "Ошибка");
                logger.Fatal(Prefix + "Ошибка");

            }

        }
        private void visible(object sender, RoutedEventArgs e)
        {
            string Prefix = "MP3";
            WindowState = WindowState.Minimized;
            try
            {
                logger.Info(Prefix + "Свёрнут");
            }
            catch
            {
                logger.Error(Prefix + "Ошибка");
                logger.Fatal(Prefix + "Ошибка");
            }
        }
        private void Close_Module(object sender, RoutedEventArgs e)
        {
            string Prefix = "MP3";
            mediaPlayer.Stop();
            logger.Info(Prefix+"Закрыт");
        }
    } 

}
