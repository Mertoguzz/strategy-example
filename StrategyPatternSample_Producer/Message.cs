using StrategyPatternSample_Producer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSample
{
    class EmailMessage 
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

    }
}
