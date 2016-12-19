using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using Ecommerce.Data.Contexto;
using Ecommerce.core.Entities;
using Ecommerce.Data.Interfaces;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Controllers
{
    public class LoginsController : Controller
    {
        private static IRepositoryLogin _repositoryLogin;
        public LoginsController(IRepositoryLogin repositoryLogin)
        {
            _repositoryLogin = repositoryLogin;
        }


        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var login = _repositoryLogin.Autenticacao(model.Usuario, model.Password);
            if (login != null)
            {
                FormsAuthentication.SetAuthCookie(model.Usuario, false);

                return RedirectToAction("Index", "Home");
            }
            else
            {

                return JavaScript("$('#myModal').modal('show');$('#mensagem').html('Usuário ou  senha inválida!');");
            }
        }


        [Authorize]
        public ActionResult Index()
        {
            var model = Mapper.Map<List<LoginViewModel>>(_repositoryLogin.List());
            return View(model);
        }


        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Logins");
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var  login = Mapper.Map<LoginViewModel>(_repositoryLogin.GetbyId(id));
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        [Authorize]

        public ActionResult Create()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Usuario,Password")] LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                _repositoryLogin.Add(Mapper.Map<Login>(login));
                return RedirectToAction("Index");
            }

            return View(login);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var login = Mapper.Map<LoginViewModel>(_repositoryLogin.GetbyId(id));
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Usuario,Password")] LoginViewModel login)
        {
            if (ModelState.IsValid)
            {

                var context = _repositoryLogin.Context();
                var entity = Mapper.Map<Login>(login);
                context.Set<Login>().Attach(entity); // (or context.Entity.Attach(entity);)
                context.Entry<Login>(entity).State = EntityState.Modified;
                context.SaveChanges();

                var lista = Mapper.Map<List<Login>, List<LoginViewModel>>(_repositoryLogin.List());
                return RedirectToAction("Index",lista);
            }
            return View(login);
        }


        [Authorize]
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var login = Mapper.Map<LoginViewModel>(_repositoryLogin.GetbyId(id));
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }


        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var login = Mapper.Map<Login>(_repositoryLogin.GetbyId(id));
            _repositoryLogin.Delete(login);
            return RedirectToAction("Index");
        }


    }
}
