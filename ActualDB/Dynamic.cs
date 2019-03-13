using MyCustomEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceRepo;

namespace ActualDB
{
    public class Dynamic : IEmployeeRepo
    {
        ActualDBModelContainer db = new ActualDBModelContainer();

        public List<CustomEmployee> GetAllEmployee()
        {
            List<CustomEmployee> list = new List<CustomEmployee>();

            var entitydata = db.Actuals.ToList();

            foreach (var item in entitydata)
            {
                CustomEmployee classobj = new CustomEmployee();
                classobj.EmpId = item.EmpId;
                classobj.EmpName = item.EmpName;
                classobj.EmpAddress = item.EmpAddress;

                list.Add(classobj);


            }

            return list;

        }

        public CustomEmployee GetEmployee(int Id)
        {

            return null;

        }
        public Boolean SaveEmployee()
        {
            return true;

        }

    }

    public interface IEmployee
    {
    }
}
