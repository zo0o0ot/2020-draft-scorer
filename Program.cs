using System;
using CsvHelper;
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
            // Let's get the draft from a CSV instead of scraping it.
        }

        public static List<DraftPick> getDraft(HtmlAgilityPack.HtmlDocument doc)
        {
            List<DraftPick> draftPicks = new List<DraftPick>();
            return draftPicks;
        }
    }
}
