using Dependecy_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dependecy_Injection.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository repository;
        public BookController(IBookRepository repo)
        {
            this.repository = repo;
        }
        // GET: Book
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Book book)
        {
            if (ModelState.IsValid)
                repository.Add(book);
            return RedirectToAction("Index");
        }
    }
}