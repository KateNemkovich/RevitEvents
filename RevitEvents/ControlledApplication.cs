namespace RevitEvents;

public class ControlledApplication
{
    public event EventHandler <DocumentChangedEventArgs> DocumentChanged;

    public void MoveElement()
    {
        // Invoke вызывает событие(оповещает всех подписчиков).?проверяет является ли левая часть null,если нет, то выполняет правую часть.
        DocumentChanged?.Invoke(this, new DocumentChangedEventArgs());
    }
}