//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sgtcc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tcc2 : Tcc
    {
        public string data { get; set; }
        public string local { get; set; }
    
        public virtual Banca Banca { get; set; }
    }
}