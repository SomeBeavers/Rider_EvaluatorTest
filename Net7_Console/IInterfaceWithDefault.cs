namespace Net7_Console;

public interface IInterfaceWithDefault
{
    public string TestDefault(string? s = "test")
    {
        return s ?? "Jane Doe";
    }
}

public class ClassImplementingInterface : IInterfaceWithDefault
{
}