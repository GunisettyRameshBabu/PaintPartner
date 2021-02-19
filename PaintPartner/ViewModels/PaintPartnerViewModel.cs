using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PaintPartner.ViewModels
{
    public class PaintPartnerViewModel : INotifyPropertyChanged
    {
        public HeaderViewModel Header { get; set; }

        public WelcomeScreenViewModel WelcomeScreenViewModel { get; set; }

        private string myBackgroundSlide;

        public string BackGroundSlide
        {
            get => myBackgroundSlide;
            set
            {
                myBackgroundSlide = value;
                OnPropertyChanged("BackGroundSlide");
            }
        }

        public PaintPartnerViewModel()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            //timer.Start();
            Header = new HeaderViewModel();
            BackGroundSlide = "./Resources/BackgroundSlides/Nippon2.jpg";
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            Random random =new Random();
            var randomNum = random.Next( 1,6 );
            BackGroundSlide = "./Resources/BackgroundSlides/Nippon" + randomNum + ".jpg";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
