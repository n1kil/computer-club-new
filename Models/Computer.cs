using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_club.Models
{
    class Computer
    {
        private Client _client;

        public int PricePerMinute { get; }
        public int MinutesRemaining { get; private set; }

        public bool IsTaken => MinutesRemaining > 0;

        public Computer(int pricePerMinute)
        {
            PricePerMinute = pricePerMinute;
        }

        public void TakeClient(Client client)
        {
            _client = client;
            MinutesRemaining = client.DesiredMinutes;
        }

        public void Free()
        {
            _client = null;
            MinutesRemaining = 0;
        }

        public void SpendOneMinute()
        {
            if (!IsTaken)
                return;

            MinutesRemaining--;

            if (MinutesRemaining <= 0)
                Free();
        }
    }
}
