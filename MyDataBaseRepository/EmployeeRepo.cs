using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCustomEmployee;
using MyDataBaseRepository;
using InterfaceRepo;




namespace MyDataBaseRepository
{
    public class EmployeeRepo : IEmployeeRepo
    {

        public CustomEmployee GetEmployee(int Id)
        {
           
            return null;

        }

        public List<CustomEmployee> GetAllEmployee()
        {
            List<CustomEmployee> list = new List<CustomEmployee>();

            list.Add(new CustomEmployee { EmpId = 1,EmpName="kaustubh",EmpAddress="Pune"});
            list.Add(new CustomEmployee { EmpId = 2, EmpName = "Praful", EmpAddress = "Mumbai" });
            list.Add(new CustomEmployee { EmpId = 3, EmpName = "Sunny", EmpAddress = "Nashik" });
            list.Add(new CustomEmployee { EmpId = 4, EmpName = "Appa", EmpAddress = "Hyderabad" });

            return list;
        }

        public Boolean SaveEmployee()
        {
            return true;

        }

     
    }

}

