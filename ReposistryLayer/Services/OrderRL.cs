using commonLayerr.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ReposistryLayer.Interfaces;

namespace ReposistryLayer.Services
{
    public class OrderRL : IOrderRL
    {
        private readonly BookStoreContext context;

        public OrderRL(BookStoreContext context)
        {
            this.context = context;
        }
        public NewOrder PlaceOrder(string LoggedInUser)
        {
            try
            {
                List<CartItem> list = (from e in this.context.cartItems
                                       select new CartItem
                                       {
                                           product_id = e.product_id,
                                           quantityToBuy = e.quantityToBuy,
                                           loginUser = e.loginUser,
                                           Product = e.Product,
                                       }).Where(x => x.loginUser == LoggedInUser).ToList<CartItem>();
               // var customer = this.context.customerDetails.Find(x => x.email == LoggedInUser).FirstOrDefault();
                var customer = (from data in context.customerDetails
                                    where data.email == LoggedInUser
                                    select data).FirstOrDefault();

                NewOrder newOrder = new NewOrder();
                newOrder.customer = customer;
                newOrder.customer.CustomerId = customer.CustomerId;
                this.context.Add(newOrder);
                int result = this.context.SaveChanges();
                newOrder.orders = list;
                if (newOrder.orders != null && result > 0)
                {

                    return newOrder;
                }
                else
                {
                    throw new Exception("Order not placed succesfully");
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
