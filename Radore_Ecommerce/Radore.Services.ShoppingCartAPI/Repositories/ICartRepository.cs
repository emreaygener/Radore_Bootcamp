﻿using Radore.Services.ShoppingCartAPI.Models.Dto;

namespace Radore.Services.ShoppingCartAPI.Repositories
{
    public interface ICartRepository
    {
        Task<CartDto> GetCartByUserId(string userId);

        CartDto GetCartByUserIdNonAsync(string userId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string couponCode);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
    }
}
