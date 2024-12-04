using System;
namespace inluppg32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jahopp, du vill jobba hos oss. har du gått ut gymnasium? säg j för ja och n för nej");
            string jellern = Console.ReadLine();
            Console.WriteLine("ok. och din åldrighet vad är den?");
            int ulder = int.Parse(Console.ReadLine());
            if (jellern == "j" && ulder <= 22)
            {
                Console.WriteLine("du är godkänd till anställdheten. kom imorn annars är du sparkad :)");

            }
            else
            {
                Console.WriteLine("stick härifrån ecklig");
            }
        }
   
    }

}


