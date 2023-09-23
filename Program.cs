using Bank_Project;

static int makeMenu(params string[] arr)
{
    int index = 0;


    dynamic choice;
    while (true)
    {
        Console.Clear();
        for (int i = 0; i < arr.Length; i++)
        {
            if (index == i)
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(arr[i]);
            Console.BackgroundColor = ConsoleColor.Black;

        }


        choice = Console.ReadKey();

        if (choice.Key == ConsoleKey.UpArrow && index == 0)
        {
            index = arr.Length - 1;
        }
        else if (choice.Key == ConsoleKey.UpArrow)
        {
            index--;
        }
        else if (choice.Key == ConsoleKey.DownArrow && index == arr.Length - 1)
        {
            index = 0;
        }
        else if (choice.Key == ConsoleKey.DownArrow)
        {
            index++;
        }
        else if (choice.Key == ConsoleKey.Enter)
        {
            return index;
        }

    }


}

Bank bank = new Bank("Gizmo", 320000, 270000);

Console.SetCursorPosition(45, 10);

int index = makeMenu("Create Worker.", "Create Manager", "Manager Calculate Salary Function", "Manager Organize Function", "Create Client");

if (index == 0)
{
    Console.Clear();
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Surname: ");
    string surname = Console.ReadLine();
    Console.Write("Enter Age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Salary: ");
    float salary = Convert.ToSingle(Console.ReadLine());

    Worker worker = new Worker(name, surname, age, salary);
    Console.WriteLine();
    worker.Show();
    bank.AddWorker(worker);
    Console.WriteLine("Documentary: You've created an object of 'Worker' class using constructor with parameters. Then overrided Show method of 'Human' class was called.");

}
else if (index == 1)
{
    Console.Clear();
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Surname: ");
    string surname = Console.ReadLine();
    Console.Write("Enter Age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Salary: ");
    float salary = Convert.ToSingle(Console.ReadLine());

    Manager manager = new Manager(name, surname, age, salary);
    Console.WriteLine();
    manager.Show();
    bank.AddManager(manager);
    Console.WriteLine("Documentary: You've created an object of 'Manager' class using constructor with parameters. Then overrided Show method of 'Human' class was called.");

}

else if (index == 2)
{
    Console.Clear();

    Worker worker = new Worker("Jay", "Robert", 32, 520);
    Manager manager = new Manager("Ailina", "Lovewell", 27, 490);

    Console.WriteLine(manager.calculateSalaries(worker));
    bank.AddManager(manager);
    bank.AddWorker(worker);
    Console.WriteLine(@"Documentary: An object of 'Worker' class was created using constructor with parameters.Then an object was created using default constructor of 'Manager' class. After that calculateSalaries(Worker worker) was called. This method uses special way to calculate.
In a basic example: 
perDay=salary/30 
perHour=perDay/24
After that: 
TotalDays*perDay(money earned every day)+Hours*perHour(money earned every Hour)");


}

else if (index == 3)
{
    Console.Clear();

    Manager manager = new Manager("Clair", "More", 42, 970);
    bank.AddManager(manager);
    Worker worker = new Worker("Roseline", "Turneux", 23, 466);
    Worker worker_1 = new Worker("Nick", "Mussotti", 39, 456);
    Worker worker_2 = new Worker("Jerome", "Millhouse", 31, 688);
    bank.AddWorker(worker);
    bank.AddWorker(worker_2);
    bank.AddWorker(worker_1);

    manager.organize();

}

else if (index == 4)
{
    Console.Clear();

    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Surname: ");
    string surname = Console.ReadLine();
    Console.Write("Enter Age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Salary: ");
    float salary = Convert.ToSingle(Console.ReadLine());


    Client client = new Client(name, surname, age, salary);
}






