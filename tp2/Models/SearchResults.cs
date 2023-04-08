namespace tp2.Models;

public class SearchResults
{
    public List<CodeEditor> Editors { get; set; }
    public SearchCriteria Criteria { get; set; }
    
    public SearchResults()
    {
        Editors = new List<CodeEditor>();
        Criteria = new SearchCriteria();
    }
}