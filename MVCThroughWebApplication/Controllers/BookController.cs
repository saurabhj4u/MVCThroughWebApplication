using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCThroughWebApplication.Controllers;
using MVCThroughWebApplication.Models;

namespace MVCThroughWebApplication.Controllers
{
    public class BookController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Book
        public ActionResult Index()
        {
            var res = db.GetAllBook();
            List<Book> myList = new List<Book>();
            foreach(var r in res)
            {
                Book b1 = new Book();
                b1.BId = r.BId;
                b1.BName = r.BName;
                b1.Price = r.Price;
                myList.Add(b1);
            }
            return View(myList);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            var res = db.SearchBook(id);
            Book b1 = new Book();
            foreach(var r in res)
            {
                b1.BId = r.BId;
                b1.BName = r.BName;
                b1.Price = r.Price;
            }
            return View(b1);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            Book b1 = new Book();
            return View(b1);
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book b1)
        {
            try
            {
                // TODO: Add insert logic here

                db.SaveBook(b1.BId,b1.BName,b1.Price );
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            var res = db.SearchBook(id);
            Book b1 = new Book();
            foreach(var r in res)
            {
                b1.BId = r.BId;
                b1.BName = r.BName;
                b1.Price = r.Price;
            }
            return View(b1);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book b1)
        {
            try
            {
                // TODO: Add update logic here
                db.UpdateBook(b1.BId, b1.BName, b1.Price);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            var res = db.SearchBook(id);
            Book b1 = new Book();
            foreach(var r in res)
            {
                b1.BId = r.BId;
                b1.BName = r.BName;
                b1.Price = r.Price;
            }
            return View(b1);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Book b1)
        {
            try
            {
                // TODO: Add delete logic here
                db.DeleteBook(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
