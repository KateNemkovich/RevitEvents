namespace RevitEvents;

public class ControlledApplication
{
    public event EventHandler <DocumentChangedEventArgs> DocumentChanged;

    public void MoveElement()
    {
        var _rnd = new Random();
        var ids = new List<int>();
        ids.Add(_rnd.Next(1_000_000));
        ids.Add(_rnd.Next(1_000_000));
        ids.Add(_rnd.Next(1_000_000));
        // Invoke вызывает событие(оповещает всех подписчиков).?проверяет является ли левая часть null,если нет, то выполняет правую часть.
        DocumentChanged?.Invoke(this, new DocumentChangedEventArgs(ids));
        
    }
}