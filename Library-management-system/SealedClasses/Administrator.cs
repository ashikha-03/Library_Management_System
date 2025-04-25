using LibraryManagementSystem.Models;  // Ensures User is recognized

namespace LibraryManagementSystem.SealedClasses
{
    public sealed class Administrator
    {
        public User UserInfo { get; set; }  // Composition: User is a property

        public void ManageSystem()
        {
            System.Console.WriteLine("Managing the Library System.");
        }
    }
}
