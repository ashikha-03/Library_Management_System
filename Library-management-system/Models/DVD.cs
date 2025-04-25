using System;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Utils;
namespace LibraryManagementSystem.Models
{
    public class DVD : Media, IBorrowable
    {
        public string RegionCode { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD Title: {Title}, Region Code: {RegionCode}, Available: {IsAvailable}");
        }
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Logger.Log($"{Title} has been borrusing System;
using LibraryManagementSystem.Interfaces;
                using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem.Models
    {
        public class DVD : Media, IBorrowable
        {
            public string RegionCode { get; set; }

            public DVD(string title, string regionCode) : base(title)
            {
                RegionCode = regionCode;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"DVD Title: {Title}, Region: {RegionCode}, Available: {IsAvailable}");
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
    owed.");
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
