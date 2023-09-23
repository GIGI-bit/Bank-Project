using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal class Operation
    {
        private Guid id;
        private string operation_name;
        private DateTime dateTime;

        public Operation(string operation_name, DateTime dateTime, string operation_Name)
        {
            id = new Guid();
            this.operation_name = operation_name;
            dateTime = DateTime.Now;
            Operation_Name = operation_Name;
        }

        public string Operation_Name
        {
            get => operation_name; set
            {
                if (value == null) throw new Exception();
                operation_name = value;
            }
        }

        public DateTime Date_Time
        {
            get => dateTime;
        }

        public Guid Id
        {
            get => id;
        }


        public Operation()
        {
            id = new Guid();
            dateTime = DateTime.Now;
        }


    }

    internal class Credit
    {
        private Guid id;
        private Client client;
        private float amount;
        private float percent;
        private int month;
        public Credit(float amount, float percent, int month)
        {
            Amount = amount;
            Percent = percent;
            Month = month;
            id = new Guid();
        }

        public Guid Id { get => id; }
        public Client CLient
        {
            get => client; set
            {
                if (client == null) throw new Exception();
                client = value;

            }
        }

        public float Amount
        {
            get => amount; set
            {
                if (value == null) throw new Exception();
                amount = value;
            }
        }

        public float Percent
        {
            get => percent; set
            {
                if (value == null) throw new Exception();
                percent = value;
            }
        }

        public int Month
        {
            get => month; set
            {
                if (value == null) throw new Exception();
                month = value;
            }
        }

        public void claculatePercent()
        {

        }
        public void Payment()
        {

        }
        public void Show()
        {
            Console.WriteLine($"Id:{id}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Percent: {percent}");
            Console.WriteLine($"Month: {Month}");
            client.Show();
        }

    }


}