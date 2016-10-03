using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challan.Models
{
    public class ApplicantDetails
    {
        public ApplicantDetails()
        {
            Addresses = new List<Address>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantDesignation { get; set; }
       
        //navigation properties
        public virtual ChallanPrinciple Challan { get; set; }
        public List<Address> Addresses { get; set; }
    }
}