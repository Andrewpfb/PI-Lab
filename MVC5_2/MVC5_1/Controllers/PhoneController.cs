using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_1.Models;
using System.Data.Entity;

namespace MVC5_1.Controllers
{
    public class PhoneController : Controller
    {

        UserContext db = new UserContext();

        // GET: Phone
        public ActionResult Index()
        {
            IEnumerable<User> users = db.Users;
            return View(users);
        }

        // GET: Phone/Details/5
        public ActionResult Details(int id)
        {
            User user = db.Users.Find(id);
            if(user==null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Phone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phone/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Phone/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);
            if(user==null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Phone/Edit/5
        [HttpPost]
        public ActionResult Edit(User user)
        {
            try
            {
                User newUser = db.Users.Find(user.Id);
                newUser.Firstname = user.Firstname;
                newUser.Surname = user.Surname;
                newUser.Middlename = user.Middlename;
                newUser.BDay = user.BDay;
                newUser.Phone = user.Phone;
                db.Entry(newUser).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return View();
            }
        }

        // GET: Phone/Delete/5
        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            if(user==null)
            {
                return HttpNotFound();    
            }
            return View(user);
        }

        // POST: Phone/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                if(user==null)
                {
                    return HttpNotFound();
                }
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return View();
            }
        }
    }
}
