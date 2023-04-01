using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tp2.Models;

namespace tp2.Views.Editors;

public class Favorites : PageModel, IEnumerable<CodeEditor>
{
    public void OnGet()
    {
        
    }

    public IEnumerator<CodeEditor> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}