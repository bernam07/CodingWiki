﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Fluent_Book
    {
        public int Book_Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string PriceRange { get; set; }
        public virtual Fluent_BookDetail BookDetail { get; set; }
        public int Publisher_Id { get; set; }
        public virtual Fluent_Publisher Publisher { get; set; }
        //public List<Fluent_Author> Authors { get; set; }

        public virtual List<Fluent_BookAuthorMap> BookAuthors { get; set; }
    }
}
