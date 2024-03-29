﻿using Basket.API.Entities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache;
        }

        public async Task DeleteBasket(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            var basket = await _redisCache.GetStringAsync(userName);
            if (String.IsNullOrEmpty(basket))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<ShoppingCart>(basket);
        }

        public Task<ShoppingCart> GetBasketById(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            var basketUpdateString = JsonConvert.SerializeObject(basket);
            await _redisCache.SetStringAsync(basket.Username,basketUpdateString);
            return await GetBasket(basket.Username);
        }
    }
}
