using BussinessBLRepository;
using MyDataBaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //actual data base
            //EmployeeRepo emprepoobj = new EmployeeRepo(); //static database
            //EmployeeBLRepo emprepoobj = new EmployeeBLRepo(); //Actual database

            int n = 0;
            Console.WriteLine("1.DataBase \t 2. Static database ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                n = a;
            }
            if (a == 2)
            {
                n = a;
            }
            EmployeeBLRepo emprepoobj = new EmployeeBLRepo(n);
            var li =  emprepoobj.GetAllEmployee();

            foreach (var item in li) //to show actual DB data //comment this foreach while using static database
            {
                Console.WriteLine(item.EmpId + "   " + item.EmpName + "   " + item.EmpAddress);
            }
            Console.ReadLine();
        }
    }
}
