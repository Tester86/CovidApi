using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using static ConsoleNewsletter.CovidApi;

namespace ConsoleNewsletter
{
    class Program
    {
        static void Main(string[] args)
        {

            CovidApi api = new CovidApi();
            Console.WriteLine("Infectados: " + api.getInfected());
            Console.WriteLine("Muertos: " + api.getDead());
            Console.WriteLine("Recuperados: " + api.getRecovered());

            
        }
    }
}
