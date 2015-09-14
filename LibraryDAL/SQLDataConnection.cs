using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryDAL
{
    public class SQLDataConnection
    {
        public static string constr = "Data Source=ZLK114\\SQL2012; User ID=sa; Password=sa@123; Initial Catalog=Library";
        public static SqlConnection con;
        public static SqlCommand com;

        private static SQLDataConnection DbInstance;

        //private SQLDataConnection() 
        public SQLDataConnection()
        {
        }

        public static SQLDataConnection getDbInstance()
        {
            if (DbInstance == null)
                DbInstance = new SQLDataConnection();
            return DbInstance;
        }

        public static SqlConnection OpenConnection()
        {
            con = new SqlConnection(constr);
            con.Open();
            return con;
        }

        public static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }

        protected T GetDataValue<T>(IDataReader dr, string columnName)
        {
            // NOTE: GetOrdinal() is used to automatically determine where the column is physically located in the database table. This allows the schema to be changed without affecting the code.
            int i = dr.GetOrdinal(columnName);

            if (!dr.IsDBNull(i))
                return (T) dr.GetValue(i);
            else
                return default(T);
        }
    }
}
