using TestHsAPI.Models;

namespace TestHsAPI.service
{
    public class DiscountService
    {
        public decimal ApplyDiscount(Hs hs)
        {
            decimal discount = 0;

            // Apply discount based on the number of subjects
            if (hs.Somondangki >= 2 && hs.Somondangki <= 3)
            {
                discount = 0.20m;
            }
            else if (hs.Somondangki >= 4)
            {
                discount = 0.35m;
            }

            // Apply discount based on the registration date
            if (hs.NgayDangKi.Month == 2 && hs.NgayDangKi.Year == 2025)
            {
                discount = Math.Max(discount, 0.30m);
            }

            // Apply the discount to the price
            return hs.Price * (1 - discount);
        }
    }
}
