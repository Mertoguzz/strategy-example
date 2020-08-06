using System;
using System.Collections.Generic;
using System.Text;

namespace Consumer
{
    class Consumer
    {
        public Consumer(Strategy strategy, string queueName)
        {
            strategy.Consume(queueName);
        }
    }
}
