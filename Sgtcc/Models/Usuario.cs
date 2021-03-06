//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sgtcc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string nome { get; set; }

        [Required]
        [Display(Name = "CPF")]      
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "CPF must have 11 digits.")]
        public string cpf { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string telefone { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]        
        public string senha { get; set; }
    }
}
