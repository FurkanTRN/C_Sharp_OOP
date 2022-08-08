using System;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            Mysql mysql = new Mysql();
            mysql.Add();
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add(){
            Console.WriteLine("added by default");
        }
        public virtual void Delete(){
            Console.WriteLine("deleted bu default");
        }
        
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("added by sql code");
            //base.Add();
        }
    }

    class Mysql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by mysql code");
            //base.Add();
        }
    }
}
