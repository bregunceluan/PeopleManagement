using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PeopleManagement.API.Model.Base;

namespace PeopleManagement.API.Model
{
    [Table("equipe")]
    public class Equipe : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("descricao")]
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }


        [Column("coordenadorId")]
        [Required]
        public int CoordenadorId { get; set; }


        [Column("gestorId")]
        [Required]
        public int GestorId { get; set; }
    }
}
