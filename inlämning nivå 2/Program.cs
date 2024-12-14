using System;
using System.Diagnostics;
using System.Runtime.Serialization.Json;
namespace Inlämning_nivå_2
{
    class Program

    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("skriv in ett tal");
                int tal  =int.Parse(Console.ReadLine());
                if (tal == 0)
                {
                    break;
                }
                Console.WriteLine("programmet avslutas");
                
            }

        }
    }


}
