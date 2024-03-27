using TestConsole.Interface;
using TestConsole.Decorator;

namespace TestConsole.ConcreteComponent{
public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Hello, This is the first assignment of the Modular Development";
    }
}}