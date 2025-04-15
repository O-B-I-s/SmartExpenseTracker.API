using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartExpenseTracker.API.Models;

namespace SmartExpenseTracker.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var startDate = new DateTime(2023, 1, 1);
            var endDate = DateTime.Now;

            modelBuilder.Entity<Expense>().HasData(
                new Expense { Id = 2, Description = "Groceries from Walmart", Amount = 50, Category = "Food", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 3, Description = "Uber ride to downtown", Amount = 20, Category = "Transportation", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 4, Description = "Monthly Netflix subscription", Amount = 15, Category = "Entertainment", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 5, Description = "Doctor's appointment fee", Amount = 100, Category = "Healthcare", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 6, Description = "College tuition payment", Amount = 1000, Category = "Education", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 7, Description = "Electricity bill", Amount = 120, Category = "Utilities", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 8, Description = "Clothes from Zara", Amount = 70, Category = "Shopping", Date = new DateTime(2023, 4, 6) },
                new Expense { Id = 9, Description = "Flight to Toronto", Amount = 300, Category = "Travel", Date = new DateTime(2023, 4, 6) },

        // Food & Dining
        new Expense { Id = 10, Description = "Coffee at Starbucks", Amount = 4.50f, Category = "Food & Dining", Date = new DateTime(2023, 3, 10) },
        new Expense { Id = 11, Description = "Lunch at McDonald's", Amount = 12.75f, Category = "Food & Dining", Date = new DateTime(2023, 3, 11) },
        new Expense { Id = 12, Description = "Grocery shopping at Walmart", Amount = 67.90f, Category = "Food & Dining", Date = new DateTime(2023, 3, 12) },

        // Transportation
        new Expense { Id = 13, Description = "Uber ride downtown", Amount = 18.25f, Category = "Transportation", Date = new DateTime(2023, 3, 13) },
        new Expense { Id = 14, Description = "Gas refill", Amount = 45.30f, Category = "Transportation", Date = new DateTime(2023, 3, 14) },
        new Expense { Id = 15, Description = "Train ticket", Amount = 10.50f, Category = "Transportation", Date = new DateTime(2023, 3, 15) },

        // Entertainment
        new Expense { Id = 16, Description = "Netflix subscription", Amount = 15.99f, Category = "Entertainment", Date = new DateTime(2023, 3, 16) },
        new Expense { Id = 17, Description = "Movie ticket", Amount = 14.00f, Category = "Entertainment", Date = new DateTime(2023, 3, 17) },
        new Expense { Id = 18, Description = "Concert ticket", Amount = 75.00f, Category = "Entertainment", Date = new DateTime(2023, 3, 18) },

        // Utilities
        new Expense { Id = 19, Description = "Electricity bill", Amount = 120.45f, Category = "Utilities", Date = new DateTime(2023, 3, 19) },
        new Expense { Id = 20, Description = "Internet bill", Amount = 65.99f, Category = "Utilities", Date = new DateTime(2023, 3, 20) },
        new Expense { Id = 21, Description = "Water bill", Amount = 35.20f, Category = "Utilities", Date = new DateTime(2023, 3, 21) },

        // Shopping
        new Expense { Id = 22, Description = "Amazon purchase - headphones", Amount = 120.00f, Category = "Shopping", Date = new DateTime(2023, 3, 22) },
        new Expense { Id = 23, Description = "Clothing from H&M", Amount = 45.00f, Category = "Shopping", Date = new DateTime(2023, 3, 23) },
        new Expense { Id = 24, Description = "Shoes from Nike", Amount = 90.00f, Category = "Shopping", Date = new DateTime(2023, 3, 24) },

        // Healthcare
        new Expense { Id = 25, Description = "Doctor's visit", Amount = 150.00f, Category = "Healthcare", Date = new DateTime(2023, 3, 25) },
        new Expense { Id = 26, Description = "Pharmacy - medication", Amount = 30.25f, Category = "Healthcare", Date = new DateTime(2023, 3, 26) },
        new Expense { Id = 27, Description = "Dental checkup", Amount = 200.00f, Category = "Healthcare", Date = new DateTime(2023, 3, 27) },

        // Education
        new Expense { Id = 28, Description = "Online course on Udemy", Amount = 45.00f, Category = "Education", Date = new DateTime(2023, 3, 28) },
        new Expense { Id = 29, Description = "Textbooks", Amount = 120.00f, Category = "Education", Date = new DateTime(2023, 3, 29) },
        new Expense { Id = 30, Description = "School supplies", Amount = 25.50f, Category = "Education", Date = new DateTime(2023, 3, 30) },

        // Travel
        new Expense { Id = 31, Description = "Flight ticket", Amount = 350.00f, Category = "Travel", Date = new DateTime(2023, 3, 31) },
        new Expense { Id = 32, Description = "Hotel booking", Amount = 120.00f, Category = "Travel", Date = new DateTime(2023, 4, 1) },
        new Expense { Id = 33, Description = "Car rental", Amount = 85.00f, Category = "Travel", Date = new DateTime(2023, 4, 2) },

        // Insurance
        new Expense { Id = 34, Description = "Health insurance", Amount = 250.00f, Category = "Insurance", Date = new DateTime(2023, 4, 3) },
        new Expense { Id = 35, Description = "Car insurance", Amount = 180.00f, Category = "Insurance", Date = new DateTime(2023, 4, 4) },
        new Expense { Id = 36, Description = "Home insurance", Amount = 300.00f, Category = "Insurance", Date = new DateTime(2023, 4, 5) },

        // Miscellaneous
        new Expense { Id = 37, Description = "Birthday gift", Amount = 40.00f, Category = "Miscellaneous", Date = new DateTime(2023, 4, 6) },
        new Expense { Id = 38, Description = "Donation", Amount = 20.00f, Category = "Miscellaneous", Date = new DateTime(2023, 4, 7) },
        new Expense { Id = 39, Description = "Postage", Amount = 5.50f, Category = "Miscellaneous", Date = new DateTime(2023, 4, 8) },


// Food & Dining
new Expense { Id = 100, Description = "Coffee at Tim Hortons", Amount = 3.50f, Category = "Food & Dining", Date = new DateTime(2023, 3, 19) },
new Expense { Id = 101, Description = "Lunch at Subway", Amount = 8.99f, Category = "Food & Dining", Date = new DateTime(2023, 3, 20) },
new Expense { Id = 102, Description = "Dinner at KFC", Amount = 14.50f, Category = "Food & Dining", Date = new DateTime(2023, 3, 21) },
new Expense { Id = 103, Description = "Grocery shopping at T&T Supermarket", Amount = 120.75f, Category = "Food & Dining", Date = new DateTime(2023, 3, 22) },
new Expense { Id = 104, Description = "Snack at 7-Eleven", Amount = 5.00f, Category = "Food & Dining", Date = new DateTime(2023, 3, 23) },
new Expense { Id = 105, Description = "Burger King meal", Amount = 9.25f, Category = "Food & Dining", Date = new DateTime(2023, 3, 24) },
new Expense { Id = 106, Description = "Grocery shopping at Walmart", Amount = 78.20f, Category = "Food & Dining", Date = new DateTime(2023, 3, 25) },
new Expense { Id = 107, Description = "Coffee at McDonald's", Amount = 2.75f, Category = "Food & Dining", Date = new DateTime(2023, 3, 26) },
new Expense { Id = 108, Description = "Ice cream at Dairy Queen", Amount = 4.99f, Category = "Food & Dining", Date = new DateTime(2023, 3, 27) },
new Expense { Id = 109, Description = "Pizza at Domino's", Amount = 18.45f, Category = "Food & Dining", Date = new DateTime(2023, 3, 28) },

// Transportation
new Expense { Id = 110, Description = "Bus fare", Amount = 3.25f, Category = "Transportation", Date = new DateTime(2023, 3, 29) },
new Expense { Id = 111, Description = "Taxi ride to airport", Amount = 45.00f, Category = "Transportation", Date = new DateTime(2023, 3, 30) },
new Expense { Id = 112, Description = "Gas refill at Shell", Amount = 55.40f, Category = "Transportation", Date = new DateTime(2023, 4, 1) },
new Expense { Id = 113, Description = "Flight to Toronto", Amount = 320.75f, Category = "Transportation", Date = new DateTime(2023, 4, 2) },
new Expense { Id = 114, Description = "Uber ride to downtown", Amount = 20.50f, Category = "Transportation", Date = new DateTime(2023, 4, 3) },
new Expense { Id = 115, Description = "Train ticket", Amount = 12.50f, Category = "Transportation", Date = new DateTime(2023, 4, 4) },
new Expense { Id = 116, Description = "Electric scooter rental", Amount = 5.00f, Category = "Transportation", Date = new DateTime(2023, 4, 5) },
new Expense { Id = 117, Description = "Parking fee", Amount = 10.00f, Category = "Transportation", Date = new DateTime(2023, 4, 6) },
new Expense { Id = 118, Description = "Car wash", Amount = 15.00f, Category = "Transportation", Date = new DateTime(2023, 4, 7) },
new Expense { Id = 119, Description = "Oil change", Amount = 60.00f, Category = "Transportation", Date = new DateTime(2023, 4, 8) },

// Entertainment
new Expense { Id = 120, Description = "Netflix subscription", Amount = 15.99f, Category = "Entertainment", Date = new DateTime(2023, 4, 9) },
new Expense { Id = 121, Description = "Movie at Cineplex", Amount = 13.50f, Category = "Entertainment", Date = new DateTime(2023, 4, 10) },
new Expense { Id = 122, Description = "Spotify premium", Amount = 12.99f, Category = "Entertainment", Date = new DateTime(2023, 4, 11) },
new Expense { Id = 123, Description = "Concert ticket", Amount = 80.00f, Category = "Entertainment", Date = new DateTime(2023, 4, 12) },
new Expense { Id = 124, Description = "Gaming subscription", Amount = 9.99f, Category = "Entertainment", Date = new DateTime(2023, 4, 13) },
new Expense { Id = 125, Description = "Escape room", Amount = 28.00f, Category = "Entertainment", Date = new DateTime(2023, 4, 14) },
new Expense { Id = 126, Description = "Bowling night", Amount = 20.00f, Category = "Entertainment", Date = new DateTime(2023, 4, 15) },
new Expense { Id = 127, Description = "Karaoke night", Amount = 15.00f, Category = "Entertainment", Date = new DateTime(2023, 4, 16) },
new Expense { Id = 128, Description = "Museum entry", Amount = 18.00f, Category = "Entertainment", Date = new DateTime(2023, 4, 17) },
new Expense { Id = 129, Description = "Comedy show", Amount = 25.00f, Category = "Entertainment", Date = new DateTime(2023, 4, 18) },

// Utilities
new Expense { Id = 130, Description = "Electric bill", Amount = 100.25f, Category = "Utilities", Date = new DateTime(2023, 4, 19) },
new Expense { Id = 131, Description = "Internet bill", Amount = 60.75f, Category = "Utilities", Date = new DateTime(2023, 4, 20) },
new Expense { Id = 132, Description = "Water bill", Amount = 40.00f, Category = "Utilities", Date = new DateTime(2023, 4, 21) },
new Expense { Id = 133, Description = "Heating bill", Amount = 70.50f, Category = "Utilities", Date = new DateTime(2023, 4, 22) },
new Expense { Id = 134, Description = "Phone bill", Amount = 55.00f, Category = "Utilities", Date = new DateTime(2023, 4, 23) },

// Health & Fitness
new Expense { Id = 135, Description = "Gym membership", Amount = 45.00f, Category = "Health & Fitness", Date = new DateTime(2023, 4, 24) },
new Expense { Id = 136, Description = "Massage therapy", Amount = 70.00f, Category = "Health & Fitness", Date = new DateTime(2023, 4, 25) },
new Expense { Id = 137, Description = "Yoga class", Amount = 15.00f, Category = "Health & Fitness", Date = new DateTime(2023, 4, 26) },
new Expense { Id = 138, Description = "Personal trainer", Amount = 90.00f, Category = "Health & Fitness", Date = new DateTime(2023, 4, 27) },
new Expense { Id = 139, Description = "Supplements", Amount = 35.00f, Category = "Health & Fitness", Date = new DateTime(2023, 4, 28) }


            );
        }


    }
}
