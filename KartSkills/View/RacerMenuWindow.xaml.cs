using System;
using System.Windows;
using System.Windows.Threading;
using KartSkills.Global;
using KartSkills.View.Dialogs;

namespace KartSkills.View
{
    /// <summary>
    /// Логика взаимодействия для RacerMenuWindow.xaml
    /// </summary>
    public partial class RacerMenuWindow : Window
    {
        public RacerMenuWindow()
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

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.OpenNewWindow(new MainWindow());
            Close();
        }

        private void Contacts_Click(object sender, RoutedEventArgs e)
        {
            var contact = new ContactsWindow();
            contact.ShowDialog();
        }

        private void RaceRegiseter_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.OpenNewWindow(new RaceRegisterWindow());
            Close();
        }

        private void ProfileEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.OpenNewWindow(new ProfileEditWindow());
            Close();
        }
    }
}
