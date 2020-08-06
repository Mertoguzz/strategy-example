using StrategyPatternSample_Producer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSample
{
    class Sender
    {
        public Sender(Strategy strategy,string queueName,EmailMessage messageBase )
        {
            strategy.Send(queueName, messageBase);
        }
    }
}
