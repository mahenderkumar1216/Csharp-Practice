﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern
{
    public interface IDatabaseBuilder
    {
        void BuildConnection();
        void BuildCommand();
        void SetSettings();
        AbstactDatabase Database { get; }
    }
}
