using MVC_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
namespace MVC_APP.Controllers
{
    public class EmployeeRegistrationController : Controller
    {

        public ActionResult Register(RegisterViewModel model)
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string username,string password)
        {
                
            try
            {
                using (EmployeeEntities entity = new EmployeeEntities())
                {
                    var data = entity.Registrations.Where(x => x.UserName== username && x.password.ToLower() == password).ToList();
                    if (data.Count()>0)
                        return Json(data, JsonRequestBehavior.AllowGet);
                    else
                        return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }
        [HttpPost]
        public JsonResult Registration(Registration bl)
        {
            try
            {
                using (EmployeeEntities entity = new EmployeeEntities())
                {
                    entity.Registrations.Add(bl);
                    entity.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}