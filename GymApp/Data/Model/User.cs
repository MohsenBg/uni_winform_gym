using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Data.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime Birthdate { get; set; }

        public string NationalId { get; set; }

        // Navigation property
        public Subscription Subscription { get; set; }

        [NotMapped]
        public int RowNumber { get; set; }

        public List<Attendance> Attendances { get; set; }

        public override string ToString() => $"نام:{FirstName}    نام خانوادگی:{LastName}   کدملی:{NationalId}";
    }
}