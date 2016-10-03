using Challan.Models;
using Challan.ViewModels;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Challan.Controllers
{
    public class ChallanController : Controller
    {

        // GET: /Challan/

        public ChallanContext context = new ChallanContext();
        private ChallanPrinciple challan = new ChallanPrinciple();
        private Address holderAddress = new Address();
        private HolderDetails holderDetails = new HolderDetails();
        private AcceptorDetails acceptorDetails = new AcceptorDetails();
        private ApplicantDetails applicantDetails = new ApplicantDetails();
        public PdfCreation pdf;


        public ActionResult Index()
        {
            //var singlePage = new SinglePage();
            // context.Districts.Add(district);
            //context.SaveChanges();
            return View();
        }



        [HttpPost]
        public ActionResult CreateSinglePage(SinglePage singlePage)
        {

            if (ModelState.IsValid)
            {
                //challan creation
                CreateChallan();

                //applicnat creation
                CreateApplicant(singlePage);

                //acceptor creation
                CreateAcceptor(singlePage);

                //Holder Creation
                CreateHolder(singlePage);

                //pdf creation
                

                context.Challans.Add(challan).HolderDetailses.Add(holderDetails);
                context.Challans.Find(challan.Id).AcceptorDetailses.Add(acceptorDetails);
                context.Challans.Find(challan.Id).ApplicantDetailses.Add(applicantDetails);

                //pdf = new PdfCreation(context);
                //pdf.pdfCreate();
                context.SaveChanges();

            }
            return new ViewAsPdf("SendPdf",singlePage);
        }

        private void CreateChallan()
        {

            challan.Id = Guid.NewGuid();
            challan.ChallanDate = DateTime.Today;
            challan.ReasonForDeposit = "Registration";


        }

        private void CreateHolder(SinglePage singlePage)
        {


            holderAddress.Id = Guid.NewGuid();
            holderAddress.StreetName = singlePage.HolderStreetName;
            holderAddress.HouseNo = singlePage.HolderHouseNo;



            holderDetails.Id = Guid.NewGuid();
            holderDetails.HolderName = singlePage.HolderName;


            holderDetails.Addresses.Add(holderAddress);
        }

        private void CreateAcceptor(SinglePage singlePage)
        {

            acceptorDetails.Id = Guid.NewGuid();
            acceptorDetails.AcceptorName = singlePage.AcceptorName;
            acceptorDetails.AcceptorDesignation = singlePage.AcceptorDesignation;
            acceptorDetails.AcceptorDepartment = singlePage.AcceptorDepartment;


        }

        private void CreateApplicant(SinglePage singlePage)
        {
            var branch = new Branch();
            branch.BranchName = "Corporate";
            branch.Id = Guid.NewGuid();

            var district = new District();
            district.Id = Guid.NewGuid();
            district.NameOfDistrict = "Barisal";
            district.PostalCode = 8200;




            var address = new Address();

            address.Id = Guid.NewGuid();
            address.StreetName = singlePage.ApplicantStreetName;
            address.HouseNo = singlePage.ApplicantHouseNo;
 
            applicantDetails.Id = Guid.NewGuid();
            applicantDetails.ApplicantName = singlePage.ApplicantName;
            applicantDetails.ApplicantDesignation = singlePage.ApplicantDesignation;
    
            district.Branches.Add(branch);
            address.Districts.Add(district);
            applicantDetails.Addresses.Add(address);  
        }

    }
}
