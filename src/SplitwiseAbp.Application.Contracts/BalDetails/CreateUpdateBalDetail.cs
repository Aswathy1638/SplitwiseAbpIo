using System;
using System.Collections.Generic;
using System.Text;

namespace SplitwiseAbp.BalDetails
{
  public class CreateUpdateBalDetail
    {
        public Guid userId { get; set; }
        public Guid debtUserId { get; set; }
        public decimal balance_amount { get; set; }
    }
}
