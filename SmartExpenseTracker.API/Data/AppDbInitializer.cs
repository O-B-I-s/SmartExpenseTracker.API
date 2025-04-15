using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SmartExpenseTracker.API.Data
{
    public static class AppDbInitializer
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // Ensure database is migrated/created
            await context.Database.MigrateAsync();

            // Seed roles
            string[] roles = { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // Seed admin user
            var adminEmail = "ifybioma@gmail.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = "ifybioma",
                    Email = adminEmail,
                    EmailConfirmed = true, // Bypass email confirmation
                    PersonName = "Admin User"
                };

                var createResult = await userManager.CreateAsync(adminUser, "Admin@123");
                if (!createResult.Succeeded)
                {
                    throw new Exception("Admin user creation failed: " +
                        string.Join(", ", createResult.Errors.Select(e => e.Description)));
                }

                var roleResult = await userManager.AddToRoleAsync(adminUser, "Admin");
                if (!roleResult.Succeeded)
                {
                    throw new Exception("Admin role assignment failed: " +
                        string.Join(", ", roleResult.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}