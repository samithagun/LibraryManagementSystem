using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryBLL.Entities;
using LibraryDAL.DAO;

namespace LibraryBLL
{
    public class LibraryManager : ILibraryManager
    {
        public bool SaveCategory(Category cat)
        {
            bool result = false;
            CategoryDAO cd = new CategoryDAO();

            //Save or Update.
            result = cat.CategoryId == 0 ? cd.Save(cat) : cd.Update(cat);

            return result;
        }

        public Category FindCategory(int id)
        {
            CategoryDAO cd = new CategoryDAO();

            //Find Category.
            Category cat = cd.Select(id);

            return cat;
        }
    }
}
