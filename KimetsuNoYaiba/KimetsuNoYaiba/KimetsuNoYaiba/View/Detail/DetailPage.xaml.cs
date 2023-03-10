using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimetsuNoYaiba.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KimetsuNoYaiba.View.Detail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(CharacterModel character)
        {
            BindingContext = new DetailPageViewModel(character);
            InitializeComponent();
        }
    }
}