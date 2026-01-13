


namespace metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            Console.WriteLine("Hello, World!");
            PrintHeader();
            GetSqure(5);
            Console.WriteLine(GetSqure(5));


        }

        private static void PrintHeader()
        {
            Console.WriteLine("-------------");


        }

        private static double GetSqure(double num)
        {
            return num * num; 
        }
    }
}
