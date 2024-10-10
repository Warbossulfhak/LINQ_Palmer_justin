using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Palmer_justin
{
    internal class Games
    {// properties with automatic getters

        public string Title { get; }

        public char Esrb { get; } 

        public string Genre { get; }

        public Games(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }



    }
}
