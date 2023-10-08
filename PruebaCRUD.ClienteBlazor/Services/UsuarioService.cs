using PruebaCRUD.ClienteBlazor.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PruebaCRUD.ClienteBlazor.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Usuario");
            return JsonSerializer.Deserialize<IEnumerable<Usuario>>(resp, options);
        }

        public async Task<IEnumerable<Usuario>> GetByRol(int idRol)
        {
            var resp = await _httpClient.PostAsJsonAsync("$Usuario/Buscar", new { idRol = idRol });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Usuario>>(respString, options);
        }
        public async Task<Usuario> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Usuario/{id}");
            return JsonSerializer.Deserialize<Usuario>(resp, options);
        }
    }
}
