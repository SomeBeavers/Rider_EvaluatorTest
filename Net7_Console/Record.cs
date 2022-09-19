namespace Net7_Console;

public record Record(InnerStruct1 InnerStruct1, string Name)
{
    public static int Count = 0;

    public string AddCount()
    {
        Count++;
        return Name + Count;
    }
}

public struct InnerStruct1
{
    public string StructField;

    public InnerStruct1(string structField)
    {
        StructField = structField;
    }
}