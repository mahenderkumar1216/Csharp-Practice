using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StringSearch
{
    class AlgorithmSelector
    {
        public string Name { get; private set; }
        public IStringSearchAlgorithm Algorithm { get; private set; }

        public AlgorithmSelector(string name, IStringSearchAlgorithm algorithm)
        {
            Name = name;
            Algorithm = algorithm;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
