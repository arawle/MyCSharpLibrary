using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Author")]
        /// <summary>
        /// same data type as the primary key in the other table that you want to relate to. Allows access to view. otherwise just entity framework internally w/out access
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// below is a one to many relationship ie each book can only be written by one author, author can write many books
        /// </summary>
        public virtual Author Author { get; set; }
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
