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
    public class CategoryDAO : SQLDataConnection
    {
        public bool Save(Category category)
        {
            const string sqlStatement =
                "INSERT INTO dbo.category (Description, AddedDate, Inactive) " +
                "VALUES(@description, @addeddate, @inactive); ";

            //Connect to database.
            con = OpenConnection();
            com = new SqlCommand(sqlStatement, con);

            //Set parameter values.
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
                finally
                {
                    scope.Dispose();
                }
            }
        }

        public bool Update(Category category)
        {
            const string sqlStatement =
                "UPDATE dbo.category SET Description=@description, Inactive=@inactive " +
                "WHERE CategoryId=@categoryid";

            //Connect to database.
            con = OpenConnection();
            com = new SqlCommand(sqlStatement, con);

            //Set parameter values.
            com.Parameters.AddWithValue("@categoryid", category.CategoryId);
            com.Parameters.AddWithValue("@description", category.Description);
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
                finally
                {
                    scope.Dispose();
                }
            }
        }

        public Category Select(int categoryId)
        {
            const string sqlStatement =
                "SELECT CategoryId, Description, AddedDate, Inactive " +
                "FROM dbo.Category  " +
                "WHERE CategoryId=@categoryId ";

            //Connect to database.
            con = OpenConnection();

            //Create a new category.
            Category category = new Category();

            com = new SqlCommand(sqlStatement, con);
            com.Parameters.AddWithValue("@CategoryId", categoryId);

            try
            {
                using (IDataReader dr = com.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        category = new Category
                        {
                            CategoryId = GetDataValue<int>(dr, "CategoryId"),
                            Description = GetDataValue<string>(dr, "Description"),
                            AddedDate = GetDataValue<DateTime>(dr, "AddedDate"),
                            Inactive = GetDataValue<bool>(dr, "Inactive")
                        };
                    }
                }

                return category;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
