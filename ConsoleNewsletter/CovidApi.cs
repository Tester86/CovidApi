using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using static ConsoleNewsletter.Codes;

namespace ConsoleNewsletter
{
    class CovidApi
    {

        public CovidApi()
        {
            data = new List<string>();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.worldometers.info/coronavirus/");

            raw_data = doc.DocumentNode.CssSelect(".maincounter-number");

            foreach(var node in raw_data)
            {
                var final_numbers = node.CssSelect("span").First();
                data.Add(final_numbers.InnerHtml);
                
            }
        }
 
       public string getInfected()
        {
            return data[Codes.INFECTED];
        }

        public string getDead()
        {
            return data[Codes.DEAD];
        }

        public string getRecovered()
        {
            return data[Codes.RECOVERED];
        }

        public List<string> getAllData()
        {
            return data;
        }

        protected void Update()
        {
            data.Clear();
            data[Codes.INFECTED] = getInfected();
            data[Codes.DEAD] = getDead();
            data[Codes.RECOVERED] = getRecovered();
        }

        private static IEnumerable<HtmlNode> raw_data;
        private static List<string> data;

        
    }
}
