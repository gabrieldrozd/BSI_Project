using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Business.Data.Seeders
{
    public class AppIdentitySeed
    {
        public static async Task SeedUserAsync(UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    DisplayName = "Gabriel",
                    Email = "test@test.com",
                    UserName = "test@test.com",
                    Address = new Address
                    {
                        FirstName = "Gabriel",
                        LastName = "Drozd",
                        City = "Rzeszow",
                        Voivodeship = "Subcarpathia",
                        ZipCode = "35-000"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}