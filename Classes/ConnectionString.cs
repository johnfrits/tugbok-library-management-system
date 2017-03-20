using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MPosInfoManagementSystem
{
    abstract class ConnectionString
    {
        public SqlConnection connection;

        public SqlConnection Connection()
        {
            connection = new SqlConnection(@"Data Source=HP\SQLSERVER;Initial Catalog=MPosDB;Integrated Security=True");
            return connection;
        }
    }
}
