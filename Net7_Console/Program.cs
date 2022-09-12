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
