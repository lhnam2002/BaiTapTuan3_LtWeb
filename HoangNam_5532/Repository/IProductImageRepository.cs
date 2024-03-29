using HoangNam_5532.Models;

namespace HoangNam_5532.Repository
{
    public interface IProductImageRepository
    {
        Task<IEnumerable<ProductImage>> GetAllAsync();
        Task<ProductImage> GetByIdAsync(int id);
        Task<IEnumerable<ProductImage>> GetByProductIdAsync(int id);

        Task AddAsync(ProductImage productImage);
        Task UpdateAsync(ProductImage productImage);
        Task DeleteAsync(int id);
    }
}
