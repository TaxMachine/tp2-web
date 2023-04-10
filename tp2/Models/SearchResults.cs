namespace tp2.Models;

/// <summary>
/// Représente les résultats de recherche.
/// </summary>
public class SearchResults
{
    public List<CodeEditor> Editors { get; set; }
    public SearchCriteria Criteria { get; set; }
    
    /// <summary>
    /// Constructeur des résultats de recherche.
    /// </summary>
    public SearchResults()
    {
        Editors = new List<CodeEditor>();
        Criteria = new SearchCriteria();
    }
}