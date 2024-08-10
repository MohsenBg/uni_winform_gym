using GymApp.Data;
using GymApp.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GymApp
{
    public partial class CheckInOutForm : Telerik.WinControls.UI.RadForm
    {
        private GymContext _contextDb;
        private System.Windows.Forms.Timer _closeTimer;

        public CheckInOutForm(int userId)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeForm(userId);
        }

        private void InitializeForm(int userId)
        {
            _contextDb = Program.ContextDb;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                var user = _contextDb.Users.Include(u => u.Subscription).FirstOrDefault(u => u.UserId == userId);

                if (user == null || user.Subscription == null)
                {
                    MessageBox.Show("!خطا: کاربر یا اشتراک کاربر موردنظر یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                LabelNationId.Text = user.NationalId;
                LabelFirstName.Text = user.FirstName;
                LabelLastName.Text = user.LastName;
                LabelPhone.Text = user.PhoneNumber;
                LabelExpiredDate.Text = user.Subscription.ExpirationDate.ToString("d");
                LabelSessionCount.Text = user.Subscription.SessionCount.ToString();

                var attendance = new Attendance()
                {
                    ActionTime = DateTime.Now,
                    UserId = user.UserId,
                };

                if (ShouldUserExit(userId))
                {
                    LabelTitle.Text = "خروج";
                    attendance.Action = LabelTitle.Text;
                }
                else if (!IsUserSubActive(user.Subscription))
                {
                    LabelTitle.Text = "عدم شارژ";
                    InitializeCloseTimer();
                    return;
                }
                else
                {
                    LabelTitle.Text = "ورود";
                    attendance.Action = LabelTitle.Text;
                    user.Subscription.SessionCount -= 1;
                }

                _contextDb.Attendances.Add(attendance);

                _contextDb.Users.Update(user);

                _contextDb.SaveChanges();

                InitializeCloseTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"!خطا در هنگام ذخیره‌سازی اطلاعات: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private bool IsUserSubActive(Subscription subscription)
        {
            return subscription.SessionCount > 0 && subscription.ExpirationDate >= DateTime.Now;
        }

        private bool ShouldUserExit(int userId)
        {
            var lastAttendance = GetUserLatestAttendanceInLast24Hours(userId);
            return lastAttendance?.Action == "ورود";
        }

        public Attendance GetUserLatestAttendanceInLast24Hours(int userId)
        {
            var last24Hours = DateTime.Now.AddHours(-24);

            return _contextDb.Attendances
                .Where(a => a.UserId == userId && a.ActionTime >= last24Hours)
                .OrderByDescending(a => a.ActionTime)
                .FirstOrDefault();
        }

        private void InitializeCloseTimer()
        {
            _closeTimer = new System.Windows.Forms.Timer();
            _closeTimer.Interval = 5000;
            _closeTimer.Tick += CloseTimer_Tick;
            _closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            _closeTimer.Stop();
            _closeTimer.Tick -= CloseTimer_Tick;
            Close();
        }
    }
}