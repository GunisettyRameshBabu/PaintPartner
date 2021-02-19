using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PaintPartner.ViewModels
{
    public class WelcomeScreenViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
