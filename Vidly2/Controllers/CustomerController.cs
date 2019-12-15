using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {

            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult CustomerDetails(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            return View(customer);
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
               new Customer { Id = 1, Name = "Chance"},
               new Customer { Id = 2, Name = "Tamara"}
            };
        }
    }
}