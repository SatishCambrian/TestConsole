using TestConsole.Decorator;
using TestConsole.Interface;


namespace TestConsole.Decorator{
public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component) { }

    public override string GetText()
    {
        return $"\u001b[31m{base.GetText()}\u001b[0m";
    }
}
}

