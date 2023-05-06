namespace tp3.Models;

/// <summary>
/// Représente les résultats de recherche.
/// </summary>
public class SearchResults
{
    /// <summary>
    /// Liste des éditeurs de code.
    /// </summary>
    public List<CodeEditor> Editors { get; set; }
    
    /// <summary>
    /// Critères de recherche.
    /// </summary>
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