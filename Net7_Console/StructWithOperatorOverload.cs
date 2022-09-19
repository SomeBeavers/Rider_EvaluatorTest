using System.Diagnostics;

namespace Net7_Console;

[DebuggerDisplay("Name = {Name}")]
public class StructWithOperatorOverload
{
    public string Name;
    public InnerStruct InnerStruct;

    public StructWithOperatorOverload(string name)
    {
        Name = name;
    }

    public static StructWithOperatorOverload operator +(StructWithOperatorOverload a, StructWithOperatorOverload b)
        => new(a.Name + b.Name);
}

public struct InnerStruct
{
    public int Age;
}