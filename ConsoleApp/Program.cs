using DBContext;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func.CreateDB();
            Func.AddCommand();

        }
    }
}