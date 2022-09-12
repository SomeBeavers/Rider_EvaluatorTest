namespace Net7_Console;

public class Code1
{
    public static int StaticField = 1;
    public void Test1(List<InnerClass> innerClass)
    {
        // lambda
        var count = innerClass.Where(x => MethodCallInLambda(x)).Count();
        StaticField ++;
        
        // ternary expression

        var ternaryResult = innerClass.FirstOrDefault() != null
            ? Method1()
            : Method2();
    }

    public int Recursion(int i)
    {
        //return Recursion(i);
        return 1;
    }

    private InnerClass Method2()
    {
        return null;
    }

    private InnerClass Method1()
    {
        return new InnerClass(){Name = "test"};
    }

    public static bool MethodCallInLambda(InnerClass x)
    {
        StaticField++;
        return x.Name.Equals("Jane Doe");
    }
}

public class InnerClass
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
}