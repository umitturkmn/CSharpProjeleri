using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProjeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar.");
            Console.Write("İsminiz: ");
            string name = Console.ReadLine();
            Console.Write("Soyisminiz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Adınız ve Soyadınız: " + name +  " " + surname);
        }
    }
}