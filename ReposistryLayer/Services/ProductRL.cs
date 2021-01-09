using commonLayerr.Models;
using ReposistryLayer.Interfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReposistryLayer.Services
{
    public class ProductRL : IProductRL
    {
        private readonly BookStoreContext context;

        public ProductRL(BookStoreContext context)
        {
            this.context = context;
        }
        public List<Product> GetAllProducts()
        {
            try
            {
                var employeeRecord = from p in this.context.products.ToList() select p;
                var car = from c in this.context.cartItems.ToList() select c;
                List<Product> products = new List<Product>();
                foreach (Product item in employeeRecord)
                {
                    var r = this.context.cartItems.Where(x =>
                                                    x.product_id == item.product_id).FirstOrDefault();

                    if (r != null)
                    {
                        item.addedToCart = true;
                    }
                    else
                    {
                        item.addedToCart = false;
                    }


                    products.Add(item);

                }
                /*List<Product> list = (from e in this.context.products
                                      select new Product
                                      {
                                          product_id = e.product_id,
                                          bookName = e.bookName,
                                          bookImage = e.bookImage,
                                          author = e.author,
                                          description = e.description,
                                          quantity = e.quantity,
                                          price = e.price,
                                          discountPrice = e.discountPrice,

                                      }).ToList<Product>();


                return list;*/
                return products;
                }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
