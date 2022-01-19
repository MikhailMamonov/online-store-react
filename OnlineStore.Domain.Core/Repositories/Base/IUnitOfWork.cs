using System.Threading.Tasks;

namespace OnlineShop.Domain.Services.Interfaces.Base
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        IOrderRepository Orders { get; }

        Task CompleteAsync();
    }
}
