using CrudAppWithOutEntity.Models.Employee;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CrudAppWithOutEntity.Data.EmployeeData
{
    public class SqlEmployeeRepo : IEmployee
    {
        private readonly EmployeeAccessLayer _employeeAccessLayer;
        private readonly EmployeeModel _employeeModel;
        public SqlEmployeeRepo(EmployeeAccessLayer employeeAccess) => this._employeeAccessLayer = employeeAccess;

        public EmployeeModel AddEmployee(EmployeeModel emp)
        {
            DataTable _objtable = _employeeAccessLayer.InsertUpdateEmployee(emp);
            _employeeModel.EmployeeId = Convert.ToInt32(_objtable.Rows[0]["EmployeeId"]);
            return _employeeModel;
        }
    }
}
