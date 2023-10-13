namespace PeopleManagement.API.Data.DTOs
{
    public class EquipeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public int CoordenadorId { get; set; }
        public int GestorId { get; set; }

    }
}
