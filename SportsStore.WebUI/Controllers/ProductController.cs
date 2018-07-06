using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List(string category, int page=1)
        {
            //return View(repository.Product.OrderBy(p=>p.ProductID).Skip((page-1)*PageSize).Take(PageSize)); //페이징 끊어서 
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Product.Where(c => category == null || c.Category == category).OrderBy(p => p.ProductID).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    //TotalItem = repository.Product.Count()
                    TotalItem = category == null ? repository.Product.Count() : repository.Product.Where(c => c.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}