using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2.Views.Home;

public class Index : PageModel, IEnumerable
{
    public void OnGet()
    {
        
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}