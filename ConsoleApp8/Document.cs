using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Document
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public Document(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"{Title} ({Pages} pages)";
        }
    }
}
