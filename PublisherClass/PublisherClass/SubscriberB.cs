using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PublisherClass
{
    class SubscriberB
    {

        public string Name { get; set; }

        public SubscriberB(string name, Publisher pb)
        {
            Name = name;
            pb.Eveniment += Comment;
        }

        public void Comment(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("One more comment");
                Thread.Sleep(5000);
                Publisher.numberOfComments++;
                Console.WriteLine("Number of comments: {0}", Publisher.numberOfComments);
            }
        }

    }
}
