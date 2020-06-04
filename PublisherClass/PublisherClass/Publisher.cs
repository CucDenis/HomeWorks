using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherClass
{
    public delegate void Iteratie(int i);

    class Publisher
    {

        public event Iteratie Eveniment;

        public int Repetare { get; set; }
        public string Id { get; set; }

        public static int numberOfSubscribers = 0;
        public static int numberOfComments = 0;

        public Publisher(string id, int repetare)
        {
            Id = id;
            Repetare = repetare;
        }

        public void  DeclansareEveniment()
        {
            for (int i = 0; i < Repetare; i++)
            {
                OnSubscriberEvent(i);
            }
        }

        protected virtual void OnSubscriberEvent(int i)
        {
            if (Eveniment != null)
            {
                Eveniment(i);
            }
        }
    }
}
