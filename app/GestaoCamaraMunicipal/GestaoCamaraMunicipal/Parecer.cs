//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestaoCamaraMunicipal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parecer
    {
        public int Numero { get; set; }
        public string TextoParecer { get; set; }
        public System.DateTime DataParecer { get; set; }
        public int ProjetoId { get; set; }
        public int ProjetoProcessoId { get; set; }
        public int FuncionarioNumero { get; set; }
    
        public virtual Projeto Projeto { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
