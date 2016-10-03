using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challan.Models
{
    public class District
    {
        public District()
        {
            Branches = new List<Branch>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string NameOfDistrict { get; set; }
        public int PostalCode { get; set; }

        public string FamousPerson { get; set; }
        //navigation
        public virtual ChallanPrinciple Challan { get; set; }
        public virtual Address Address { get; set; }
        public List<Branch> Branches { get; set; }
    }
}