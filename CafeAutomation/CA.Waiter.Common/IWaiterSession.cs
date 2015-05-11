using System.Collections.Generic;

using CA.Common;
using CA.Common.Model;

namespace CA.Waiter.Common
{
    public interface IWaiterSession
    {
        LoginResult Login(long waiterNumber);

        void PlaceOrder(Order order);

        void VerifyOrder(Order order);

        List<Order> GetAllOrders();

        List<Order> GetTableOrders(int tableNumber);

        List<Order> GetUnverifiedOrders();
    }
}
