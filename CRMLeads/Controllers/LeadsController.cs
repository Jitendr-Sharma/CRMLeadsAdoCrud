using CRMLeads.Data;
using CRMLeads.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;

namespace CRMLeads.Controllers
{
    public class LeadsController : Controller
    {
        public IActionResult Index()
        {
            List<LeadsEntity> liads = new List<LeadsEntity>();

            LeadRepository leadRepository = new LeadRepository();

            liads = leadRepository.GetAllLeads1();

            return View(liads);
        }

        public ActionResult AddLead()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLead(LeadsEntity lead)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    LeadRepository _DbLead = new LeadRepository();
                    if(_DbLead.AddLead(lead))
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View();

            }
            catch (Exception)
            {

              return View("Error");
            }
        }
        public IActionResult EditLead(int Id) 
        { 
            LeadsEntity leads = new LeadsEntity();
            LeadRepository leadRepository = new LeadRepository();
            leads = leadRepository.GetLeadById(Id);
            return View(leads);
        }
   
        public IActionResult EditLeadDetails(int Id,LeadsEntity leads)
        {
            if (ModelState.IsValid)
            {
                LeadRepository _DbLead = new LeadRepository();
                if (_DbLead.EditLeadDetails(Id,leads))
                {
                    return RedirectToAction("Index");
                }
            }
            return View();

        }

        public IActionResult DeleteLead(int Id)
        {
            LeadsEntity leads = new LeadsEntity();
            LeadRepository leadRepository = new LeadRepository();
            leads = leadRepository.GetLeadById(Id);
            return View(leads);
        }
        
        public IActionResult DeleteLeadDetails(int Id, LeadsEntity leads)
        {
            if (ModelState.IsValid)
            {
                LeadRepository _DbLead = new LeadRepository();
                if (_DbLead.DeleteLeadDetails(Id, leads))
                {
                    return RedirectToAction("Index");
                }
            }
            return View();

        }
    }
}
