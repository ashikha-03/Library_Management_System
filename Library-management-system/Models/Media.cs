public abstract class Media
{
    public string Title { get; set; }
    public bool IsAvailable { get; set; }
    public abstract void DisplayInfo();  
}
