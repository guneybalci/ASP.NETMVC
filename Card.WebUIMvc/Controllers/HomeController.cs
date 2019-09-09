using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Card.Bll.Concrete;
using Card.Dal.Concrete.EntityFramework;
using Card.Entities;

namespace Card.WebUIMvc.Controllers
{
    public class HomeController : Controller
    {
        private PersonManager _personManager;

        public HomeController()
        {
            _personManager = new PersonManager(new EfPersonDal());
        }

        [HttpGet]
        public ActionResult Index()
        {
            var persons = _personManager.GetAll();
            return View(persons);
        }

        [HttpPost]
        public ActionResult Index(string searchText)
        {
            searchText = searchText.ToLower();
            var persons = _personManager.GetAll().Where(x => x.Name.ToLower().Contains(searchText) || x.Surname.ToLower().Contains(searchText) || x.Email.ToLower().Contains(searchText) || x.Company.ToLower().Contains(searchText)).ToList();
            return View(persons);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _personManager.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Person model)
        {
            _personManager.Add(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var person = _personManager.Get(id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Update(Person model)
        {
            _personManager.Update(model);
            return RedirectToAction("Index");
        }
        
    }
}