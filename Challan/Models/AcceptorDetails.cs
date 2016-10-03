using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challan.Models
{
    public class AcceptorDetails 
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string AcceptorName { get; set; }
        public string AcceptorDesignation { get; set; }
        public string AcceptorDepartment { get; set; }

        //navigation
        public virtual ChallanPrinciple Challan { get; set; }

    }
}