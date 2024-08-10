using GymApp.Data;
using GymApp.Data.Model;
using GymApp.Validation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GymApp
{
    public partial class EditUserForm : Telerik.WinControls.UI.RadForm
    {
        private User _user;
        private GymContext _contextDb;
        private ErrorProvider UserErrorProvider;
        private UserValidation UserValidation { get; set; }

        public EditUserForm(int userId)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeForm(userId);
        }

        private void InitializeForm(int userId)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            UserValidation = new UserValidation();
            _contextDb = Program.ContextDb;
            UserErrorProvider = new ErrorProvider();
            _user = _contextDb.Users.FirstOrDefault(u => u.UserId == userId);

            if (_user == null)
            {
                MessageBox.Show("خطا: کاربر مورد نظر یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            TextBoxNationId.Text = _user.NationalId;
            TextBoxFirstName.Text = _user.FirstName;
            TextBoxLastName.Text = _user.LastName;
            TextBoxPhone.Text = _user.PhoneNumber;
            DateTimePickerBirthdate.Value = _user.Birthdate;
            TextBoxAddress.Text = _user.Address;

            TextBoxFirstName.Validating += FirstNameTextBox_Validating;
            TextBoxLastName.Validating += LastNameTextBox_Validating;
            TextBoxNationId.Validating += NationIdTextBox_Validating;
            TextBoxPhone.Validating += PhoneTextBox_Validating;
            TextBoxAddress.Validating += AddressTextBox_Validating;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _user.NationalId = TextBoxNationId.Text;
            _user.FirstName = TextBoxFirstName.Text;
            _user.LastName = TextBoxLastName.Text;
            _user.PhoneNumber = TextBoxPhone.Text;
            _user.Birthdate = DateTimePickerBirthdate.Value;
            _user.Address = TextBoxAddress.Text;

            try
            {
                Cursor = Cursors.WaitCursor;
                Enabled = false;
                _contextDb.Users.Update(_user);
                _contextDb.SaveChanges();
                MessageBox.Show("اطلاعات کاربر با موفقیت به‌روز شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در به‌روزرسانی اطلاعات کاربر: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                Enabled = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var (hasError, errorMessage) = UserValidation.ValidateFirstName(TextBoxFirstName.Text);
            if (hasError)
            {
                e.Cancel = true;
                UserErrorProvider.SetError(TextBoxFirstName, errorMessage);
                return;
            }
            e.Cancel = false;
            UserErrorProvider.SetError(TextBoxFirstName, "");
        }

        private void LastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var (hasError, errorMessage) = UserValidation.ValidateLastName(TextBoxLastName.Text);
            if (hasError)
            {
                e.Cancel = true;
                UserErrorProvider.SetError(TextBoxLastName, errorMessage);
                return;
            }
            e.Cancel = false;
            UserErrorProvider.SetError(TextBoxLastName, "");
        }

        private void NationIdTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var (hasError, errorMessage) = UserValidation.ValidateNationalId(TextBoxNationId.Text);
            if (hasError)
            {
                e.Cancel = true;
                UserErrorProvider.SetError(TextBoxNationId, errorMessage);
                return;
            }
            e.Cancel = false;
            UserErrorProvider.SetError(TextBoxNationId, "");
        }

        private void PhoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var (hasError, errorMessage) = UserValidation.ValidatePhoneNumber(TextBoxPhone.Text);
            if (hasError)
            {
                e.Cancel = true;
                UserErrorProvider.SetError(TextBoxPhone, errorMessage);
                return;
            }
            e.Cancel = false;
            UserErrorProvider.SetError(TextBoxPhone, "");
        }

        private void AddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var (hasError, errorMessage) = UserValidation.ValidateAddress(TextBoxAddress.Text);
            if (hasError)
            {
                e.Cancel = true;
                UserErrorProvider.SetError(TextBoxAddress, errorMessage);
                return;
            }
            e.Cancel = false;
            UserErrorProvider.SetError(TextBoxAddress, "");
        }
    }
}