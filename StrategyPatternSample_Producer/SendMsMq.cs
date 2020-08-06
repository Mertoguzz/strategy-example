using StrategyPatternSample_Producer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSample
{
    class SendMsMq : Strategy
    {
        public override void Send(string topic, EmailMessage messageBase)
        {
            //throw new NotImplementedException();
        }
    }
}
