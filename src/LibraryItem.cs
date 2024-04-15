namespace sda_onsite_2_csharp_library_management.src
{
    public class LibraryItem
    {
        private string Title {get:}
       private Guid Id {get:}
       private DateTime CreatedDate {get:} 

       private LibraryItem(string title, DateTime? createdDate = null)
       {
            Id = Guid.NewGuid();
            Title =  new title();
            CreatedDate = createdDate DateTime.Now; 
       }
    }
}