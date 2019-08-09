using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StringSearch
{
    class BoyerMoore : Tracker<char>, IStringSearchAlgorithm
    {
        public IEnumerable<ISearchMatch> Search(string toFind, string toSearch)
        {
            if (toFind == null)
                throw new ArgumentNullException("toFind");
            if (toSearch == null)
                throw new ArgumentNullException("toSearch");
            if (toFind.Length > 0 && toSearch.Length > 0)
            {
                BadMatchTable badMatchTable = new BadMatchTable(toFind);

                int currentStartIndex = 0;
                while (currentStartIndex <= toSearch.Length - toFind.Length)
                {
                    
                }
            }
            return null;
        }
    }
}
