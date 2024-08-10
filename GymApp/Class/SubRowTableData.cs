using GymApp.Data.Model;
using System;

namespace GymApp.Class
{
    public class SubRowTableData
    {
        public SubRowTableData(User user)
        {
            UserId = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            NationalId = user.NationalId;
            SubscriptionId = user.Subscription.SubscriptionId;
            SessionCount = user.Subscription.SessionCount;
            ExpirationDate = user.Subscription.ExpirationDate;
        }

        public int RowNumber { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }

        public int SubscriptionId { get; set; }
        public int SessionCount { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string Status { get => SessionCount > 0 && ExpirationDate >= DateTime.Now ? "فعال" : "غیرفعال"; }
    }
}