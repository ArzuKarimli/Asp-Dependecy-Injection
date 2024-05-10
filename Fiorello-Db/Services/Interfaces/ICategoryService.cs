using Fiorello_Db.Models;

namespace Fiorello_Db.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
    }
}
