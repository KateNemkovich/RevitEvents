namespace RevitEvents;

public class ControlledApplication
{
    public event EventHandler <DocumentChangedEventArgs> DocumentChanged;

    public void MoveElement()
    {
        DocumentChanged(sender:,e:);
    }
}