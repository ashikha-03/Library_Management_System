namespace LibraryManagementSystem
{
    public static class LibraryService
    {
        public static void BorrowMedia(Media media)
        {
            media.Borrow();
        }

        public static void ReturnMedia(Media media)
        {
            media.Return();
        }

        public static void CheckAvailability(Media media)
        {
            media.CheckAvailability();
        }
    }
}
