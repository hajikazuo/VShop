using VShop.Web.Models;

namespace VShop.Web.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<ProductViewModel> GetById(int id);
        Task<ProductViewModel> Create(ProductViewModel productVM);
        Task<ProductViewModel> Update(ProductViewModel productVM);
        Task<bool> Delete(int id);
    }
}
