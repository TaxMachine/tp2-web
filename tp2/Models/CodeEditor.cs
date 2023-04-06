namespace tp2.Models;

public class CodeEditor
{
    public string Name { get; set; }
    
    public EditorCategory EditorCategory { get; set; }
    
    public string Description { get; set; }

    public bool Favorite { get; set; }
    
    public int Id { get; set; }

    public void RetirerFavorie()
    {
        Favorite = false;
    }

    public EditorCategory ConvertCategory(string category)
    {
        return category switch {
            "IDE" => EditorCategory.IDE,
            "TextEditor" => EditorCategory.TextEditor,
            "Terminal" => EditorCategory.Terminal,
            _ => EditorCategory.All
        };
    }
}