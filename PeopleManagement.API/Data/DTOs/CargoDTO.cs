using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PeopleManagement.API.Data.DTOs
{
    public class CargoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
    }
}
