using System.Diagnostics;
using RevitEvents;

var controlledApplication = new ControlledApplication();
    //Анонимный метод (чтобы не давать название методу)
controlledApplication.DocumentChanged+=(sender, eventArgs) =>
{
    foreach (var id in eventArgs.GetModifiedElementIds())
    {
        Console.WriteLine($"Modified element:{id}");
    }
   
};
while (true)
{
   controlledApplication.MoveElement();
    //Замораживает поток на указанное время
   Thread.Sleep(TimeSpan.FromSeconds(1));
}
