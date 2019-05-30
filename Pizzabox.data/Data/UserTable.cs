using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaboxdata.Data
{
    public partial class UserTable
    {
        public UserTable()
        {
            OrderTable = new HashSet<OrderTable>();
        }

        public string UsernamePk { get; set; }
        public string Password { get; set; }

        public virtual ICollection<OrderTable> OrderTable { get; set; }
    }
   
}
