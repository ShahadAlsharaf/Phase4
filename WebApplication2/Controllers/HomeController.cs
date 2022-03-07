using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private PizzaDBEntities objPizzaDbEntities;

        public HomeController()
        {
            objPizzaDbEntities = new PizzaDBEntities();

        }
        // GET: Home
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PaymentTypeRepository objPaymentRepository = new PaymentTypeRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>
                (objCustomerRepository.GetAllCustomers(), objItemRepository.GetAllItems(), objPaymentRepository.GetAllPaymentType());
            return View(objMultipleModels);
        }

        {HttpGet }
    public JsonResult getItemUnitPrice(int itemId)
    {
        decimal UnitPrice = objPizzaDbEntities.Items.Single(ModelBinderAttribute.ItemId == itemId).ItemPrice;
        return Json(UnitPrice, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public JsonResult Index(OrderViewModel objOrderViewModel) objOrderViewModel = {OrderViewModel}
        {
    OrderRepository orderRepository = new OrderRepository();
    orderRepository.AddOrder(objOrderViewModel);
          return Json("Order Successfully Created", JsonRequestBehavior.AllowGet);
        }

     }

    
}