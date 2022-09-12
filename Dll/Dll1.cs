namespace Dll
{
    public class Dll1
    {
        public MyInnerClass GetSomethingFromDll()
        {
            var myInnerClass = new MyInnerClass();
            myInnerClass.MyInnerClass2 = new MyInnerClass2();
            return myInnerClass;
        }
    }

    public class MyInnerClass
    {
        public MyInnerClass2 MyInnerClass2 { get; set; }
    }

    public class MyInnerClass2
    {
        public static MyInnerClass3 MyStaticField = new MyInnerClass3("" +
                                                                      "Jane Doe");
    }

    public class MyInnerClass3
    {
        public string NameField = "John Doe";

        public MyInnerClass3(string nameField)
        {
            NameField = nameField;
        }
        


    }
}