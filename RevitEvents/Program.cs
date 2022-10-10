using System.Diagnostics;
using RevitEvents;

var controlledApplication = new ControlledApplication();
    //Анонимный метод (чтобы не давать название методу)
controlledApplication.DocumentChanged+=(sender, eventArgs) =>
{
    foreach (var id in eventArgs.GetModifiedElementIds())
    {
        Console.Write($"Deleted:{id}");
    }
   
};
controlledApplication.MoveElement();