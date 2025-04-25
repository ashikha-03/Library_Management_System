using System;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem.Models
{
    public class Magazine : Media, IBorrowable
    {
        public string IssueNumber { get; set; }

        public Magazine(string title, string issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Title: {Title}, Issue: {IssueNumber}, Available: {IsAvailable}");
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
