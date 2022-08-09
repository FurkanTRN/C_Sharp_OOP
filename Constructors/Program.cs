using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Demo();

           PersonManager personManager = new PersonManager("Product");
           personManager.Add();
           Console.ReadLine();

           
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product = new Product { Id = 1, Name = "monster" };
            Product product2 = new Product(2, "computer");

            EmployeeManager employeManager = new EmployeeManager(new Database());
            employeManager.Add();
        }
    }

    class BaseClass
    {
        private string _entitiy;

        public BaseClass(string entitiy)
        {
            _entitiy = entitiy;
        }
        public void Message(){
            Console.WriteLine("{0} message",_entitiy);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("added");
            Message();
        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }

        public void List()
        {
            Console.WriteLine("listed {0} items",_count);
        }

        public void Add()
        {
            Console.WriteLine("added");
        }
    }

    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name; 
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        public void Log();

    }

    class Database : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }

    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger=logger;
        }
        public void Add(){
            _logger.Log();
            Console.WriteLine("added");
        }
    }

   
}
