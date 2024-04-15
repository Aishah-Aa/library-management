namespace sda_onsite_2_csharp_library_management.src
{
    public class Library
    {
        private List<Book> books;
        private List<User> users;
    }

    public Library()
    {
        books = new List<Book>();
        users = new List<User>();
    }

    public IEnumerable<Book> GetBooks(int page, int pageSize)
    {
        return books.OrderBy(b => b.CreatedDate).Skip((page -1)*pageSize).Take(pageSize);
    }

    public IEnumerable<User> GetUsers(int page, int pageSize)
    {
        return users.OrderBy(u => u.CreatedDate).Skip((page -1)*pageSize).Take(pageSize);
    }

    public IEnumerable<Book> FindBooksByTitle(string title)
    {
        return books.Where(b => b.Contains(title, StringComparison.OrdinalIgnoreCase));//.Skip((page -1)*pageSize).Take(pageSize);
    }

    public IEnumerable<User> FindUsersByName(string name)
    {
        return users.Where(u => u.Title.Contains(name, StringComparison.OrdinalIgnoreCase)); //*pageSize).Take(pageSize);
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void DeleteBook(Guid id)
    {
        var bookToDelete = books.FirstOrDefault(b => b.Id == id);
        if (bookToDelete != null)
        {
            books.Remove(bookToDelete);
        }
    }

    public void DeleteUser(Guid id)
    {
        var userToDelete = users.FirstOrDefault(u => u.Id == id);
        if (usersToDelete != null)
        {
            users.Remove(userToDelete);
        }
    }
}

