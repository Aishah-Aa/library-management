namespace sda_onsite_2_csharp_library_management.src
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public User(string name, DateTime? createdAt = null) : base(createdAt)
        {
            Name = name;

        }
    }
}