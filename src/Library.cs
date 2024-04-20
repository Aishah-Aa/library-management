using sda_onsite_2_csharp_library_management.src.abstraction;
using sda_onsite_2_csharp_library_management.src.Constant;
using sda_onsite_2_csharp_library_management.src.Service;

namespace sda_onsite_2_csharp_library_management.src
{
     public class Library
     {
          private IEnumerable<Book> _books = [];

          private EmailNotificationService _emailNotificationService;

          public Library(EmailNotificationService emailNotificationService)
          {
               _emailNotificationService = emailNotificationService;
          }

          public IEnumerable<Book> GetBooks()
          {
               return _books;
          }

          public IEnumerable<Book> GetBooks(int page)
          {
               var itemsPerPage = 3;
               var offset = (page - 1) * itemsPerPage;
               var paginated = _books.Skip(offset).Take(itemsPerPage);
               return paginated;
          }
          public IEnumerable<Book> AddBook(Book newBook)
          {
               var bookFound = _books.FirstOrDefault(book => book.Title == newBook.Title);

               if (bookFound != null)
               {
                    _emailNotificationService.SendNotificationOnFailure(newBook.Title);
                    return _books;
               }

               _books = _books.Append(newBook);
               _emailNotificationService.SendNotificationOnSucess(newBook.Title);
               return _books;
          }
          public Book? FindOneBook(Guid id)
          {
               return _books.FirstOrDefault(book => book.Id == id);
          }

          public IEnumerable<Book> DeleteOneBook(Guid id)
          {
               _books = _books.Where((book) => book.Id != id);
               return _books;
          }
          public IEnumerable<Book> SortByDate(SortBy? sortBy = SortBy.Ascending)
          {
               if (sortBy == SortBy.Ascending)
               {
                    return _books.OrderBy((book) => book.CreatedAt);
               }
               else
               {
                    return _books.OrderByDescending((book) => book.CreatedAt);
               }

          }


          // public IEnumerable<User> GetUsers(int page, int pageSize)
          // {
          //     return users.OrderBy(u => u.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
          // }



          // public IEnumerable<User> FindUsersByName(string name)
          // {
          //     return users.Where(u => u.Title.Contains(name, StringComparison.OrdinalIgnoreCase)); 
          // }

          // public void AddBook(Book book)
          // {
          //     books.Add(book);
          // }

          // public void AddUser(User user)
          // {
          //     users.Add(user);
          // }



          // public void DeleteUser(Guid id)
          // {
          //     var userToDelete = users.FirstOrDefault(u => u.Id == id);
          //     if (usersToDelete != null)
          //     {
          //         users.Remove(userToDelete);
          //     }
          // }
     }
}

