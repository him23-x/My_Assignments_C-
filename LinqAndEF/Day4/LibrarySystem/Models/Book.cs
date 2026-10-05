using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;

        // Many-to-One with Author
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        // Many-to-Many with Borrower through Loan
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
