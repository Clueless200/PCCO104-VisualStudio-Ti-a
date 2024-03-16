namespace PCCO104_VisualStudio_Tiña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            string[] names = { "Name1", "Name2" };
            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.ReadKey();
        }
    }
}