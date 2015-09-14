using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryBLL.Entities;

namespace LibraryBLL
{
    public interface ILibraryManager
    {
        bool SaveCategory(Category cat);

        Category FindCategory(int id);
    }
}
