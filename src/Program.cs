using System.Formats.Tar;
using sda_onsite_2_csharp_library_management.src;

internal class Program
{
    static void Main(string[] args)
    {
        //create 3 classes : book: has id, title, created date
        //  user: id, created date, name
        //library: manage user and book 
        library.AddBook(new Book("The Great Gatsby", new DateTime(2023, 1, 1)));
        library.AddBook(new Book("1984", new DateTime(2023, 2, 1)));
        library.AddBook(new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1)));
        library.AddBook(new Book("Pride and Prejudice", new DateTime(2023, 5, 1)));
        library.AddBook(new Book("Wuthering Heights", new DateTime(2023, 6, 1)));
        library.AddBook(new Book("Jane Eyre", new DateTime(2023, 7, 1)));
        library.AddBook(new Book("Brave New World", new DateTime(2023, 8, 1)));
        library.AddBook(new Book("Moby-Dick", new DateTime(2023, 9, 1)));
        library.AddBook(new Book("War and Peace", new DateTime(2023, 10, 1)));
        library.AddBook(new Book("Hamlet", new DateTime(2023, 11, 1)));
        library.AddBook(new Book("Great Expectations", new DateTime(2023, 12, 1)));
        library.AddBook(new Book("Ulysses", new DateTime(2024, 1, 1)));
        library.AddBook(new Book("The Odyssey", new DateTime(2024, 2, 1)));
        library.AddBook(new Book("The Divine Comedy", new DateTime(2024, 3, 1)));
        library.AddBook(new Book("Crime and Punishment", new DateTime(2024, 4, 1)));
        library.AddBook(new Book("The Brothers Karamazov", new DateTime(2024, 5, 1)));
        library.AddBook(new Book("Don Quixote", new DateTime(2024, 6, 1)));
        library.AddBook(new Book("The Iliad"));
        library.AddBook(new Book("Anna Karenina"));


        library.AddUser(new User("Alice", new DateTime(2023, 1, 1)));
        library.AddUser(new User("Bob", new DateTime(2023, 2, 1)));
        library.AddUser(new User("Charlie", new DateTime(2023, 3, 1)));
        library.AddUser(new User("David", new DateTime(2023, 4, 1)));
        library.AddUser(new User("Eve", new DateTime(2024, 5, 1)));
        library.AddUser(new User("Fiona", new DateTime(2024, 6, 1)));
        library.AddUser(new User("George", new DateTime(2024, 7, 1)));
        library.AddUser(new User("Hannah", new DateTime(2024, 8, 1)));
        library.AddUser(new User("Ian"));
        library.AddUser(new User("Julia"));



        var booksPage = Library.GetBooks(page: 1, pageSize: 1);
        foreach (var book in booksPage1)
        {
            Console.WriteLine($"Book: {book.Title}");

        }

        var foundBooks = Library.FindBooksByTitle("1984");
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"Found Book: {book.Title}");

        }

        var bookToDeleteId = library.GetBooks(page: 1, pageSize: 1).First().Id;
        library.DeleteBook(bookToDeleteId);

        var allUsers = library.GetUsers(page: 1, pageSize: 10);
        foreach (var user in allUsers)
        {
            Console.WriteLine($"User: {user.Title}");

        }

    }
}