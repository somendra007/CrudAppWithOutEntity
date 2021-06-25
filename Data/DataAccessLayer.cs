using System;
using System.Data;
using System.Data.SqlClient;
using CrudAppWithOutEntity.Models;

namespace CrudAppWithOutEntity.Data
{
    public class DataAccessLayer
    {
        private readonly ConnectionStrings _connectionStrings;
        private readonly string con;
        public DataAccessLayer(ConnectionStrings _con) => this._connectionStrings = _con;

        #region "Return DataSet"
        public DataSet GetDataSet(SqlCommand _cmd)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(_connectionStrings.DefaultDbConnection))
                {
                    _con.Open();
                    using (DataSet _dataset = new DataSet())
                    {
                        _cmd.Connection = _con;
                        _cmd.CommandTimeout = 300;
                        using (SqlDataAdapter _dataAdapter = new SqlDataAdapter())
                        {
                            _dataAdapter.Fill(_dataset);
                        }
                        return _dataset;
                    }
                }
            }
            finally
            {
                _cmd.Dispose();
            }
        }
        #endregion

        #region "Return DataSet"
        public DataTable GetDataTable (SqlCommand _cmd)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(_connectionStrings.DefaultDbConnection))
                {
                    _con.Open();
                    using (DataTable _datatable = new DataTable())
                    {
                        _cmd.Connection = _con;
                        _cmd.CommandTimeout = 300;
                        using (SqlDataAdapter _dataAdapter = new SqlDataAdapter())
                        {
                            _dataAdapter.Fill(_datatable);
                        }
                        return _datatable;
                    }
                }
            }
            finally
            {
                _cmd.Dispose();
            }
        }
        #endregion
    }
}
