using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryBLL.Entities;
using LibraryDAL.DAO;

namespace LibraryBLL
{
    public class LibraryFacade
    {
        public bool ManageCategory(Category cat)
        {
            bool result = false;
            CategoryDAO cd = new CategoryDAO();

            result = cd.Create(cat);

            return result;
        }
    }
}
