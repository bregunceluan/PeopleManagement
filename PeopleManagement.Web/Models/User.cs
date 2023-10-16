using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PeopleManagement.Web.Models
{
    public class User
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public int CargoId { get; set; }
        public int EquipeId { get; set; }
        public int SetorId { get; set; }
        public DateTime DateAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public string Empresa { get; set; }
    }
}
