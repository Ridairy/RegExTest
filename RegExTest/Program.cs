using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExTest
{
    class Program
    {
        const string SiteUrl = "https://wellamart.ua/ru/katalog/dlya-detej/vse-dlya-detej/igrushki/?sort=cheap&fbclid=IwAR1PhD3mx3EpY2QqYHs858smxzmSDbKvVXQCLz-ARFvTNIrMA-P2b1u6nhA";
        static void Main(string[] args)
        {
            string htmlCode;
            List<String> Urls = new List<string>();
            string pattern = "<a href=\"(.*?)\" class=\"products\">";

            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(SiteUrl);
            }
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(htmlCode);
            if (matches.Count > 0)
            {
                foreach(Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
                Console.WriteLine(matches.Count);
            }
            { };
            Console.ReadKey();
 
        }
    }
}
