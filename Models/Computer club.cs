using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_club.Models
{
    class ComputerClub
    {
        private readonly List<Computer> _computers = new List<Computer>();
        private readonly Queue<Client> _clients = new Queue<Client>();
        private readonly Random _random = new Random();

        public IReadOnlyList<Computer> Computers => _computers;
        public Client CurrentClient { get; private set; }
        public int Money { get; private set; }

        public ComputerClub(int computersCount)
        {
            for (int i = 0; i < computersCount; i++)
                _computers.Add(new Computer(_random.Next(5, 21)));

            EnsureClients();
            TakeNextClient();
        }

        private void EnsureClients()
        {
            if (_clients.Count > 0)
                return;

            CreateClients(10);
        }

        private void CreateClients(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var name = (Client.Names)_random.Next(0,
                    Enum.GetValues(typeof(Client.Names)).Length);

                _clients.Enqueue(new Client(
                    _random.Next(100, 251),
                    name.ToString(),
                    _random
                ));
            }
        }

        private void TakeNextClient()
        {
            EnsureClients();
            CurrentClient = _clients.Dequeue();
        }

        public void RejectClient()
        {
            SpendOneMinute();
            TakeNextClient();
        }

        public bool TrySeatClient(int computerIndex)
        {
            if (computerIndex < 0 || computerIndex >= _computers.Count)
                return false;

            Computer computer = _computers[computerIndex];

            if (computer.IsTaken)
                return false;

            if (!CurrentClient.CanPay(computer))
                return false;

            Money += CurrentClient.Pay();
            computer.TakeClient(CurrentClient);

            SpendOneMinute();
            TakeNextClient();

            return true;
        }

        private void SpendOneMinute()
        {
            foreach (var computer in _computers)
                computer.SpendOneMinute();
        }
    }
}
