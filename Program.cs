namespace Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var mainBranch = EnumTest.MainBranch;
            System.Console.WriteLine(mainBranch);

            var anotherBranch = EnumTest.AnotherBranch;
            System.Console.WriteLine(anotherBranch);
        }
    }
}
