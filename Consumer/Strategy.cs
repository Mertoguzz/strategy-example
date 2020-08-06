using System;
using System.Collections.Generic;
using System.Text;

namespace Consumer
{
    abstract class Strategy
    {
        public abstract void Consume(string queueName);
    }
}
