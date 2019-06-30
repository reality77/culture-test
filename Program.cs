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

            /*
                Results with "dotnet run"
                > dotnet run
                    Bonjour, le jour est dimanche (<= day in french)
            
                Results with docker
                > docker build -t culture-test .
                > docker run culture-test
                    Bonjour, le jour est Sunday (<= day in english)

             */
        }
    }
}
