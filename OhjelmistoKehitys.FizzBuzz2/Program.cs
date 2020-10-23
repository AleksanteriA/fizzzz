using System;

namespace OhjelmistoKehitys.FizzBuzz2



{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("FizzBuzz-ohjelma");
                    Console.WriteLine("-------------------");

                    Console.WriteLine("Anna luku 1-100");

                    int syöte = int.Parse(Console.ReadLine());

                    if(syöte > 100)
                    {
                        Console.Clear();
                        Console.WriteLine("Liian suuri luku");
                        Console.WriteLine("Palaa enterillä");
                        Console.ReadLine();
                        continue;
                    }

                    if (syöte < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Liian pieni luku");
                        Console.WriteLine("Palaa enterillä");
                        Console.ReadLine();
                        continue;
                    }

                    var fizzBuzz = new FizzBuzz();
                    var vastaus = fizzBuzz.Luku(syöte);

                    Console.WriteLine(vastaus);
                    Console.WriteLine("Palaa enterillä");
                    Console.ReadLine();
                }

                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Palaa enterillä");
                    Console.ReadLine();
                }


            }

        }
    }
}
