using PruebaCRUD.ClienteBlazor.Models;

namespace PruebaCRUD.ClienteBlazor.Services
{
    public interface IRolService
    {
        Task<IEnumerable<Rol>> GetAll();
    }
}
