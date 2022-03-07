using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class PaymentTypeRepository
    {
        private PizzaDBEntities objPizzaDbEntities;
        // not created sussfully! [fixed]
        public PaymentTypeRepository()
        {
            objPizzaDbEntities = new PizzaDBEntities();
            // unable to be created for new object![fixed]
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objPizzaDbEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentTypeName, // check error!
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}