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
        // Return type is ActionResult
        public ActionResult Detail()
        {

            return new Content("Hello from the comic books controller!")
        }
    }
}