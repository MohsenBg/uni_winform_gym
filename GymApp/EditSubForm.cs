using GymApp.Data;
using GymApp.Data.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GymApp
{
    public partial class EditSubForm : Telerik.WinControls.UI.RadForm
    {
        private GymContext _contextDb;
        private Subscription _subscription;

        public EditSubForm(int subId)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeForm(subId);
        }

        private void InitializeForm(int subId)
        {
            _contextDb = Program.ContextDb;
            _subscription = _contextDb.Subscriptions.FirstOrDefault(sub => sub.SubscriptionId == subId);
            if (_subscription == null)
            {
                MessageBox.Show("خطا:اشتراک کابر مورد نظر یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            SessionCountNumeric.Value = _subscription.SessionCount;
            DateTimePickerExpiredTime.Value = _subscription.ExpirationDate;
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            _subscription.SessionCount = (int)SessionCountNumeric.Value;
            _subscription.ExpirationDate = DateTimePickerExpiredTime.Value;
            try
            {
                Cursor = Cursors.WaitCursor;
                Enabled = false;
                _contextDb.Subscriptions.Update(_subscription);
                _contextDb.SaveChanges();
                MessageBox.Show("اشتراک کابر با موفقیت به‌روز شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در به‌روزرسانی اشتراک کاربر: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                Enabled = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}