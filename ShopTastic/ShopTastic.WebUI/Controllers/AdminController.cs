using Microsoft.AspNet.Identity.EntityFramework;
using ShopTastic.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopTastic.WebUI.Controllers
{
    
    public class AdminController : Controller
    {
        
        ApplicationDbContext context;
        public AdminController()
        {

            context = new ApplicationDbContext();
        }
        // GET: Role
        public ActionResult Index()
        {
            
            var Roles = context.Roles.ToList();
            return View(Roles);
        }
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
} 
    