using GymApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GymApp.Data
{
    public class Seed
    {
        public static List<User> GetUsers()
        {
            Random random = new Random();
            var firstNames = new[] { "علی", "سارا", "رضا", "فاطمه", "محمد", "زهرا", "حسین", "مریم", "احسان", "نرگس" };
            var lastNames = new[] { "رضایی", "احمدی", "قاسمی", "کریمی", "حسینی", "علوی", "موسوی", "جعفری", "شریعتی", "بهرامی" };
            var addresses = new[]
            {
                "ایران, تهران, خیابان ولیعصر, کوچه بهار, پلاک 12",
                "ایران, مشهد, خیابان امام رضا, کوچه نور, پلاک 34",
                "ایران, اصفهان, خیابان چهارباغ, کوچه مهر, پلاک 23",
                "ایران, شیراز, خیابان زند, کوچه گل, پلاک 9",
                "ایران, تبریز, خیابان آزادی, کوچه نصر, پلاک 15",
                "ایران, قم, خیابان انقلاب, کوچه نور, پلاک 7",
                "ایران, کرج, خیابان درختی, کوچه بهار, پلاک 3",
                "ایران, اهواز, خیابان طالقانی, کوچه یاس, پلاک 27",
                "ایران, کرمانشاه, خیابان معلم, کوچه بهار, پلاک 19",
                "ایران, رشت, خیابان گلسار, کوچه سرو, پلاک 13"
            };

            var users = new List<User>();

            for (int i = 0; i < 50; i++)
            {
                var firstName = firstNames[random.Next(firstNames.Length)];
                var lastName = lastNames[random.Next(lastNames.Length)];
                var address = addresses[random.Next(addresses.Length)];
                var birthDate = new DateTime(random.Next(1960, 2005), random.Next(1, 13), random.Next(1, 29));

                users.Add(new User
                {
                    UserId = i + 1,
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = $"090000000{i + 1:D2}",
                    Address = address,
                    NationalId = GenNationId(),
                    Birthdate = birthDate
                });
            }

            return users;
        }

        public static List<Subscription> GetSubscriptions(List<User> users)
        {
            Random random = new Random();
            var subscriptions = new List<Subscription>();

            foreach (var user in users)
            {
                subscriptions.Add(new Subscription
                {
                    SubscriptionId = user.UserId,
                    UserId = user.UserId,
                    SessionCount = random.Next(10, 21),
                    ExpirationDate = DateTime.Now.AddMonths(random.Next(1, 13))
                });
            }

            return subscriptions;
        }

        public static List<Attendance> GetAttendances(List<User> users)
        {
            Random random = new Random();
            var attendances = new List<Attendance>();

            // Randomly select 10 to 20 users
            var selectedUsers = users.OrderBy(x => random.Next()).Take(random.Next(10, 21)).ToList();

            foreach (var user in selectedUsers)
            {
                int numAttendances = random.Next(5, 10);

                for (int i = 0; i < numAttendances; i++)
                {
                    var entryDay = DateTime.Now.AddDays(-random.Next(0, 30));

                    var entryTime = entryDay.AddHours(random.Next(6, 12));
                    var exitTime = entryTime.AddHours(random.Next(1, 6));

                    attendances.Add(new Attendance
                    {
                        AttendanceId = attendances.Count + 1,
                        UserId = user.UserId,
                        Action = "ورود",
                        ActionTime = entryTime,
                    });

                    attendances.Add(new Attendance
                    {
                        AttendanceId = attendances.Count + 1,
                        UserId = user.UserId,
                        Action = "خروج",
                        ActionTime = exitTime,
                    });
                }
            }

            return attendances;
        }

        private static string GenNationId()
        {
            Random random = new Random();
            return random.NextInt64(1000000000, 9999999999).ToString();
        }
    }
}