using CrudAppWithOutEntity.Models.Employee;

namespace CrudAppWithOutEntity.Data.EmployeeData
{
    interface IEmployee
    {        
        public EmployeeModel AddEmployee(EmployeeModel emp);        
    }
}
