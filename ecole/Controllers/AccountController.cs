using ecole.model;
using ecole.proxie.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace ecole.Controllers
{
    public class AccountController : Controller
    {
        // GET: Accoun
            private readonly IAccountService Account;
            public AccountController(IAccountService Account)
            {
                this.Account = Account;
            }

        public ActionResult Index()
        {
            return View() ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (this.Account.Login(user))
            {
                //get info user

                var resulte = this.Account.EtEtudiantinfo(user);
                //set idenit y info sigin

                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, resulte.Email));
                //var ident = new ClaimsIdentity(claims, Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie);

                //var ctx = HttpContext.GetOwinContext();
                //var authenticationManager = ctx.Authentication;
                //authenticationManager.SignIn(ident);
            }
            return Redirect("Index");
        }
    }
}