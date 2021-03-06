﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeDesignz.Models.Interfaces
{
    public interface IInventory
    {

        // Add item to the cart
        Task AddCartItem(CartItems CartItem);
        //Read one Item
        Task<Inventory> GetInventoryByID(int id);

        Task<Cart> GetCart(string username);


        //Read all items
        Task<List<Inventory>> GetInventories();

        //Update
        Task UpdateInventory(Inventory inventory);

        //Delete
        Task DeleteInventory(int id);


    }
}
