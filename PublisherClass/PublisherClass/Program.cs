using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher youtubeChannel = new Publisher("Yep", 5);
            SubscriberA sub1 = new SubscriberA("babaYaga", youtubeChannel);
            SubscriberB sub2 = new SubscriberB("Mega_OneStAr2020", youtubeChannel);

            youtubeChannel.DeclansareEveniment();

        }
    }
}
