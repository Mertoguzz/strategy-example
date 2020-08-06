using StrategyPatternSample_Producer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSample
{
    abstract class Strategy
    {
        public abstract void Send(string queueName,EmailMessage messageBase);

     
    }
}
