using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryBLL.Entities
{
    public partial class Category
    {
        public int CategoryId { get; set; }

        public string Description { get; set; }

        public DateTime AddedDate { get; set; }

        public Boolean Inactive { get; set; }

    }
}
