using Infrastructure.Data;
using Domain.Interfaces;
using Infrastructure.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EcommerceProject.Controllers
{
    public class ShoppingCart : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }

}
