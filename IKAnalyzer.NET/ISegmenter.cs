﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKAnalyzer.NET
{
    public interface ISegmenter
    {
        void Analyze(AnalyzeContext context);
        void Reset();
    }
}
