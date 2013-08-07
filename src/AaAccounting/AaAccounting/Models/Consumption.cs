using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AaAccounting.Models
{
    public class Consumption
    {
        public DateTime DateTime { get; set; }

        public int NumberOfPeople { get; set; }

        public decimal TotalAmount { get; set; }

        public string Payer { get; set; }

        public IList<ConsumptionDetail> ConsumptionDetails { get; set; }
    }
}