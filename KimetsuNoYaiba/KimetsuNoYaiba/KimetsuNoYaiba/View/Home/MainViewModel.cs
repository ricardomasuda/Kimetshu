using System.Collections.Generic;
using System.Collections.ObjectModel;
using KimetsuNoYaiba.Model;
using KimetsuNoYaiba.View.Detail;
using Xamarin.Forms;

namespace KimetsuNoYaiba.View.Home
{
    public class MainViewModel : BaseViewModel
    {
        
        private ObservableCollection<CharacterModel> _listCharacter;
        public ObservableCollection<CharacterModel> ListCharacter { get { return _listCharacter; } set { _listCharacter = value; OnPropertyChanged("ListCharacter"); } }
        
        public Command DetailCommand { get; set; }

        public MainViewModel()
        {
            Fetch();
            DetailCommand = new Command(CharacterDetailCommand);
        }

        private async void Fetch()
        {
            var listCharacter = await new ApiConsume().GetApiData<List<CharacterModel>>("https://demon-slayer-api.onrender.com/v1?limit=20");
            if (listCharacter.Count != 0)
            {
                ListCharacter = new ObservableCollection<CharacterModel>(listCharacter);
            }
        }

        private void CharacterDetailCommand(object sender)
        {
            App.NavPage.Navigation.PushAsync(new DetailPage((CharacterModel)sender));
        }
    }
}