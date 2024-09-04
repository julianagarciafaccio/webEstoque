using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using webEstoque.Models.Business;

namespace webEstoque.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public async Task<JsonResult> VerificaLoginAsync(string cpf, string senha)
        {
            return Json(await new LoginBusiness().VerificaLoginAsync( cpf, senha), JsonRequestBehavior.AllowGet);
        }

    }
}