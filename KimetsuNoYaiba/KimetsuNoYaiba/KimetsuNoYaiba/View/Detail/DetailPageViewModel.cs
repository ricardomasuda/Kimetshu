using System.Collections.Generic;
using KimetsuNoYaiba.Model;
using KimetsuNoYaiba.View.Load;
using Rg.Plugins.Popup.Extensions;

namespace KimetsuNoYaiba.View.Detail
{
    public class DetailPageViewModel : BaseViewModel
    {
        private CharacterModel _character;
        public CharacterModel Character { get { return _character; } set { _character = value; OnPropertyChanged("Character"); } }
        
        public DetailPageViewModel(CharacterModel character)
        {
            Character = character;
            Fetch();
        }

        private async void Fetch()
        {
            var loadPage = new LoadPage();
            await App.NavPage.Navigation.PushPopupAsync(loadPage);

            var nameChar = Character.Name.Replace(" ", "_");
            Character = (await new ApiConsume().GetApiData<List<CharacterModel>>($"https://demon-slayer-api.onrender.com/v1/{nameChar}"))[0];
            loadPage.Close();
            
        }
    }
}