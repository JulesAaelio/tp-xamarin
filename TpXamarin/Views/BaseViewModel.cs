using System.ComponentModel;
using System.Threading.Tasks;
using TpXamarin.Services;

namespace TpXamarin.Views
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; }

        public BaseViewModel()
        {
            this.NavigationService = new NavigationService();
        }

        public void OnPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
        
    }
}