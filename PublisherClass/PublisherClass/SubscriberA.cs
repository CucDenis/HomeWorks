using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PublisherClass
{
    class SubscriberA
    {
        public string Name { get; set; }

        public SubscriberA(string name, Publisher pb)
        {
            Name = name;
            pb.Eveniment += Subscribe;
        }

        public void Subscribe(int i)
        {
            for (int j  = 0; j < i; j++)
            {
                Console.WriteLine("One more subscriber");
                Thread.Sleep(2000);
                Publisher.numberOfSubscribers++;
                Console.WriteLine("Number of subscribers: {0}", Publisher.numberOfSubscribers);
            }
        }

    }
}
