using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StringSearch
{
    public interface IStringSearchAlgorithm
    {
        IEnumerable<ISearchMatch> Search(string toFind, string toSearch);
    }

    public interface ISearchMatch
    {
        int Start { get; }

        int Length { get; }
    }
}
