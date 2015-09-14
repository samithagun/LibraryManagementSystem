using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Transactions;
using LibraryBLL.Entities;

namespace LibraryDAL.DAO
{
    public partial class CategoryDAO : SQLDataConnection
    {
        public bool Create(Category category)
        {
            try
            {
                const string sqlStatement =
                    "INSERT INTO dbo.category (Description, AddedDate, Inactive) " +
                    "VALUES(@description, @addeddate, @inactive);  ";

                // Connect to database.
                con = SQLDataConnection.OpenConnection();
                com = new SqlCommand(sqlStatement, con);

                // Set parameter values.
                com.Parameters.AddWithValue("@description", category.Description);
                com.Parameters.AddWithValue("@addeddate", category.AddedDate);
                com.Parameters.AddWithValue("@inactive", category.Inactive);

                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        com.ExecuteNonQuery();
                        scope.Complete();
                        return true;
                    }
                    catch (Exception)
                    {
                        scope.Dispose();
                        throw;
                    }                  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category Select(int categoryId)
        {
            const string sqlStatement =
                "SELECT Description, AddedDate, Inactive " +
                "FROM dbo.Category  " +
                "WHERE CategoryId=@categoryId ";

            Category category = null;

            // Connect to database.
            con = SQLDataConnection.OpenConnection();

            // SqlDataReader rdr = null;
            com = new SqlCommand(sqlStatement, con);
            com.Parameters.AddWithValue("@CategoryId", categoryId);

            try
            {
                using (IDataReader dr = com.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Create a new category.
                        category = new Category();

                        // Read values.
                        category.Description = base.GetDataValue<string>(dr, "Description");
                        category.AddedDate = base.GetDataValue<DateTime>(dr, "AddedDate");
                        category.Inactive = base.GetDataValue<bool>(dr, "Inactive");
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return category;
        }
    }

}
