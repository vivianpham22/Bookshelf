﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }


        [Display(Name = "Category")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; } // Navigation property allows to connect with classes 

    }
}