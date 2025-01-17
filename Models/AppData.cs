using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace m2.Models
{
    public class AppData
    {

        public List<User> Users { get; set; } = new();
        public List<Transaction> Transactions { get; set; } = new();
        public List<Debt> Debts { get; set; } = new List<Debt>();

        public string PreferredCurrency { get; set; }



    }

}
