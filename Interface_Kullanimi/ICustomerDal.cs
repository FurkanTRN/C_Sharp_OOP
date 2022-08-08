using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle Sql added");
        }

        public void Update()
        {
            Console.WriteLine("oracle sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("oracle sql deleted");
        }
    }
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}

