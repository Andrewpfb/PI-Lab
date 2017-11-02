using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC5.Models;

namespace MVC5.Controllers
{
    public class PhonesController : Controller
    {
        private PhonesContext db = new PhonesContext();

        [HttpGet]
        public ActionResult Browse()
        {
            IEnumerable<Phones> phones = db.Phones;
            return View(phones);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Phones phone)
        {
            db.Phones.Add(phone);
            db.SaveChanges();
            return RedirectToAction("Browse", "Phones");
        }

        [HttpGet]
        public ActionResult Update(string phone)
        {
            Phones tmpPhone = db.Phones.Find(phone);
            if (tmpPhone == null)
            {
                return HttpNotFound();
            }
            return View();
        }
        [HttpPost]
        public ActionResult Update(Phones phone)
        {
            Phones tmpPhone = db.Phones.Find(phone.Phone);
            tmpPhone.Surname = phone.Surname;
            tmpPhone.Firstname = phone.Firstname;
            tmpPhone.MiddleName = phone.MiddleName;
            tmpPhone.BDay = phone.BDay;
            tmpPhone.Phone = phone.Phone;
            db.Entry(tmpPhone).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Browse", "Phones");
        }

        [HttpGet]
        public ActionResult Delete(string phone)
        {
            Phones tmpPhone = db.Phones.Find(phone);
            if(tmpPhone==null)
            {
                ; return HttpNotFound();
            }
            return RedirectToAction("Browse", "Phones");
        }
    }
}