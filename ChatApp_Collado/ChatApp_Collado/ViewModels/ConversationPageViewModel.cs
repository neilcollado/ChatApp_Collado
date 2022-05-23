using ChatApp_Collado.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChatApp_Collado.ViewModels
{
    class ConversationPageViewModel : INotifyPropertyChanged
    {
        public Conversation convo = new Conversation
        {
            Id = 512,
            UserChat = 202,
            Messages = new ObservableCollection<Message>
            {
                new Message { Text = "hi" },
                new Message { User = App.user.Id, Text = "hello" },
                new Message { Text = "how are you?" }
            }
        };

        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public string TextToSend { get; set; }
        public ICommand OnSendCommand { get; set; }

        public string _header;

        public string Header { get => _header; set { _header = value; } }

        public ConversationPageViewModel(User user)
        {

            if (user.Id == 202)
                Messages = convo.Messages;

            _header = user.Username;

            OnSendCommand = new Command(() =>
            {
                if(!string.IsNullOrEmpty(TextToSend))
                {
                    Messages.Add(new Message() { Text = TextToSend, User = App.user.Id });
                    TextToSend = string.Empty;
                }
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}