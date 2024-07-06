using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

class Program
{
    interface IOrganize { void organize(); }

    class Operation
    {
        public Guid id { get; set; }
        public string process_name { get; set; }
        public DateTime DateTime { get; set; }
        public Operation(Guid id, string process_name, DateTime dateTime)
        {
            this.id = id;
            this.process_name = process_name;
            DateTime = dateTime;
        }
        public override string ToString()
        {
            return $"Name: {process_name}, Time: {DateTime}, Id: {id}";
        }
    }
    class Worker
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public double salary { get; set; }
        public DateOnly startTime { get; set; }
        public DateOnly endTime { get; set; }
        public List<Operation> Operations { get; set; }
        public void  addOperation(Operation operation)
        {
            Operations.Add(operation);
        }

    }
    class Ceo : Worker, IOrganize
    {
        public void organize()
        {
            Console.WriteLine($"CEO {name} organize."); 
        }
        void Control()
        {
            Console.WriteLine($"CEO {name} control.");
        }
        void MakeMeeting()
        {
            Console.WriteLine($"CEO {name} makes meeting.");
        }
        void DecreasePercentage(int percentage)
        {
            Console.WriteLine($"CEO {name} decr percentage {percentage}%");
        }

    }
    class Manager : Worker, IOrganize
    {
        public void organize()
        {
            Console.WriteLine($"Manager {name} organize.");
        }
        void calculateSalaries()
        {
            Console.WriteLine($" Manager {name} calculate salary.");
        }
    }
    class Client
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public int salary { get; set; }
    }

    class Credit
    {
        public Guid ID { get; set; }
        public Client client { get; set; }
        public double amount { get; set; }
        public double percent { get; set; }
        public int months { get; set; }

        public double CalculatePercent()
        {
            return percent; 
        }
        public void Payment(double payment)
        {
            Console.WriteLine("Payment");
        }
    }
    class Bank
    {
        public string BankName { get; set; }
        public int budget { get; set; }
        public int profit { get; set; }
        public Ceo CeoOfBank { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Client> Clients { get; set; }
        void ShowClientCredit(string name, string surname)
        {
            foreach (Client client in Clients)
            {
                if (client.name == name & client.surname == surname)
                {
                    Console.WriteLine($"{client.name} {client.surname}");
                }
                else 
                {
                    Console.WriteLine("Client not found"); 
                }
            }
        }

        void ShowAllCredit() 
        {
            Console.WriteLine("Credits"); 
        }
        void payCredit(Client client,int money)
        {
            Console.WriteLine($"{client.name} {client.surname} must pay {money}AZN for  credit");
        }
    }
   }
