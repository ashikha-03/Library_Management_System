using System;

namespace LibraryManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            var book = new Media("The Great Gatsby");
            var dvd = new Media("Inception");
            var magazine = new Media("National Geographic");
            Menu.DisplayMenu(book, dvd, magazine);
        }
    }
}
