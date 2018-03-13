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

        // Return type is ActionResult
        public ActionResult Detail()
        {
            //Substantiate a comic book model object
            //Set model instance property values with object initializer syntax (braces)
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus's life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                //change the array element data type from string to artist
                //Instantiate an Artists array
                //Add an artist model instance with empty name and role properties for each element added to the array (5 elements).
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                }
            
            };
            
            return View(comicBook);
        }
    }
}