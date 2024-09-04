using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace webEstoque.Models.Mapping
{
    public class ConnectionString
    {
        private static readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=WebEstoque;Integrated Security=True";
        public static SqlConnection Get()
        {
            return new SqlConnection(connectionString);
        }
    }
}