using System.Collections.Generic;

using CA.Common;
using CA.Common.Enum;
using CA.Common.Model;

namespace CA.Client.Common
{
    public interface IClientSession
    {
        LoginResult Login(long cardNumber);

        LoginResult Login(string login);

        CA.Common.Model.Client Register(Man newClient);

        List<Dish> GetMenu();

        void PlaceOrder(Order order);

        void CallWaiter(Waiter waiter);

        Bill GetCurrentBill();

        PaymentStatus PayBill(CreditCardInfo creditCardInfo);
    }
}