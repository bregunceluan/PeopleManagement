using PeopleManagement.API.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManagement.API.Model
{
    [Table("user")]
    public class User : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("cargoid")]
        [Required]
        public int CargoId { get; set; }

        [Column("equipeid")]
        [Required]
        public int EquipeId { get; set; }

        [Column("setorid")]
        [Required]
        public int SetorId { get; set; }

        [Column("admissao")]
        [Required]
        public DateTime DateAdmissao { get; set; }


        [Column("desligamento")]
        public DateTime DataDesligamento { get; set; }

        [Column("empresa")]
        [Required]
        public string Empresa { get; set; }

    }
}
