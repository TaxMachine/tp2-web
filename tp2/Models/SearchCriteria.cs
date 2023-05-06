namespace tp3.Models;

/// <summary>
/// Représente les critères de recherche.
/// </summary>
public class SearchCriteria
{
    
    /// <summary>
    /// Mots-clés de recherche.
    /// </summary>
    public string Keywords { get; init; }
    
    /// <summary>
    /// Si l'éditeur est un éditeur de texte.
    /// </summary>
    public bool IsTextEditor { get; init; }
    
    /// <summary>
    /// Si l'éditeur est un IDE.
    /// </summary>
    public bool IsIde { get; init; }
    
    /// <summary>
    /// Si l'éditeur est un éditeur de ligne de commande.
    /// </summary>
    public bool IsCommandLine { get; init; }
    
    /// <summary>
    /// Note minimale de l'éditeur.
    /// </summary>
    public int MinimumRating { get; }
    
    /// <summary>
    /// Note maximale de l'éditeur.
    /// </summary>
    public int MaximumRating { get; }
    
    /// <summary>
    /// Constructeur des critères de recherche.
    /// </summary>
    public SearchCriteria()
    {
        MinimumRating = 0;
        MaximumRating = 10;
        Keywords = "";
        IsTextEditor = false;
        IsIde = false;
        IsCommandLine = false;
    }
}