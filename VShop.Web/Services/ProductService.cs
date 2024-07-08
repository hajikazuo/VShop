using System.Text.Json;
using VShop.Web.Models;
using VShop.Web.Services.Interfaces;

namespace VShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _clientFactory;
        private const string apiEndpoint = "/api/products";
        private JsonSerializerOptions _options;
        private ProductViewModel productVM;
        private IEnumerable<ProductViewModel> productsVM;

        public ProductService(HttpClient clientFactory)
        {
            _clientFactory = clientFactory;
            _options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true };
        }

        public Task<IEnumerable<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> Create(ProductViewModel productVM)
        {
            throw new NotImplementedException();
        }
        public Task<ProductViewModel> Update(ProductViewModel productVM)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> Delete(int id)
        {
            throw new NotImplementedException();
        }   
    }
}
