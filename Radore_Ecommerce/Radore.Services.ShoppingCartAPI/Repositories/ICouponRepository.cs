using Radore.Services.ShoppingCartAPI.Models.Dto;

namespace Radore.Services.ShoppingCartAPI.Repositories
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
