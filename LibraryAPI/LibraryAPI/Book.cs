﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    /// <summary>
    /// Definition of a book
    /// </summary>
    public class Book
    {
        #region Properties
        [Key]
        public int ISBN { get; set; }
        public string Title {get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }


        #endregion
        #region Methods
        public void Checkout()
        {
            Count--;
        }
        public void Return()
        {
            Count++;
        }
        #endregion
    }
}
