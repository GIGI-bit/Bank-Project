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
                if(value<0)throw new InvalidCastException();    
                salary = value;
            }
        }

        public Guid Id { get => _id; }

    }

    internal class CEO :Human
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

        public CEO() { 
        
        }
        public void decreasePercentage()
        {

        }
        public void makeMeeting()
        {

        }
        public void control()
        {

        }

    }

    internal class Worker:Human
    {
        private string position;
        private DateTime startDate;
        private DateTime endTime;

        public Worker()
        {
            startDate = DateTime.Now;
        }
        public DateTime EndDate { get=>endTime;}
        public DateTime StartDate { get=>startDate; }

        public string Position
        {
            get => position;
            set
            {
                if (value == null) throw new Exception("Invalid data");
                position=value;
            }
        }

    }
    internal class Manager:Human
    {

    }
    internal class Client : Human
    {

    }

}
