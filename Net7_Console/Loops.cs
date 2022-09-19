namespace Net7_Console;

public class Loops
{
    public static int StaticField = 0;
    
    public void Test(List<LoopsInnerClass> list)
    {
        foreach (var innerClass in list)
        {
            Console.WriteLine(innerClass);
        }

        int x = 0;
        while (x < 1000)
        {
            var ints = new List<int>();

            for (int i = 0; i < x; i++)
            {
                ints.Add(i);
            }
            list.Add(new LoopsInnerClass(){Name = x.ToString(), 
                Ints = ints
            });
            x++;
        }
    }
}

public class LoopsInnerClass
{
    public string Name { get; set; }
    public List<int> Ints { get; set; }
}