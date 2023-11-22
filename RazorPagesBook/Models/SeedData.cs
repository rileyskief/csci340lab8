using Microsoft.EntityFrameworkCore;
using RazorPagesBook.Data;

namespace RazorPagesBook.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesBookContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesBookContext>>()))
        {
            if (context == null || context.Book == null)
            {
                throw new ArgumentNullException("Null RazorPagesBookContext");
            }

            // Look for any books.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "The Hunt for Red October",
                    ReleaseDate = DateTime.Parse("1984-10-1"),
                    // Author = "Tom Clancy",
                    Genre = "Thriller",
                    Price = 9.89M
                },

                new Book
                {
                    Title = "All That Remains",
                    ReleaseDate = DateTime.Parse("1992-4-15"),
                    // Author = "Patricia Cornwell",
                    Genre = "Mystery",
                    Price = 8.50M
                },

                new Book
                {
                    Title = "Gone With the Wind",
                    ReleaseDate = DateTime.Parse("1936-6-30"),
                    // Author = "Margaret Mitchell",
                    Genre = "Historical Fiction",
                    Price = 18.58M
                },

                new Book
                {
                    Title = "White Jacket",
                    ReleaseDate = DateTime.Parse("1850-1-23"),
                    // Author = "Herman Melville",
                    Genre = "Nautical Fiction",
                    Price = 19.95M
                }
            );
            context.SaveChanges();
        }
    }
}