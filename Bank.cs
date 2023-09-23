using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal class Bank
    {
        private string name;
        private double budget;
        private double profit;
        public CEO Ceo { get; set; }
        public Worker[] workers;
        public Manager[] managers;
        public Credit[] credits;

        public Bank(string name, double budget, double profit)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
        }

        public string Name
        {
            get => name; set
            {
                if (value == null) throw new InvalidDataException();
                name = value;
            }
        }
        public double Budget
        {
            get => budget; set
            {
                if (value < 0) throw new InvalidDataException();
                budget = value;
            }
        }

        public double Profit
        {
            get => profit; set
            {
                if (value < 0) throw new InvalidDataException();
                profit = value;
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

        public void AddCredit(Credit client)
        {
            Credit[] newList;
            if (credits != null)
            {
                newList = new Credit[credits.Length + 1];
                int i = 0;
                for (; i < credits.Length; i++)
                {
                    Array.Copy(credits, i, newList, 1, credits.Length);
                }
                newList[credits.Length] = client;
                credits = newList;
            }

            else
            {
                credits = new Credit[1];
                credits[0] = client;
            }
        }



        public void calculate_profit() { Console.WriteLine($"This years profit: {profit}"); }
        public void showClientCredit(Client client)
        {
            foreach (var credit in credits)
            {
                if (credit.CLient == client)
                {
                    credit.Show();
                    return;
                }
            }
        }
        public void PayCredit(Client client, int money_amount)
        {
            foreach (var credit in credits)
            {
                if (credit.CLient == client)
                {
                    credit.Amount -= money_amount;
                    credit.Show();
                }
            }
        }

    }
}