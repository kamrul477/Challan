using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challan.Models
{
    public class Currency
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public double Taka { get; set; }
        public double Poisa { get; set; }

        //navigation
        public virtual ChallanPrinciple Challan { get; set; }
    }
}