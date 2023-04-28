using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUDOperationsBooksProj;
using BooksDataAccessLib;

namespace BooksBusinessLib
{
    public class BooksBusinessLayer
    {
        public int AddBooks(Books b)
        {
            BooksDataAccessLayer dal = new BooksDataAccessLayer();
            var count = dal.AddBooks(b);
            return count;
        }
        public int DeleteById(string bookCode)
        {
            BooksDataAccessLayer dal = new BooksDataAccessLayer();
            var count = dal.DeleteById(bookCode);
            return count;
        }
        public List<Books> GetAllBooks()
        {
            BooksDataAccessLayer dal = new BooksDataAccessLayer();
            var books = dal.GetAllBooks();
            return books;
        }
        public   Books GetBooksByBookName(string bookname)
        {
            var dal = new BooksDataAccessLayer();
            var books = dal.GetBooksByBookName(bookname);
            return books;
        }
        public Books GetBooksByBookCode(string bookcode)
        {
            var dal = new BooksDataAccessLayer();
            var books = dal.GetBooksByBookCode(bookcode);
            return books;
        }
        public int UpdateBooks(Books b)
        {
            BooksDataAccessLayer dal = new BooksDataAccessLayer();
            var count = dal.UpdateBooks(b);
            return count;
        }
    }
}
