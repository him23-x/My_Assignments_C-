using System;

// Q1: Why did "Id" become a Primary Key without any explicit configuration?
// A1: Because of EF Core's naming convention. If a property is named "Id" (or "<ClassName>Id",
//     like "BookId"), EF Core treats it as the primary key automatically. Since it's an int,
//     EF also makes it an IDENTITY column, so SQL Server generates the value for us.
//
// Q2: Why is "Country" nullable in the database while "Price" is not?
// A2: Because of the C# types. "Country" is declared as string? (a nullable reference type),
//     so EF creates the column as NULL. "Price" is a decimal, which is a value type and
//     can't hold null, so EF creates it as NOT NULL. Same idea for PublishedDate: it's
//     DateTime? so its column allows NULL.

namespace BookstoreSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
