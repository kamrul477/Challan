using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challan.Models
{
    public class HolderDetails
    {
        public HolderDetails()
        {
            Addresses = new List<Address>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }        
        public string HolderName { get; set; }

        //navigation properties
        public virtual ChallanPrinciple Challan { get; set; }
        public List<Address> Addresses { get; set; }
    }
}