namespace tp2.Models;

public class SearchCriteria
{
    public string Keywords { get; init; }
    public bool IsTextEditor { get; init; }
    public bool IsIDE { get; init; }
    public bool IsCommandLine { get; init; }
    
    public SearchCriteria()
    {
        Keywords = "";
        IsTextEditor = true;
        IsIDE = true;
        IsCommandLine = true;
    }
}