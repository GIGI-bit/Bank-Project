using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Human
    {
        private Guid _id = new Guid();
        private string name;
        private string surname;
        private int age;
        private float salary;

        public Human() { }
        public Human( string name, string surname, int age, float salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == null || value.Length < 2) throw new Exception("Value CAN NOT be NULL or length CAN NOT be less that 2.");
                name = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (value == null || value.Length < 3) throw new InvalidCastException();
                surname = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 100) throw new InvalidCastException();
                age = value;
            }
        }

        public float Salary
        {
            get => salary;
            set
            {
                if (value < 0) throw new InvalidCastException();
                salary = value;
            }
        }

        public Guid Id { get => _id; }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
        }

    }

    internal class CEO : Human, IAbility
    {
        private string position;
        public string Position
        {
            get => position;
            set
            {
                if (value == null) throw new Exception("Invalid Value");
                position = value;
            }
        }

        public CEO(){}
        public CEO(string name,string surname,int age, float salary):base(name,surname,age,salary){ }
        public void decreasePercentage()
        {

        }
        public void makeMeeting(Manager[] managers, Worker[]workers)
        {
            Console.WriteLine("MEETING");
            Console.WriteLine($"Organizer: {this.Name} {this.Surname}");

            foreach (var item in managers)
            {
                item.Show();
            }
            foreach (var item in workers)
            {
                item.Show();
            }
        }
        public void control()
        {

        }

        public void organize()
        {
           
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {position}");
        }

    }

    internal class Worker : Human
    {
        private string position;
        private DateTime startDate;
        private DateTime endTime;

        public Worker()
        {
            startDate = DateTime.Now;
        }
        public Worker(string name,string surname,int age,float salary) : base(name, surname, age, salary) { }

        public DateTime EndDate { get => endTime; }
        public DateTime StartDate { get => startDate; }

        public string Position
        {
            get => position;
            set
            {
                if (value == null) throw new Exception("Invalid data");
                position = value;
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Start Date: {StartDate.ToString()}");
            if(EndDate!=null) Console.WriteLine($"End Date: {EndDate.ToString()}");
        }

    }
    internal class Manager : Human, IAbility
    {
        private string position;
        public Manager()
        {
            
        }
        public Manager(string name,string surname,int age,float salary):base(name, surname, age, salary) { }
        public string Position
        {
            get => position;
            set
            {
                if (value == null) throw new Exception();
            }
        }

        public double calculateSalaries(Worker worker) {
            var perDay = worker.Salary / 30;
            var perHour = perDay / 24; 
            var workTime = DateTime.Now - worker.StartDate;
            

            var totalPay=workTime.TotalDays*perDay+workTime.Hours*perHour;
            return totalPay;
        }

        public void organize()
        {
            throw new NotImplementedException();
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"PosiTion: {position}");
        }
    }
    internal class Client : Human
    {
        private string home_address;
        private string work_address;

        public Client(string name, string surname, int age, float salary):base(name,surname, age, salary) { }

        public string Home_Address
        {
            get => home_address; set
            {
                if (value == null) throw new Exception();
                home_address = value;
            }
        }

        public string Work_Address
        {
            get => work_address; set
            {
                if (value == null) throw new Exception();
                work_address = value;
            }
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Home Address: {home_address}");
            Console.WriteLine($"Work Address: {work_address}");
        }

    }

}
