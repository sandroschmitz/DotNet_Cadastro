//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cadastro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public Nullable<System.DateTime> dataNascimento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }
}
