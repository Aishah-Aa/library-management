namespace sda_onsite_2_csharp_library_management.src.abstraction
{
    public interface INotificationService
    {
         public void SendNotificationOnSucess(string title);
          public void SendNotificationOnFailure(string title);
    }
}