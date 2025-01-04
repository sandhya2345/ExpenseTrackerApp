using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2.Models
{
    public class Debt
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Link debt to a user
        public decimal Amount { get; set; } // Total debt amount
        public decimal PaidAmount { get; set; } // Amount paid towards debt
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public bool IsCleared { get; set; } = false;
    }

}
