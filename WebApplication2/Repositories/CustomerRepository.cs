using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class CustomerRepository
    {
        private PizzaDBEntities objPizzaDbEntities;

        public CustomerRepository()

        {
            objPizzaDbEntities = new PizzaDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objPizzaDbEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.Customerid.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}