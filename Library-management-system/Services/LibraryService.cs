using LibraryManagementSystem.Interfaces;  
namespace LibraryManagementSystem.Services
{
    public class LibraryService
    {
        public void BorrowItem(Media media)
        {
            if (media is IBorrowable borrowableMedia)
            {
                borrowableMedia.Borrow();
            }
            else
            {
                System.Console.WriteLine("This media item cannot be borrowed.");
            }
        }

        public void ReturnItem(Media media)
        {
            if (media is IBorrowable borrowableMedia)
            {
                borrowableMedia.Return();
            }
            else
            {
                System.Console.WriteLine("This media item cannot be returned.");
            }
        }

        public void DisplayItemInfo(Media media)
        {
            media.DisplayInfo();
        }
    }
}
