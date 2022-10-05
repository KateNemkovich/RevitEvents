using RevitEvents;

var controlledApplication = new ControlledApplication();
controlledApplication.DocumentChanged+=(sender, eventArgs) =>
{
    
};
controlledApplication.MoveElement();