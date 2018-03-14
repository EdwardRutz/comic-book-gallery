using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }     //Used to uniquely identify a comic book
        public string SeriesTitle { get; set; }     //The series to which the comic book belongs
        public int IssueNumber { get; set; }        //Comic Book's issue number
        public string DescriptionHtml { get; set; }     //Comic book's description contains HTML content
        public Artist[] Artists { get; set; }       //References Artist.cs model
        public bool Favorite { get; set; }      //Is comic a favorite?

        //Uniquely identify comic book
        public string DisplayText
        {
            //Return a string that is a combination of series title and issue number
            //Make this property read-only by not defining a setter
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        //Display cover image
        //Naming convention for cover images is series-title-issuenumber.jpg
        //Read only since it does not contain a setter

        public string CoverImageFileName
        {
            get
            {
                //Replace spaces in file name with hyphens
                //Make lowercase
                 return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    };
}