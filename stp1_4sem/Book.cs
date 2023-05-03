using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stp1_4sem
{
    class Book
    {

        public Book(int new_ID, string new_author, string new_title, string new_year_of_publication, string new_thematic, string new_status, string new_date_of_issue, string new_count)
        {
            ID = new_ID;
            Author = new_author;
            Title = new_title;
            Year_of_publication = new_year_of_publication;
            Thematic = new_thematic;
            Status = new_status;
            Date_of_issue = new_date_of_issue;
            Count = new_count;
        }
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Year_of_publication { get; set; }
        public string Thematic { get; set; }
        public string Status { get; set; }
        public string Date_of_issue { get; set; }
        public string Count { get; set; }
    }
}
