using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public decimal Debit { get; set; } 
        public decimal Credit { get; set; } // Cash in
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

        

    }
}
