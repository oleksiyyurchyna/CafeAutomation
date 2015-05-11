using CA.Common.Model;

namespace CA.Cook.Common
{
    public interface ICookSession
    {
        void VerifyDishIsPreparing(OrderDish orderDish);

        void RefusePreparing(OrderDish orderDish);

        void VerifyDishIsPrepared(OrderDish orderDish);
    }
}