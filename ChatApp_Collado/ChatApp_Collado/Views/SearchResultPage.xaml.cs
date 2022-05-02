using ChatApp_Collado.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchResultPage : ContentPage, INotifyPropertyChanged
    {

        public SearchResultPage(IEnumerable<User> filteredList, User user)
        {
            InitializeComponent();
            itemSource = filteredList;
            contacts = user.Contacts;
            this.user = user;
            ToggleCloseButton = new Command(CloseSearch);
            TapUser = new Command(TapContact);
            BindingContext = this;
        }

        public ICommand ToggleCloseButton{ get; }
        public ICommand TapUser { get; private set; }

        public IEnumerable<User> itemSource;
        public ObservableCollection<User> contacts;
        public User user;

        public IEnumerable<User> ItemSource
        {
            get => itemSource;
            set
            {
                if (value == itemSource)
                    return;
                itemSource = value;
                OnPropertyChanged();
            }
        }

        private async void TapContact(object obj)
        {
           User user = (User)obj;   
           bool answer = await DisplayAlert("Question?", $"Would you like to add {user.Email}", "Yes", "No");
           if(answer)
            if(IsExist(contacts, user.Email))
                await DisplayAlert("Failed", "You both already have a connection", "Okay");
            else
               if(IsSelf(user.Email))
                    await DisplayAlert("Error", "You are not allowed to add your own self", "Okay");
               else
                {
                    AddContact(user);
                    await Navigation.PopModalAsync();
                }
        }
        private void AddContact(User user)
        {
            this.user.Contacts.Add(user);
        }

        private bool IsExist(ObservableCollection<User> user, string email)
        {
            var isExist = user.Where(x => x.Email.ToLower().StartsWith(email.ToLower()));
            return isExist.Any();
        }

        private bool IsSelf(string email)
        {
            return string.Compare(user.Email, email) == 0;
        }

        public async void CloseSearch()
        {
            await Navigation.PopModalAsync();
        }
    }
}
