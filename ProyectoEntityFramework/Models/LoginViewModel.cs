﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoEntityFramework.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "El campo {0} es requerido")]
       
        [EmailAddress(ErrorMessage = "El campo debe de ser un correo electronico válido")]
  
        public string Email { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
      
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Recuérdame")]
        public bool Recuerdame { get; set; }    
    }
}
