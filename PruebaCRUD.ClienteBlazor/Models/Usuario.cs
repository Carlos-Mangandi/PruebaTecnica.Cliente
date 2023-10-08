namespace PruebaCRUD.ClienteBlazor.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        //public Rol Rol { get; set; }
    }
}
