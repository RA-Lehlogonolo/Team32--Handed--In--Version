using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;
using VillageBoard.Annoucements;
using VillageBoard.Disciplinary_Hearings;
using VillageBoard.Events;
using VillageBoard.Orders;
using VillageBoard.Student_Visitations;

namespace VillageBoard.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;


        }
        public IEnumerable<Announcement> Announcements { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public IEnumerable<Event> Event { get; set; }

        public IEnumerable<Studnet_Visitation> Studnet_Visitations { get; set; }

        public IEnumerable<Disciplinary_Hearing> Disciplinary_Hearings { get; set; }








    }
}
