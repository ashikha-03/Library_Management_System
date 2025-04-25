using LibraryManagementSystem.Enums;  // This ensures UserRole is recognized

namespace LibraryManagementSystem.Models
{
    public class User
    {
        public string Name;
        public string Email;
        public UserRole Role;  // Now it will recognize the UserRole enum
    }
}
