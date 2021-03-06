﻿using commonLayerr.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface ICartBL
    {
        bool AddCart(CartItem productId);
        bool UpdateCart(CartItem productId);

        List<CartItem> GetCartItems(string LoggedInUser);
        bool RemoveCartItem(CartItem productId);
        bool ReduceBookQuantity(CartItem productId);
        bool ClearCartItems(string LoggedInUser);
        //AdminUserRegistration AdminLogin(AdminUserLogin login);
    }
}
