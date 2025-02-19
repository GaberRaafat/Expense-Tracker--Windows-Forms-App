using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_EF_WorkShop.Models
{
 
        public class User
        {

            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public double Income { get; set; }   
       
            public List<Transaction> Transactions { get; set; }

        }

}
