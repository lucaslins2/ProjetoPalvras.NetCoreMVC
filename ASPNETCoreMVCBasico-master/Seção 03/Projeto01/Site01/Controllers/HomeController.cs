using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext _db;

        public HomeController(DatabaseContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid) {

                
             



                if (usuario.Email == "test@gmail.com" && usuario.Senha == "123456") 
                {
                    /*
                     * Add Session
                     * HttpContext.Session.SetString("Login", "true");
                     * HttpContext.Session.SetInt32("UserID", 32);
                     * HttpContext.Session.SetString("Login", Serializar Object > String);

                     * Ler Session
                     * string login = HttpContext.Session.GetString("Login");
                     */

                    
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos!";
                    return View();
                }
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult CadLogin([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                _db.Usuarios.Add(usuario);
                _db.SaveChanges();
                TempData["Mensagem"] = "O login '" + usuario.Email + "' foi cadastrada com sucesso!";

                return RedirectToAction("Index");


            }
            else
            {
                return View();

            }

              

        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
        
    }
}
