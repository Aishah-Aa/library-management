namespace sda_onsite_2_csharp_library_management.src
{
    public abstract class BaseEntity
    {
        
       public Guid Id { get;  } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; }

       public BaseEntity( DateTime? createdAt)
        {
            
            CreatedAt = createdAt ?? DateTime.Now;
        }
    }
}