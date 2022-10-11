namespace RevitEvents;

public class DocumentChangedEventArgs
{
    private readonly List<int> _ids;
    public DocumentChangedEventArgs(List<int> ids)
    {
        _ids = ids;
       
    }

    public List<int> GetModifiedElementIds()
    {

        return _ids;
    }
}