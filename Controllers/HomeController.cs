using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagementCrudApp.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller 
    {
        public ActionResult Index()
        {
            return View();
        }
// create get route
        public ActionResult Create()
        {
            return View();
        }
        // create post route 

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                using (var context = new UserContext())
                {
                    context.Users.Add(user);        // Add user to DbSet
                    context.SaveChanges();          // Commit to database
                }
                return RedirectToAction("Index");   // Redirect after success
            }

            return View(user); // Show form again if validation fails
        }
        



        public ActionResult Read()
        {
            return View();
        }


    }
}