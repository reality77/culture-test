using System;
using System.Globalization;

namespace culture_test
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine($"Bonjour, le jour est {DateTime.Now.ToString("dddd")}");
        }
    }
}
