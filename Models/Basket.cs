﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>(); //first part declares, second part instantiates

        //add book and it's quantity
        public virtual void AddItem(Book book, int qty)
        {
            BasketLineItem line = Items
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty,
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
        }

        //calculate total price and return sum
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }


    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
