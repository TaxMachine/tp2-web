namespace tp3.Models;

/// <summary>
/// Représente un éditeur de code.
/// </summary>
public class CodeEditor
{
    
    /// <summary>
    /// Nom de l'éditeur de code.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Catégorie de l'éditeur de code.
    /// </summary>
    public EditorCategory EditorCategory { get; set; }
    
    /// <summary>
    /// Description de l'éditeur de code.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Note personnelle de l'éditeur de code.
    /// </summary>
    public int PersonalRating { get; set; }

    /// <summary>
    /// Si l'éditeur est favorie ou non.
    /// </summary>
    public bool Favorite { get; set; }
    
    /// <summary>
    /// L'id de l'éditeur de code.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Retire l'éditeur des favoris.
    /// </summary>
    public void RetirerFavorie()
    {
        Favorite = false;
    }
}