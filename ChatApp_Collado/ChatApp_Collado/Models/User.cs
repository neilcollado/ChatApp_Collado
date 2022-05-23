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
    }
}
