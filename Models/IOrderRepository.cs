using System.Linq;

using newINTEX.Data;

namespace newINTEX.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
