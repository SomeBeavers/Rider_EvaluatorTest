namespace Net7_Console;

public class Methods
{
    public delegate void petanim(string pet);
    public static int StaticMethod(out InnerMethodsClass innerMethodsClass)
    {
        innerMethodsClass = new InnerMethodsClass();
        return innerMethodsClass.Age;
    }

    public async Task<InnerMethodsClass> MethodAsync()
    {
        await Task.Delay(1000);
        return new InnerMethodsClass();
    }

    public void AnonymousMethod(in string pet)
    {
        petanim p = delegate(string mypet)
        {
            Console.WriteLine("My favorite pet is: {0}",
                mypet);
        };
        p(pet);
    }

    public class InnerMethodsClass
    {
        public int Age { get; set; }
    }
}