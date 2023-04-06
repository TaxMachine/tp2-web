namespace tp2.Models;

public class CodeEditor
{
    public string Name { get; set; }
    
    public string Category { get; set; }
    
    public string Description { get; set; }

    public bool Favorite { get; set; }
    
    public int Id { get; set; }

    public void RetirerFavorie()
    {
        Favorite = false;
    }
}