using System;

namespace sess07_properties_records_indexers
{
    /// <summary>
    /// Program to demonstrate the use of indexers in C#.
    /// </summary>
    public class BookIndexer
    {
        // Create an array of programming books
        private Book[] programmingBooks = new[]
        {
            new Book(578, "C# How to Program","Deitel & Deitel", 7100.0f),
            new Book(579, "C# Notes for Professionals","Et al", 0.0f),
            new Book(580, "Java the Complete Reference","Oracle Inc.", 11710.0f),
            new Book(581, "Web Scraping with Python","Ryan Mitchelle", 7100.0f),
            new Book(582, "Fundamentals of Web Development","Randy & Ricardo", 9700.0f),
            new Book(583, "Clean Code", "Robert C. Martin", 4500.0f),
            new Book(584, "The Pragmatic Programmer", "David Thomas & Andrew Hunt", 5200.0f),
            new Book(585, "Head First Java", "Kathy Sierra & Bert Bates", 3800.0f),
            new Book(586, "Python Crash Course", "Eric Matthes", 4200.0f),
            new Book(587, "JavaScript: The Good Parts", "Douglas Crockford", 3100.0f),
            new Book(588, "HTML and CSS: Design and Build Websites", "Jon Duckett", 3500.0f),
            new Book(589, "Learning PHP, MySQL & JavaScript", "Robin Nixon", 4800.0f),
            new Book(590, "Introduction to Algorithms", "Thomas H. Cormen et al.", 8500.0f),
            new Book(591, "Design Patterns: Elements of Reusable Object-Oriented Software", "Gang of Four", 6500.0f),
            new Book(592, "The Art of Computer Programming", "Donald E. Knuth", 12000.0f)
        };

        // Set up the book index
        public Book this[uint bookId]
        {
            get { return programmingBooks[bookId];}
        }

        static void Main(string[] args)
        {
            // Display the programming books with the aid of a for...each loop using the indexer
            foreach (Book book in new BookIndexer().programmingBooks)
            {
                Console.WriteLine(book);                
            }
        }
    }
}
