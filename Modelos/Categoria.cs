﻿using System.ComponentModel.DataAnnotations;

namespace Laboratorio_web_15_8_2022.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la categoria es obligatorio")]
        [StringLength(15, ErrorMessage = "El nombre debe tener entre {2} y {1}", MinimumLength = 4)]
        
        public string Nombre { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creacion")]
        public DateTime? FechaCreacion { get; set; }
    }
}
