public abstract class Media
{
    private string Title; 
    protected bool IsAvailable; 
    internal MediaType MediaType; 

    public Media(string title, MediaType mediaType)
    {
        Title = title;
        MediaType = mediaType; 
        IsAvailable = true;
    }

    public void CheckAvailability()
    {
        Console.WriteLine($"The item '{Title}' is {(IsAvailable ? "available" : "not available")}. Type: {MediaType}");
    }

    public virtual void Borrow();
    public virtual void Return();
}
