using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MD.PersianDateTime;
using PCMS.ModelViews;
using PCMS.OtherClasses;

namespace ShoppingCMS.Controllers
{
    public class ProductController : Controller
    {


        public ActionResult Product_List()
        {
            return View();
        }

        public ActionResult Product_table(bool SearchBox, string text = "")
        {
            //var itemList = new ProductModel()
            //{
            //    deleted = false,
            //    disabled = true,
            //    Category = "محصولات دیجیتال-موبایل-سامسونگ گلکسی s8",
            //    MainPrice = "12000000",
            //    Description = "گوشی خوبیه",
            //    AddBy = "niky",
            //    PicPath = "https://localhost:44395/assets/download.jpg",
            //    Date = "1398/12/4",
            //    Title = "galaxy s8",
            //    Id = 1,
            //    Num = 1
            //};

            ModelFiller MF = new ModelFiller();
            string query = "";
            if (SearchBox)
            {
                query = MF.QueryMaker(true, text);
            }
            else
            {
                query = MF.QueryMaker(false);
            }


            var Model = new ProductListModelView()
            {
                ProductModels = MF.productModels_List(query)
            };


            //var list=new List<ProductModel>();
            //list.Add(itemList);
            //list.Add(itemList);
            //list.Add(itemList);
            //var Model = new ProductListModelView()
            //{
            //    ProductModels = list
            //};


            return View(Model);
        }

        public ActionResult test()
        {
            DateTime date = Convert.ToDateTime("2020-02-20 12:01:11.300");
            PersianDateTime persianDateTime = new PersianDateTime(date);
            return Content(persianDateTime.ToString());
        }
    }
}