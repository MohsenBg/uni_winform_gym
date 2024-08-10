using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Data.Model
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }

        public int SessionCount { get; set; }
        public DateTime ExpirationDate { get; set; }

        // Navigation property
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}