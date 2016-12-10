using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catalog.Domain.Concrete;

namespace Catalog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        /// <summary>
        /// Method returns List of all stores in database
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var stores = unitOfWork.StoreRepository.Get(includeProperties: "Goods");

            return View(stores.ToList());
        }

        public ActionResult ListGoodsByStoreId(Int32 storeId = 1)
        {
            ViewBag.StoreName =
                unitOfWork.StoreRepository.Get(includeProperties: "Goods")
                    .Where(x => (x.Id == storeId))
                    .Select(x => x.Name).ToList().First().ToString();

            var goods = unitOfWork.GoodRepository.Get().Where(x => (x.StoreId == storeId)).ToList();

            return View(goods);
        }

        /// <summary>
        /// Method returns JSON with List of goods, selected by the store's Id
        /// </summary>
        /// <param name="storeId">store's Id</param>
        /// <returns></returns>
        public ActionResult ListGoodsByStoreIdUsingAjax(Int32 storeId = 1)
        {
            var goods = unitOfWork.GoodRepository.Get().Where(x => (x.StoreId == storeId)).ToList();
            if (Request.IsAjaxRequest())
            {
                String storeName = unitOfWork.StoreRepository.Get(includeProperties: "Goods")
                    .Where(x => (x.Id == storeId))
                    .Select(x => x.Name).ToList().First();
                var formattedData = goods.Select(p => new {
                    StoreName = storeName,
                    Name = p.Name,
                    Description = p.Description
                });
                return Json(formattedData, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}