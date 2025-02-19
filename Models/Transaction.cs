using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF_WorkShop.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public int? CategoryID { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }

    }

}
