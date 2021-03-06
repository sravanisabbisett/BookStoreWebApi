﻿using commonLayerr.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposistryLayer.Interfaces
{
    public interface ICartRL
    {
        bool AddCart(CartItem productId);
        bool UpdateCart(CartItem productId);
        List<CartItem> GetCartItems(string LoggedInUser);
        bool RemoveCartItem(CartItem product_id);
        bool ReduceBookQuantity(CartItem product_id);
        bool ClearCartItems(string LoggedInUser);
    }
}
