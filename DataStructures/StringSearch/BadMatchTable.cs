using System.Collections.Generic;

namespace DataStructures.StringSearch
{
    class BadMatchTable
    {
        private readonly int _defaultvalue;
        private readonly Dictionary<int, int> _distances;

        public BadMatchTable(string pattern)
        {
            _defaultvalue = pattern.Length;
            _distances = new Dictionary<int, int>();

            for (int i = 0; i < pattern.Length - 1; i++)
            {
                _distances[pattern[i]] = pattern.Length - i - 1;
            }
        }
    }
}
