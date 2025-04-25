using System;

namespace LibraryManagementSystem
{
    public static class Menu
    {
        public static void DisplayMenu(Media book, Media dvd, Media magazine)
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Management System:");
                Console.WriteLine("1. Borrow a media item");
                Console.WriteLine("2. Return a media item");
                Console.WriteLine("3. Check availability of media items");
                Console.WriteLine("4. Exit");
                Console.Write("Please enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BorrowMedia(book, dvd, magazine);
                        break;
                    case "2":
                        ReturnMedia(book, dvd, magazine);
                        break;
                    case "3":
                        CheckAvailability(book, dvd, magazine);
                        break;
                    case "4":
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;  
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        private static void BorrowMedia(Media book, Media dvd, Media magazine)
        {
            Console.WriteLine("\nWhich media would you like to borrow?");
            Console.WriteLine("1. The Great Gatsby (Book)");
            Console.WriteLine("2. Inception (DVD)");
            Console.WriteLine("3. National Geographic (Magazine)");
            Console.Write("Enter the media number (1-3): ");
            string mediaChoice = Console.ReadLine();

            switch (mediaChoice)
            {
                case "1":
                    LibraryService.BorrowMedia(book);
                    break;
                case "2":
                    LibraryService.BorrowMedia(dvd);
                    break;
                case "3":
                    LibraryService.BorrowMedia(magazine);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void ReturnMedia(Media book, Media dvd, Media magazine)
        {
            Console.WriteLine("\nWhich media would you like to return?");
            Console.WriteLine("1. The Great Gatsby (Book)");
            Console.WriteLine("2. Inception (DVD)");
            Console.WriteLine("3. National Geographic (Magazine)");
            Console.Write("Enter the media number (1-3): ");
            string mediaChoice = Console.ReadLine();

            switch (mediaChoice)
            {
                case "1":
                    LibraryService.ReturnMedia(book);
                    break;
                case "2":
                    LibraryService.ReturnMedia(dvd);
                    break;
                case "3":
                    LibraryService.ReturnMedia(magazine);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void CheckAvailability(Media book, Media dvd, Media magazine)
        {
            Console.WriteLine("\nAvailability of media items:");
            LibraryService.CheckAvailability(book);
            LibraryService.CheckAvailability(dvd);
            LibraryService.CheckAvailability(magazine);
        }
    }
}
