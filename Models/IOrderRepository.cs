using System.Linq;
namespace newINTEX.Models
using newINTEX.Data;

namespace AzureAppINTEX.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
} }
