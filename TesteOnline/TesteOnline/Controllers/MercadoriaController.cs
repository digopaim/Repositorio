using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using AutoMapper;
using Ecommerce.core.Entities;
using Ecommerce.Data.Contexto;
using Ecommerce.Data.Interfaces;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Controllers
{
    [Authorize]
    public class MercadoriaController : Controller
    {

        private static IRepositoryMercadoria _RepositoryMercadoria;
        public MercadoriaController(IRepositoryMercadoria repositoryMercadoria)
        {
            _RepositoryMercadoria = repositoryMercadoria;
        }
        // GET: Mercadoria
        public ActionResult Index()
        {
            //Consultando lista de mercadoria
            var lista = Mapper.Map< List<Mercadoria>, List<MercadoriaViewModel>>(_RepositoryMercadoria.List());
            return View(lista);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(MercadoriaViewModel mercadoriaViewModel)
        {
            //Criando mercadoria
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                _RepositoryMercadoria.Add(Mapper.Map<MercadoriaViewModel, Mercadoria>(mercadoriaViewModel));
                var lista = Mapper.Map<List<Mercadoria>, List<MercadoriaViewModel>>(_RepositoryMercadoria.List());
                return View("Index", lista);
            }
            else
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            // Consulta no banco pelo id
            var modelView = Mapper.Map<Mercadoria, MercadoriaViewModel>(_RepositoryMercadoria.GetbyId(id));

            return View(modelView);
        }

        [HttpPost]
        public ActionResult Edit(MercadoriaViewModel mercadoriaViewModel)
        {


            var context = _RepositoryMercadoria.Context();
            var entity = Mapper.Map<Mercadoria>(mercadoriaViewModel);
            context.Set<Mercadoria>().Attach(entity); // (or context.Entity.Attach(entity);)
            context.Entry<Mercadoria>(entity).State = EntityState.Modified;
            context.SaveChanges();
            
            var lista = Mapper.Map<List<Mercadoria>, List<MercadoriaViewModel>>(_RepositoryMercadoria.List());
            return View("Index", lista);
            

        }

        public ActionResult Delete(int id)
        {
            var modelView = Mapper.Map<Mercadoria, MercadoriaViewModel>(_RepositoryMercadoria.GetbyId(id));

            return View(modelView);
        }
        [HttpPost]
        public ActionResult Delete(MercadoriaViewModel mercadoriaViewModel)
        {
           
            _RepositoryMercadoria.Delete(_RepositoryMercadoria.GetbyId(mercadoriaViewModel.Id));
            var lista = Mapper.Map<List<Mercadoria>, List<MercadoriaViewModel>>(_RepositoryMercadoria.List());
            return View("Index", lista);
        }
        public ActionResult Details(int id)
        {
            var modelView = Mapper.Map<Mercadoria, MercadoriaViewModel>(_RepositoryMercadoria.GetbyId(id));

            return View(modelView);
        }
        
    }
}