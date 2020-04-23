using System;
using CsvHelper;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2020_draft_scorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var webGet = new HtmlWeb();
            webGet.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:31.0) Gecko/20100101 Firefox/31.0";
            var document1 = webGet.Load("https://www.spotrac.com/nfl/draft/2019/");

            Console.WriteLine(document1.ParsedText);
            //#content > table:nth-child(9)
            //html body div#outer div#wrapper2 div#content table
            ///html/body/div[3]/div[3]/div[1]/table[1]

            //List<DraftPick> list1 = getDraft(document1);
        }

        public static List<DraftPick> getDraft(HtmlAgilityPack.HtmlDocument doc)
        {
            List<DraftPick> draftPicks = new List<DraftPick>();
            return draftPicks;
        }
    }
}
