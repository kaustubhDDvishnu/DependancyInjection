using MyCustomEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRepo
{
    
       public interface IEmployeeRepo
        {
            List<CustomEmployee> GetAllEmployee();

            CustomEmployee GetEmployee(int Id);

            Boolean SaveEmployee();
        }
    
}
