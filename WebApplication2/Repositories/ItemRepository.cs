using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class ItemRepository
    {
        private PizzaDBEntities objPizzaDbEntities;
       
        public ItemRepository()
        {
            objPizzaDbEntities = new PizzaDBEntities();
           
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objPizzaDbEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName, 
                                      Value = obj.Itemid.ToString(),
                                      Selected = false
                                  }).ToList();
            return objSelectListItems;
        }
    }
}