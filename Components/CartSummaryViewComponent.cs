﻿using BookProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;

        public CartSummaryViewComponent(Basket temp)
        {
            basket = temp;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }

    }
}
