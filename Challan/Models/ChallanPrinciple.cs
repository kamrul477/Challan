using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challan.Models
{
    public class ChallanPrinciple
    {
        public ChallanPrinciple()
        {
            AcceptorDetailses = new List<AcceptorDetails>();
            ApplicantDetailses = new List<ApplicantDetails>();
            HolderDetailses = new List<HolderDetails>();
            Currencies = new List<Currency>();
            Districts = new List<District>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string ReasonForDeposit { get; set; }

       
        public DateTime ChallanDate { get; set; }


        //navigation

        public List<AcceptorDetails> AcceptorDetailses { get; set; }
        public List<ApplicantDetails> ApplicantDetailses { get; set; }
        public List<HolderDetails> HolderDetailses { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<District> Districts { get; set; }

    }
}