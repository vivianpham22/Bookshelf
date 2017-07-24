using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bookshelf.Models
{
    public class Book
    {
        [Key] // Primary key
        public int ID { get; set; } // Always want an ID when building a model
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }


        [ForeignKey("Category")] // Established relationship with another class or table 
        public int CategoryID { get; set;}
        public virtual Category Category { get; set; } // Navigation property is the first word


    }
}