using System;
using System.Windows;
using System.Windows.Threading;

namespace KartSkills.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private DateTime startDate = new DateTime(2023, 6, 19, 23, 59, 59);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += (o, args) =>
            {
                TextTimer.Text =
                    $"До начала событий осталось: {startDate.Year-DateTime.Now.Year} лет, {Math.Abs(startDate.Month- DateTime.Now.Month) } месяцев, " +
                    $"{Math.Abs(startDate.Day- DateTime.Now.Day)} дней, {Math.Abs(startDate.Hour- DateTime.Now.Hour)} часов, {Math.Abs(startDate.Minute- DateTime.Now.Minute)} минут и " +
                    $"{Math.Abs(startDate.Second- DateTime.Now.Second)} секунд.";
            };
            timer.Start();
        }
    }
}
