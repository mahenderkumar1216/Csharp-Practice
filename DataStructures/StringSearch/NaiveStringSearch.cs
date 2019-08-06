using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StringSearch
{
    public class NaiveStringSearch : Tracker<char>, IStringSearchAlgorithm
    {
        public IEnumerable<ISearchMatch> Search(string toFind, string toSearch)
        {
            if (toFind == null)
                throw new ArgumentNullException("toFind");
            if (toSearch == null)
                throw new ArgumentNullException("toSearch");


        }
    }
}
