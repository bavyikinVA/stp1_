using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace stp1_4sem
{
    class Library
    {
        public static List<Book> workplace = new List<Book>();

        public void add_book(Book book)
        {
            workplace.Add(book);
        }

        public string search(int id)
        {
            Book book = workplace[id];

            if (book.ID == id)
            {
                return book.Status;
            }
            else { return "Не существует"; }

            //return book;
        }

    }
}
