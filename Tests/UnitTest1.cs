namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var list = new List<int>();
            var method1 = list.Count == 0 ? Method1() : list.First();
            Console.WriteLine(method1);
            Assert.Pass();
        }

        private int Method1()
        {
            return 1;
        }
    }
}