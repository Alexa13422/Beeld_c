using System;

namespace Beeld_c.Models
{
    public enum SubscriptionType
    {
        Usual,Premium
    }
    public class Subscribtion
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public SubscriptionType Type { get; set; }
    }
}