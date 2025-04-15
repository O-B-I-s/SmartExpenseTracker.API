using Microsoft.AspNetCore.Identity;

namespace SmartExpenseTracker.API.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string PersonName { get; set; }


    }
}
