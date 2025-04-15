using System.ComponentModel.DataAnnotations;

namespace SmartExpenseTracker.API.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Amount { get; set; }

        public string? Category { get; set; }

        public DateTime Date { get; set; }

        // Store file path for the receipt image
        public string? ReceiptFilePath { get; set; }

        // Optionally, store extracted text (if necessary)
        public string? ExtractedText { get; set; }
    }
}
