using MyShop.Core.Contracts;
using ShopTastic.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopTastic.WebUI.Controllers
{
    public class CheckOutController : Controller
    {
        IRepository<CheckOutPage> context;
        IBasketService basketService;
        public CheckOutController(IRepository<CheckOutPage> checkOutContext, IBasketService BasketService)
        {
            context = checkOutContext;
            this.basketService = BasketService;
        }


        // GET: CheckOut
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            CheckOutPageViewModel viewModel = new CheckOutPageViewModel();
            viewModel.checkOutPage = new CheckOutPage();
            viewModel.basketItemViewModels = basketService.GetBasketItems(this.HttpContext);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CheckOutPage checkOutPage)
        {
            if (!ModelState.IsValid)
            {
                return View(checkOutPage);
            }
            else
            {
                context.Insert(checkOutPage);
                context.Commit();
                return RedirectToAction("Index");

            }
        }

    }
}