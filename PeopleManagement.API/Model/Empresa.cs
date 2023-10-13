﻿using PeopleManagement.API.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PeopleManagement.API.Model
{
    [Table("empresa")]
    public class Empresa : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("descricao")]
        [StringLength(100)]
        public string Descricao { get; set; }
    }
}
