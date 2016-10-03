using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challan.Models
{
    public class Address
    {
        public Address()
        {
            Districts = new List<District>(); 
        }
        public Guid Id { get; set; }
     
        public string StreetName { get; set; }
        public int HouseNo { get; set; }


        //navigation
        public virtual ChallanPrinciple Challan { get; set; }
        public List<District> Districts { get; set; }

    }
}