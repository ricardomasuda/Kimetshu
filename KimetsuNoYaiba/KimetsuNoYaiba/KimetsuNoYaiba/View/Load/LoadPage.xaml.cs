using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KimetsuNoYaiba.View.Load
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadPage : PopupPage
    {
        public LoadPage()
        {
            InitializeComponent();
        }
        
        protected override bool OnBackgroundClicked()
        {
            return false;
        }
        
        public async void Close()
        {
            try
            {
                await Navigation.PopAllPopupAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }
        
        public void AtualizarTexto(string mensagem)
        {
            LabelLoad.Text = mensagem;
        }
    }
}