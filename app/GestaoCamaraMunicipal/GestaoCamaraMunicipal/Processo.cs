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
    
    public partial class Processo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Processo()
        {
            this.Projeto = new HashSet<Projeto>();
        }
    
        public int Id { get; set; }
        public System.DateTime DataInicio { get; set; }
        public int PromotorNIF { get; set; }
        public int EstadoProcessoId { get; set; }
    
        public virtual Promotor Promotor { get; set; }
        public virtual EstadoProcesso EstadoProcesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projeto> Projeto { get; set; }
    }
}
