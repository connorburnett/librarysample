using System.Collections.Generic;

namespace mchaltue.Models
{
    public class Book : IPublication
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public string ISBN;

        // public Book(string title, string publisher, int pages, string isbn)
        // {
        //     Title = title;
        //     Publisher = publisher;
        //     Pages = pages;
        //     ISBN = isbn;
        // }
    }
}