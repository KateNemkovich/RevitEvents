namespace RevitEvents;

public class ControlledApplication
{
    public event EventHandler <DocumentChangedEventArgs> DocumentChanged;

    public void MoveElement()
    {
        var ids = new List<int>();
        // Invoke вызывает событие(оповещает всех подписчиков).?проверяет является ли левая часть null,если нет, то выполняет правую часть.
        DocumentChanged?.Invoke(this, new DocumentChangedEventArgs(ids));
        
    }
}