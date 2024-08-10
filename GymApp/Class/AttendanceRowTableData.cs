using GymApp.Data.Model;
using System;

namespace GymApp.Class
{
    public class AttendanceRowTableData
    {
        public AttendanceRowTableData(Attendance attendance)
        {
            Action = attendance.Action;
            ActionTime = attendance.ActionTime;
            FirstName = attendance.User.FirstName;
            LastName = attendance.User.LastName;
            NationId = attendance.User.NationalId;
        }

        public int RowNumber { get; set; }
        public string Action { get; set; }
        public DateTime ActionTime { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationId { get; set; }
    }
}