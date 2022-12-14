using System.Collections;

namespace Net7_Console;

public class ClassWithProperties:IDisposable
{
    public void Deconstruct(out string name, out int myReadonlyField, out List<AnotherClass> listAutoProperty)
    {
        name = _name;
        myReadonlyField = MyReadonlyField;
        listAutoProperty = ListAutoProperty;
    }

    private string _name;

    public ClassWithProperties(List<AnotherClass> listAutoProperty)
    {
        ListAutoProperty = listAutoProperty;
    }

    public ClassWithProperties():
        this(new List<AnotherClass>
        {
            new(1, "a"),
            new(2, "b")
        })
    {
        _name = "test name";

        List<int> myCollection = new List<int>(){1,2,3,4,5,6};
        int x = 0;
        while (x <100)
        {
            myCollection.Add(x);
            x++;
        }
        foreach (var s in myCollection)
        {
            MyStaticField += s;
            MyReadonlyField += 1;
        }

        var myRecord = new MyRecord(new List<string>(){"1", "2", "3"}, 1);
    }

    private static int MyStaticField = 0;
    private readonly int MyReadonlyField = 0;
    public const string MyConstField = "const string";
    
    public List<AnotherClass> ListAutoProperty { get; set; }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public void Dispose()
    {
        Console.WriteLine(Name);
        Name = "";
        // this.Dispose();
    }
}

record MyRecord(List<string> Names, int i)
{
    
}

public class AnotherClass
{
    private int _age;

    public AnotherClass(int age, string name)
    {
        _age = age;
        Name = name;
    }

    public string Name { get; set; }

    public int Age
    {
        get => _age;
        set => _age = value;
    }
}