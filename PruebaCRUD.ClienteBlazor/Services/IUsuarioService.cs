using PruebaCRUD.ClienteBlazor.Models;

namespace PruebaCRUD.ClienteBlazor.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<IEnumerable<Usuario>> GetByRol(int idRol);
        Task<Usuario> GetById(int id);
    }
}
