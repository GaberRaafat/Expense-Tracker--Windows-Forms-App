using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF_WorkShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Priority { get; set; }
        public List<Transaction> Transactions { get; set; }

    }

}
