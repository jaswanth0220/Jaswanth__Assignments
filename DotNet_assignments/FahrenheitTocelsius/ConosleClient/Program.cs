using FahrenheitTocelsius;

namespace ConosleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            Console.WriteLine(t.FTC(10));
            Console.WriteLine(t.CTF(10));
        }
    }
}
