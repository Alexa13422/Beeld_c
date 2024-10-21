using System;

namespace Beeld_c.Models
{
    public class Message
    {
        public String Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsPinned { get; set; }
    }
}