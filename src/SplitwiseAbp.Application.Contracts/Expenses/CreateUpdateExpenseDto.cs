using System;
using System.Collections.Generic;
using System.Text;

namespace SplitwiseAbp.Expenses
{
 public class CreateUpdateExpenseDto
    {
      
      
        public string Description { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public Guid paiduser_id { get; set; }
        public decimal amount { get; set; }
        public decimal shareAmount { get; set; }

    }
}
