using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    // Create a controller
    // class inherits from the Controller base class
    public class ComicBooksController : Controller
    {
        //Private field names typically start with an underscore
        private ComicBookRepository _comicBookRepository = null;  //Private field for repository

        //Create an instance of the repository
        //Constructors initialize instance members
        //Constructor names are the same as the class names and do not have a return type

        public ComicBooksController ()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        //Index action method to get a list of comics
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);    //passes comicbook array into the view method
        }

        // Return type is ActionResult
        public ActionResult Detail(int? id)     //nullable type
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            //Substantiate a comic book model object
            //Set model instance property values with object initializer syntax (braces)
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            
            return View(comicBook);
        }
    };
}