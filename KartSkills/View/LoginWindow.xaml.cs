using System;
using System.Data;
using System.Windows;
using System.Windows.Threading;
using KartSkills.Global;
using Microsoft.Data.SqlClient;

namespace KartSkills.View
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private DispatcherTimer timer;
        private DateTime startDate = new DateTime(2023, 6, 19, 23, 59, 59);

        private void StartWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += (o, args) =>
            {
                TextTimer.Text =
                    $"До начала событий осталось: {startDate.Year - DateTime.Now.Year} лет, {Math.Abs(startDate.Month - DateTime.Now.Month) } месяцев, " +
                    $"{Math.Abs(startDate.Day - DateTime.Now.Day)} дней, {Math.Abs(startDate.Hour - DateTime.Now.Hour)} часов, {Math.Abs(startDate.Minute - DateTime.Now.Minute)} минут и " +
                    $"{Math.Abs(startDate.Second - DateTime.Now.Second)} секунд.";
            };
            timer.Start();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.OpenNewWindow(new MainWindow());
            Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            DataTable table = SqlHelper.GetTableFromSql($"select * from [User] where [Email] = '{TextEmail.Text}' and [Password] = '{TextPassword.Text}'");

            if (table.Rows.Count != 0)
            {
                if (table.Rows[0][4].ToString() == "R")
                {
                    WindowHelper.OpenNewWindow(new RacerMenuWindow());
                    Close();
                }
                if (table.Rows[0][4].ToString() == "C")
                {
                    WindowHelper.OpenNewWindow(new CoordinatorMenuWindow());
                    Close();
                }
                if (table.Rows[0][4].ToString() == "A")
                {
                    WindowHelper.OpenNewWindow(new AdminMenuWindow());
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
