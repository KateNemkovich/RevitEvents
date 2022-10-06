using RevitEvents;

var controlledApplication = new ControlledApplication();
    //Анонимный метод (чтобы не давать название методу)
controlledApplication.DocumentChanged+=(sender, eventArgs) =>
{
    Console.WriteLine("Something");
};
controlledApplication.MoveElement();