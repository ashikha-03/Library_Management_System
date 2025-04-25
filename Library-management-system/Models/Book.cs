using System;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Utils;
namespace LibraryManagementSystem.Models
{
    public class Book : Media, IBorrowable
    {
        public string ISBN { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}, ISBN: {ISBN}, Available: {IsAvailable}");
        }
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Logger.Log($"{Title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available for borrowing.");
            }
        }
        public void Return()
        {
            IsAvailable = true;
            Logger.Log($"{Title} has been returned.");
        }
    }
}
