namespace sda_onsite_2_csharp_library_management.src
{
    public class Book : BaseEntity
    {
        //property: id, title, created date
        public string Title { get; set; }



        public Book(string title, DateTime? createdAt = null) : base(createdAt)
        {
            Title = title;
        }

    }
}