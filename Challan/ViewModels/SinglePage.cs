using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challan.ViewModels
{
    public class SinglePage
    {
        public string ApplicantName { get; set; }
        public string AcceptorName { get; set; }
        public string HolderName { get; set; }

        public string AcceptorDesignation { get; set; }
        public string ApplicantDesignation { get; set; }
        public string AcceptorDepartment { get; set; }
        public string ApplicantStreetName { get; set; }
        public string HolderStreetName { get; set; }
        public int ApplicantHouseNo { get; set; }
        public int HolderHouseNo { get; set; }
        public string BranchName { get; set; }
        public string ReasonForDeposit { get; set; }
        public double Taka { get; set; }
        public double Poisa { get; set; }
        public string NameOfDistrict { get; set; }
        public int PostalCode { get; set; }
    }
}