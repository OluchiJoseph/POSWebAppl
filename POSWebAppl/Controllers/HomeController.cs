using System;
using System.Web.Mvc;

namespace POSWebAppl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.View_Model.NewAgents newAgent)
        {
            try
            {
                var db = new Models.DB_Model.Model1();
                var agen = new Models.DB_Model.Agent_Profile();
                agen.Agent_Name = newAgent.AgentName;
                agen.Working_Area = newAgent.WorkingArea;
                agen.Phone_Number = newAgent.PhoneNumber.ToString();
                agen.Regdate = DateTime.UtcNow.AddHours(1);
                db.Agent_Profile.Add(agen);
                db.SaveChanges();
                return RedirectToAction("SuccessfulReg");
            }
            catch (Exception Ex)
            {
                ViewBag.ErrorMessage = "Unsuccessful Registration";
                return View();
            }
        }

        public ActionResult SuccessfulReg()
        {
            return View();
        }
    }
}