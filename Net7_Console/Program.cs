// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Xml;
using Net7_Console;using Net7_Lib;

AllowDisabled1.M();

var innerClasses = new List<InnerClass>();
var item = new InnerClass(){Name = "Jane Doe"};
innerClasses.Add(item);
innerClasses.Add(item);
var code1 = new Code1();
code1.Test1(innerClasses);
string LocalFunc()
{
    return null;
}

Console.WriteLine();

LocalFunc();
LocalFunc();

code1.Recursion(2);

var useNuget = new UseNuget();
var s = useNuget.ToString();

Console.WriteLine(UseNuget.MyStaticField);


var classWithProperties = new ClassWithProperties();

var (name, field, list) = new ClassWithProperties();

Console.WriteLine(classWithProperties);
Console.WriteLine(name);
Console.WriteLine(field);
Console.WriteLine(list);


var struct1 = new StructWithOperatorOverload("Test");
var struct2 = new StructWithOperatorOverload(" Name");

Console.WriteLine("");
Console.WriteLine(struct1 + struct2);



void LocalMethod()
{
    using var x = new ClassWithProperties();
}

LocalMethod();


var record = new Record(new InnerStruct1("My test name"), "Test");


Console.WriteLine(record.Name);


IInterfaceWithDefault myClass = new ClassImplementingInterface();

Console.WriteLine(myClass);

myClass.TestDefault();

var methods = new Methods();

await methods.MethodAsync();

methods.AnonymousMethod("dog");
Methods.StaticMethod(out var myInnerMethod);


var staticFields = new StaticFields();

dynamic staticField = StaticFields.StaticField;

Console.WriteLine(staticField);

string s22 = "test";
var v = new { Amount = 108, Message = "Hello" };

Console.WriteLine(v.Amount + v.Message);

var loops = new Loops();
loops.Test(new List<LoopsInnerClass>()
{
    new LoopsInnerClass()
    {
        Name = "jane doe",
        Ints = new(){1,2,3,4,5,6}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    },
    
    new LoopsInnerClass()
    {
        Name = "john doe",
        Ints = new(){1,2,3}
    }
});

// Console.WriteLine("Hello, World!");
// int t = 1;
// var t2 = t++;
// TextWriter _out = new StreamWriter(Stream.Null, Encoding.Default);
// Console.WriteLine(t2);
//
// var class1 = new Class1();
//
// class1.Test();
//
// var useNuget = new UseNuget();
