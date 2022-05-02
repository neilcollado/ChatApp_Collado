using ChatApp_Collado.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        readonly User current_user = new User()
        {
            Username = "Neil Collado",
            Email = "neilcollado@gmail.com",
            Contacts = new ObservableCollection<User>
            {
                new User { Username = "John Doe",  Email = "JohnDoe@gmail.com" },
            }
        };

        public ChatPage()
        {
            InitializeComponent();
            allUsers = new ObservableCollection<User>
            {
                new User{Username="John Doe", Email="JohnDoe@gmail.com"},
                new User{Username="Neil Collado", Email="neilcollado@gmail.com"},
                new User {Username = "Juan Dela Cruz", Email = "JuanDCruz@gmail.com"},
                new User {Username = "Luffy Monkey", Email = "LuffyTaro@gmail.com"},
            };
            users = current_user.Contacts;
            itemSource = users;
            TapUser = new Command(RedirectToChat);
            BindingContext = this;
        }

        readonly ObservableCollection<User> users;
        readonly ObservableCollection<User> allUsers;

        public ICommand TapUser { get; private set; }

        public IEnumerable<User> itemSource;
        public IEnumerable<User> ItemSource { get => itemSource; set { itemSource = value; OnPropertyChanged(); } }

        private async void RedirectToChat(object obj)
        {
            User user = (User)obj;
            await Navigation.PushModalAsync(new ConversationPage(user, current_user), false);
        }

        private async void SearchBar(object sender, EventArgs e)
        {
            string search = mySearchBar.Text;
            var filteredList = allUsers.Where(x => x.Email.ToLower().StartsWith(search.ToLower()));
            if (filteredList.Any())
            {
                await Navigation.PushModalAsync(new SearchResultPage(filteredList, current_user), false);
            } else
            {
                await DisplayAlert("", "User not found", "Okay");
            }
        }
    }
}