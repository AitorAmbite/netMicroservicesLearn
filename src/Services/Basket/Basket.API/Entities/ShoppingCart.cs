﻿namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string Username { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string username)
        {
            Username = username;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal price = 0;
                foreach (var item in Items)
                {
                    price += item.Price * item.Quantity;
                }
                return price;

            }
        }
    }

}
