using System.Formats.Tar;
using sda_onsite_2_csharp_library_management.src;
using sda_onsite_2_csharp_library_management.src.Service;

internal class Program
{
    private static void Main()
    {  
        var emailService = new EmailNotificationService();
        var library = new Library(emailService);
        

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
        var book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
        var book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
        var book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
        var book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
        var book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
        var book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        var book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));
        var book19 = new Book("The Iliad");
        var book20 = new Book("Anna Karenina");
        
        library.AddBook(book1);
        library.AddBook(book2); 
        library.AddBook(book3);
        library.AddBook(book4);
        library.AddBook(book5);
        library.AddBook(book6);
        library.AddBook(book7);
        library.AddBook(book8);
        library.AddBook(book9);
        library.AddBook(book10);
        library.AddBook(book11);
        library.AddBook(book12); 
        library.AddBook(book13);
        library.AddBook(book14);
        library.AddBook(book15);
        library.AddBook(book16);
        library.AddBook(book17);
        library.AddBook(book18);
        library.AddBook(book19);
        library.AddBook(book20);

        var books = library.GetBooks(1);

        Console.WriteLine("Before Removal:");
        
        foreach (var book in books)
        {
            Console.WriteLine($"Title = {book.Title} | ID = {book.Id}");

        }

        library.DeleteOneBook(book2.Id);

        Console.WriteLine("After Removal:");
        
        foreach (var book in books)
        {
            Console.WriteLine($"Title = {book.Title} | ID = {book.Id}");

        }
            
        Book ? FindBookById = library.FindOneBook(book4.Id);
            if (FindBookById != null)
            {
               Console.WriteLine($"{FindBookById.Title}");
                
            }

         var booksSorted = library.SortByDate();
         var booksSorted2 = library.SortByDate(sda_onsite_2_csharp_library_management.src.Constant.SortBy.Ascending);
         var booksSorted3 = library.SortByDate(sda_onsite_2_csharp_library_management.src.Constant.SortBy.Descending);
          
          Console.WriteLine("After Sorting: ");
        
        foreach (var book in booksSorted)
        {
            Console.WriteLine($"Title = {book.Title} | ID = {book.CreatedAt}");

        } 
         

         



        //     library.AddUser(new User("Alice", new DateTime(2023, 1, 1)));
        //     library.AddUser(new User("Bob", new DateTime(2023, 2, 1)));
        //     library.AddUser(new User("Charlie", new DateTime(2023, 3, 1)));
        //     library.AddUser(new User("David", new DateTime(2023, 4, 1)));
        //     library.AddUser(new User("Eve", new DateTime(2024, 5, 1)));
        //     library.AddUser(new User("Fiona", new DateTime(2024, 6, 1)));
        //     library.AddUser(new User("George", new DateTime(2024, 7, 1)));
        //     library.AddUser(new User("Hannah", new DateTime(2024, 8, 1)));
        //     library.AddUser(new User("Ian"));
        //     library.AddUser(new User("Julia"));





        

        //     var bookToDeleteId = library.GetBooks(page: 1, pageSize: 1).First().Id;
        //     library.DeleteBook(bookToDeleteId);

        //     var allUsers = library.GetUsers(page: 1, pageSize: 10);
        //     foreach (var user in allUsers)
        //     {
        //         Console.WriteLine($"User: {user.Title}");

        //     }

        // }
    }
}   