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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Kart_Skills_2017
{
    /// <summary>
    /// Логика взаимодействия для Timer.xaml
    /// </summary>
    public partial class Timer : UserControl
    {
        public Timer()
        {
            InitializeComponent();
            TimerOnKarting_TargetUpdated();
        }

        private DispatcherTimer timer;
        private DateTime dateTime = new DateTime(2056, 9, 22, 1, 59, 59);
        //public void StartTime()
        //{
        //    timer = new DispatcherTimer();
        //    timer.Interval = new TimeSpan(0, 0, 1);
        //    TimeSpan different = dateTime.Subtract(DateTime.Now);
        //    TimerOnKarting.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут {different.Seconds} секунд до старта марафона!";
        //}

        private void TimerOnKarting_TargetUpdated()
        {
            timer = new DispatcherTimer();
            TimeSpan timeSpan = dateTime.Subtract(DateTime.Now);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerOnKarting.Text = $" До начала события осталось: {dateTime.Year - DateTime.Now.Year} лет, {Math.Abs(dateTime.Month- DateTime.Now.Month)} месяцев, {Math.Abs(dateTime.Day - DateTime.Now.Day)} дней, {Math.Abs(dateTime.Hour - DateTime.Now.Hour)} часов, {Math.Abs(dateTime.Minute - DateTime.Now.Minute)} минут и {Math.Abs(dateTime.Second - DateTime.Now.Second)} секунд";
        }
    }
}
