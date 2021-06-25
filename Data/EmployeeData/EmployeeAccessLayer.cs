using System;
using System.Data;
using System.Data.SqlClient;
using CrudAppWithOutEntity.Models.Employee;

namespace CrudAppWithOutEntity.Data.EmployeeData
{
    public class EmployeeAccessLayer
    {
        private readonly DataAccessLayer _dataAccess;
        public EmployeeAccessLayer(DataAccessLayer _dataAccessLayer) => this._dataAccess = _dataAccessLayer;

        #region "Insert and Update Employee Records"
        public DataTable InsertUpdateEmployee(EmployeeModel _emp)
        {
            using DataTable _ds = new DataTable();
            using SqlCommand _cmd = new SqlCommand();
            _cmd.CommandText = "Proc_InsertUpdateEmployeeById";
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@FirstName", _emp.FirstName);
            _cmd.Parameters.AddWithValue("@LastName", _emp.LastName);
            _cmd.Parameters.AddWithValue("@MailId", _emp.EmailId);
            _cmd.Parameters.AddWithValue("@Address", _emp.Address);
            _cmd.Parameters.AddWithValue("@DOB", _emp.DOB);
            _cmd.Parameters.AddWithValue("@Country", _emp.CountryId);
            _cmd.Parameters.AddWithValue("@State", _emp.StateId);
            return _dataAccess.GetDataTable(_cmd);
        }
        #endregion
    }
}
