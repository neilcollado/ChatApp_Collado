using System.Collections.ObjectModel;

namespace ChatApp_Collado.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public int UserChat { get; set; }
        public ObservableCollection<Message> Messages { get; set; }
    }
}
