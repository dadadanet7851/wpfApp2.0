using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Windows;
using System.Windows.Media;

namespace practic_2020 // Я УБРАЛ СООБЩЕНИЕ О ЗАПОЛНЕННОСТИ ПОЛЕЙ ЮЗЕРНЕЙМ И ПАРОЛЬ
{

    public partial class DBConnectionForm : Window
    {
        public DBConnectionForm()
        {
            InitializeComponent();
        }

        private void Notebook_1(object sender, RoutedEventArgs e)
        {
            Server_name_box.Text = "...";
            Name_DB_Box.Text = "...";
            User_Name_Box.Text = "...";
            User_Password_Box.Text = "...";
        }

        private void Notebook_2(object sender, RoutedEventArgs e)
        {
            Server_name_box.Text = "...";
            Name_DB_Box.Text = "...";
            User_Name_Box.Text = "...";
            User_Password_Box.Text = "...";
        }

        private void Button_Click_exit(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow frm = new MainWindow();
            frm.Owner = this;
            frm.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string datasource = Server_name_box.Text;
            string database = Name_DB_Box.Text;
            string username = User_Name_Box.Text;
            string userpass = User_Password_Box.Text;

            if (string.IsNullOrEmpty(datasource) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(database) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButton.OK);
                return;
            }
            // if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(database))
            // {
            //    MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButton.OK);
            //    return;
            //}
            //if (string.IsNullOrEmpty(userpass) || string.IsNullOrEmpty(database))
            //{
            //MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButton.OK);
            //return;
            //}
            if
                (DBConnectionService.DBConnectionService.SetSqlConnection(GetDBConnectionString(datasource, database, username, userpass)))
            {
                MessageBox.Show("Подключено", "Соединение успешно!", MessageBoxButton.OK);
                this.Hide();
                View_Table frm1 = new View_Table();
                frm1.Owner = this;
                frm1.Show();

            }

        }
        public string GetDBConnectionString(string datasource, string database, string username, string password)
        {
            string dataSourceStirng = "Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;";
            if (!string.IsNullOrEmpty(username))
            {
                dataSourceStirng += "User ID=" + username + ";Password=" + password + ";";
            }
            else
            {
                dataSourceStirng += "Integrated Security=SSPI;";
            }
            return dataSourceStirng;
        }

        private void Name_Server_Box_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }

}