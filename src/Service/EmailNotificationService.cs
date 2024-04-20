using sda_onsite_2_csharp_library_management.src.abstraction;

namespace sda_onsite_2_csharp_library_management.src.Service
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string title)
        {
            Console.WriteLine($"We encountered an issue adding {title}. Please review the input data. For more help, visit our FAQ at library.com/faq.");

        }
        public void SendNotificationOnSucess(string title)
        {
            Console.WriteLine($"Hello, a new book titled {title}  has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com.");

        }
    }
}