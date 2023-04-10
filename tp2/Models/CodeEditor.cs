namespace tp2.Models;

/// <summary>
/// Représente un éditeur de code.
/// </summary>
public class CodeEditor
{
    public string Name { get; set; }
    
    public EditorCategory EditorCategory { get; set; }
    
    public string Description { get; set; }
    
    public int PersonalRating { get; set; }

    public bool Favorite { get; set; }
    
    public int Id { get; set; }

    /// <summary>
    /// Constructeur par défaut.
    /// </summary>
    public void RetirerFavorie()
    {
        Favorite = false;
    }
}