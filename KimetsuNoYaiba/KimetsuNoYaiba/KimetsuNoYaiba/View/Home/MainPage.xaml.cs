using Xamarin.Forms;

namespace KimetsuNoYaiba.View.Home
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();
            InitializeComponent();
        }

      
    }
}