using System;

namespace ChatApp_Collado.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
