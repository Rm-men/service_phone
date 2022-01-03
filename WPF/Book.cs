using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class Book
    {
        public Book()
        {
            Description = "описание по усмолчанию";
            Title = "заголовок по усмолчанию";

        }
        public Book(string title, string description)
        {
            Description = description;
            Title = title;
        }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
