using ChatApp_Collado.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_Collado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversationPage : ContentPage
    {


        public ConversationPage(User user, User current_user)
        {
            InitializeComponent();
            username = user.Username;
            messages = current_user.Messages;
            this.user = current_user;
            itemSource = messages;
            ToggleCloseButton = new Command(CloseButton);
            ToggleSendMsg = new Command(SendMsg);
            BindingContext = this;
        }

        public string username;
        public string _message;

        readonly ObservableCollection<Message> messages;
        public User user;

        public ICommand ToggleCloseButton { get; }
        public ICommand ToggleSendMsg { get; }

        public IEnumerable<Message> itemSource;
        public IEnumerable<Message> ItemSource { get => itemSource; set { itemSource = value; OnPropertyChanged(); } }

        public string Header { get => username; set { username = value; OnPropertyChanged(); } }
        public string Message { get => _message; set { _message = value; OnPropertyChanged(); } }

        private void SendMsg()
        {
  
        }

        private async void CloseButton()
        {
            await Navigation.PopModalAsync();
        }
    }
}