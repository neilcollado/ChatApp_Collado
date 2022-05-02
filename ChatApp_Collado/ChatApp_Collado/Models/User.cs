using System;
using System.Collections.ObjectModel;

namespace ChatApp_Collado.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ObservableCollection<User> Contacts { get; set; }
        public ObservableCollection<Message> Messages { get; set; }
    }

    public class Message
    {
        public int Id { get; set; }
        public int GroupID { get; set; }
        public string Content { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public TimeSpan TimeSent { get; set; }
        public TimeSpan DateSent { get; set; }
    }
}
