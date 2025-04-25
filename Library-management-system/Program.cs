using System;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            Book book1 = new Book { Title = "The Great Gatsby", ISBN = "9780743273565", IsAvailable = true };
            Magazine magazine1 = new Magazine { Title = "National Geographic", IssueNumber = "2025-01", IsAvailable = true };
            DVD dvd1 = new DVD { Title = "Inception", RegionCode = "Region 1", IsAvailable = true };

            LibraryService libraryService = new LibraryService(); 

            Console.WriteLine("Welcome to the Library!");
            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Borrow a media");
                Console.WriteLine("2. Return a media");
                Console.WriteLine("3. Check availability of a media item");
                Console.WriteLine("4. Exit");
                Console.Write("Please enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BorrowMedia(libraryService, book1, magazine1, dvd1);
                        break;
                    case "2":
                        ReturnMedia(libraryService, book1, magazine1, dvd1);
                        break;
                    case "3":
                        CheckAvailability(book1, magazine1, dvd1);
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Library Management System!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        // Mark these methods as 'internal' since they are only needed within this assembly
        internal static void BorrowMedia(LibraryService libraryService, Book book, Magazine magazine, DVD dvd)
        {
            Console.WriteLine("\nWhich media would you like to borrow?");
            Console.WriteLine("1. The Great Gatsby (Book)");
            Console.WriteLine("2. National Geographic (Magazine)");
            Console.WriteLine("3. Inception (DVD)");
            Console.Write("Enter the media number (1-3): ");
            string mediaChoice = Console.ReadLine();

            switch (mediaChoice)
            {
                case "1":
                    libraryService.BorrowItem(book);
                    break;
                case "2":
                    libraryService.BorrowItem(magazine);
                    break;
                case "3":
                    libraryService.BorrowItem(dvd);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        internal static void ReturnMedia(LibraryService libraryService, Book book, Magazine magazine, DVD dvd)
        {
            Console.WriteLine("\nWhich media would you like to return?");
            Console.WriteLine("1. The Great Gatsby (Book)");
            Console.WriteLine("2. National Geographic (Magazine)");
            Console.WriteLine("3. Inception (DVD)");
            Console.Write("Enter the media number (1-3): ");
            string mediaChoice = Console.ReadLine();

            switch (mediaChoice)
            {
                case "1":
                    libraryService.ReturnItem(book);
                    break;
                case "2":
                    libraryService.ReturnItem(magazine);
                    break;
                case "3":
                    libraryService.ReturnItem(dvd);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        internal static void CheckAvailability(Book book, Magazine magazine, DVD dvd)
        {
            Console.WriteLine("\nCurrent availability:");
            Console.WriteLine($"The Great Gatsby (Book): {(book.IsAvailable ? "Available" : "Not Available")}");
            Console.WriteLine($"National Geographic (Magazine): {(magazine.IsAvailable ? "Available" : "Not Available")}");
            Console.WriteLine($"Inception (DVD): {(dvd.IsAvailable ? "Available" : "Not Available")}");
        }
    }
}
