namespace tp2.Models;

/// <summary>
/// Représente les critères de recherche.
/// </summary>
public class SearchCriteria
{
    public string Keywords { get; init; }
    public bool IsTextEditor { get; init; }
    public bool IsIDE { get; init; }
    public bool IsCommandLine { get; init; }
    
    public int MinimumRating { get; init; }
    public int MaximumRating { get; init; }
    
    /// <summary>
    /// Constructeur des critères de recherche.
    /// </summary>
    public SearchCriteria()
    {
        Keywords = "";
        IsTextEditor = true;
        IsIDE = true;
        IsCommandLine = true;
    }
}