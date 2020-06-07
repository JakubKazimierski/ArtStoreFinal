using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StronaPrototyp.Models
{
    public class SoldPaintingsModel
    {
        public string Title { get; set; }
        public string Style { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }

        //constructor
        public SoldPaintingsModel(string title, string style, string author, decimal price, string photo)
        {
            Title = title;
            Style = style;
            Author = author;
            Price = price;
            Photo = photo;
        }
    }
}

