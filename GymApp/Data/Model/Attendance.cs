using System;
using System.ComponentModel.DataAnnotations;

namespace GymApp.Data.Model
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        public string Action { get; set; }
        public DateTime ActionTime { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}