using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bank
    {
        private string name;
        private double budget;
        private double profit;
        public CEO Ceo { get; set; }
        public Worker[] workers;
        public Manager[] managers;
        public Client[] clients;

        public Bank(string name, double budget, double profit)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
        }

        public string Name { get=>name; set {
                if (value == null) throw new InvalidDataException();
                name= value;
            }
        }
        public double Budget { get => budget; set
            {
                if(value<0) throw new InvalidDataException();
                budget= value;
            }
        }

        public double Profit { get => profit; set
            {
                if(value<0)throw new InvalidDataException();
                profit= value;
            } 
        }

        public void AddWorker(Worker worker)
        {
            Worker[] newList;
            if (workers != null)
            {
                newList = new Worker[workers.Length + 1];
                int i = 0;
                for (; i < workers.Length; i++)
                {
                    Array.Copy(workers, i, newList, 1, workers.Length);
                }
                    newList[workers.Length] = worker;
                    workers = newList;
            }

            else
            {
                workers = new Worker[1];
                workers[0] = worker;
            }
        }
        public void AddManager(Manager manager)
        {
            Manager[] newList;
            if (managers != null)
            {
                newList = new Manager[managers.Length + 1];
                int i = 0;
                for (; i < managers.Length; i++)
                {
                    Array.Copy(managers, i, newList, 1, managers.Length);
                }
                newList[managers.Length] = manager;
                managers = newList;
            }

            else
            {
                managers = new Manager[1];
                managers[0] = manager;
            }
        }

        public void AddClient(Client client)
        {
            Client[] newList;
            if (clients != null)
            {
                newList = new Client[clients.Length + 1];
                int i = 0;
                for (; i < clients.Length; i++)
                {
                    Array.Copy(clients, i, newList, 1, clients.Length);
                }
                newList[clients.Length] = client;
                clients = newList;
            }

            else
            {
                clients = new Client[1];
                clients[0] = client;
            }
        }



        public void calculate_profit() { }
        public void showClientCredit(string name,string surname) { }
        public void PayCredit(Client client,int money_amount) { }

    }
}
