using SGpostMailData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGpostMailData.Controllers
{
    public class AdminViewController : Controller
    {

        DatabaseContext _context = new DatabaseContext();
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                var users = _context.users.ToList();
                return View(users);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            if(ModelState.IsValid)
            {

                var checkAdmin = _context.admins.Where(a => a.Username == admin.Username).ToList();

                if(checkAdmin.Count() == 0)
                {
                    ViewData["LoginError"] = "Username Not FOund!";
                    return View();
                }
                else
                {
                    var Validate = _context.admins.Where(a => a.Username == admin.Username && a.Password == admin.Password).SingleOrDefault();

                    if(Validate == null)
                    {
                        ViewData["LoginError"] = "Invalid Username and Password";
                        return View();
                    }
                    else
                    {
                        Session["username"] = Validate.Username;

                        return RedirectToAction("Index");
                    }

                }
            }

            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if(ModelState.IsValid)
            {
                System.Guid guid = System.Guid.NewGuid();

                User newUser = new User()
                {
                    Name = user.Name,
                    Email = user.Email,
                    Mobile = user.Mobile,
                    EndpointId = guid.ToString()
                };

                _context.users.Add(newUser);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }

        public ActionResult DeleteUser(int id)
        {
            var find = _context.users.Where(u => u.Id == id).SingleOrDefault();

            return View(find);
        }

        [HttpPost]
        public ActionResult DeleteUser(User user)
        {
            var find = _context.users.Where(u => u.Id == user.Id).SingleOrDefault();

            _context.users.Remove(find);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}