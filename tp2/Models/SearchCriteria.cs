namespace tp2.Models;

public class SearchCriteria
{
    public string Keywords { get; set; }
    public bool? IsTextEditor { get; set; }
    public bool? IsIDE { get; set; }
    public bool? IsCommandLine { get; set; }
    
    public SearchCriteria()
    {
        Keywords = "";
        IsTextEditor = null;
        IsIDE = null;
        IsCommandLine = null;
    }
}