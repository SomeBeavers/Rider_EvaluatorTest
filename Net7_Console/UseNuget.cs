using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Net7_Console;

public class UseNuget
{
    public static int MyStaticField = 1;

    public UseNuget()
    {
        JsonConverter jc = new StringEnumConverter();
        MyStaticField++;
    }

    public override string ToString()
    {
        //MyStaticField++;
        return $"Static field: {MyStaticField}";
    }
}