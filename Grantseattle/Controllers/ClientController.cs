using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryERP.Service.Services.Services;
using InventoryERP.Services;

namespace InventoryERP.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        protected INewsPortalService NewsPortalService { get; private set; }
        protected IAccountService AccountService { get; private set; }
        protected IBlogPostService BlogPostService { get; private set; }
        protected IBlogCategoryService BlogCategoryService { get; private set; }
        public ClientController(INewsPortalService newsPortalService, 
            IAccountService accountService, 
            IBlogPostService blogPostService,
            IBlogCategoryService blogCategoryService)
        {
            NewsPortalService = newsPortalService;
            AccountService = accountService;
            BlogPostService = blogPostService;
            BlogCategoryService = blogCategoryService;
        }
        // GET: Client
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AboutUs()
        {
            return View("Aboutus");
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult News()
        {
            var newsList = NewsPortalService.GetNewsList();
            return View(newsList);
            
        }
        [HttpGet]
        public ActionResult Blog()
        {
            var blogList = BlogPostService.GetList();
            ViewBag.category =BlogCategoryService.GetList();
            return View(blogList);
        }
        [HttpGet]
        public ActionResult OurService()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MyFavourite()
        {
            return View();
        }
        
    }
}
