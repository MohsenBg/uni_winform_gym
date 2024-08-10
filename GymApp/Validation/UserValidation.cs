using System.Linq;

namespace GymApp.Validation
{
    public class UserValidation
    {
        // Validate First Name
        public (bool, string) ValidateFirstName(string firstName)
        {
            var (isInvalid, errorMessage) = Required(firstName);
            if (isInvalid) return (true, errorMessage);

            (isInvalid, errorMessage) = MaxLength(firstName, 30);
            if (isInvalid) return (true, errorMessage);

            (isInvalid, errorMessage) = MinLength(firstName, 3);
            return isInvalid ? (true, errorMessage) : (false, string.Empty);
        }

        // Validate Last Name
        public (bool, string) ValidateLastName(string lastName)
        {
            var (isInvalid, errorMessage) = Required(lastName);
            if (isInvalid) return (true, errorMessage);

            (isInvalid, errorMessage) = MaxLength(lastName, 30);
            if (isInvalid) return (true, errorMessage);

            (isInvalid, errorMessage) = MinLength(lastName, 3);
            return isInvalid ? (true, errorMessage) : (false, string.Empty);
        }

        // Validate Phone Number
        public (bool, string) ValidatePhoneNumber(string phoneNumber)
        {
            return IsPhoneNumberValid(phoneNumber);
        }

        // Validate National ID
        public (bool, string) ValidateNationalId(string nationalId)
        {
            return IsNationalIdValid(nationalId);
        }

        // Validate Address
        public (bool, string) ValidateAddress(string address)
        {
            var (isInvalid, errorMessage) = Required(address);
            if (isInvalid) return (true, errorMessage);

            (isInvalid, errorMessage) = MaxLength(address, 100);
            if (isInvalid) return (true, errorMessage);

            (isInvalid, errorMessage) = MinLength(address, 5);
            return isInvalid ? (true, errorMessage) : (false, string.Empty);
        }

        // Required Validation
        private (bool, string) Required(string input, string errorMessage = "پر کردن این فیلد ضروری است")
        {
            return string.IsNullOrWhiteSpace(input) ? (true, errorMessage) : (false, string.Empty);
        }

        // MaxLength Validation
        private (bool, string) MaxLength(string input, int maxLength, string errorMessage = null)
        {
            string defaultMessage = $"طول ورودی نمی‌تواند بیشتر از {maxLength} کاراکتر باشد.";
            errorMessage = string.IsNullOrEmpty(errorMessage) ? defaultMessage : errorMessage;

            return input.Length > maxLength ? (true, errorMessage) : (false, string.Empty);
        }

        // MinLength Validation
        private (bool, string) MinLength(string input, int minLength, string errorMessage = null)
        {
            string defaultMessage = $"طول ورودی نمی‌تواند کمتر از {minLength} کاراکتر باشد.";
            errorMessage = string.IsNullOrEmpty(errorMessage) ? defaultMessage : errorMessage;

            return input.Length < minLength ? (true, errorMessage) : (false, string.Empty);
        }

        // Validate Phone Number
        private (bool, string) IsPhoneNumberValid(string phoneNumber, string errorMessage = "شماره تلفن باید با 09 شروع شده و شامل 11 رقم باشد.")
        {
            bool isValid = phoneNumber.Length == 11 && phoneNumber.StartsWith("09") && phoneNumber.All(char.IsDigit);
            return isValid ? (false, string.Empty) : (true, errorMessage);
        }

        // Validate National ID
        private (bool, string) IsNationalIdValid(string nationalId, string errorMessage = "کد ملی باید دقیقا 10 رقم و فقط شامل اعداد باشد.")
        {
            bool isValid = nationalId.Length == 10 && nationalId.All(char.IsDigit);
            return isValid ? (false, string.Empty) : (true, errorMessage);
        }
    }
}