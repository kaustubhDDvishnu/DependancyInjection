using MyCustomEmployee;
using MyDataBaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActualDB;
using InterfaceRepo;

namespace BussinessBLRepository
{
    
    public class EmployeeBLRepo
    {
        //  EmployeeRepo emprepoobj = new EmployeeRepo();
        //  EmployeeBLRepo empblobj = new EmployeeBLRepo();
        // Dynamic actualclassobj = new Dynamic();

        IEmployeeRepo dm;
        public EmployeeBLRepo(int a)
        {
            if (a == 1)
            {
                dm = new Dynamic();

            }
            if (a==2)
            {
                dm = new EmployeeRepo();
            }

        }

      //  Dynamic dm = new Dynamic();
        public List<CustomEmployee> GetAllEmployee()
        {

            return dm.GetAllEmployee();
            //return emprepoobj.GetAllEmployee();
        }

        public CustomEmployee GetEmployee(int Id)
        {

            return dm.GetEmployee(1);

        }

        public Boolean SaveEmployee()
        {
            return dm.SaveEmployee();

        }



    }
    
    
}
