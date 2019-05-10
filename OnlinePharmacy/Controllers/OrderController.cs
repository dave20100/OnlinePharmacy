﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlinePharmacy.Models;

namespace OnlinePharmacy.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;

        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        public ViewResult Checkout() => View(new Order());

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if(cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Cart is empty");
            }
            
            if (ModelState.IsValid)
            {
                if (cart.Lines.Any((l) => l.Product.IsPrescripted) && order.Prescription == null)
                {
                    return View("Prescription", order);
                }
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}