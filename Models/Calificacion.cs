//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yakuza.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calificacion()
        {
            this.Comentario = new HashSet<Comentario>();
        }
    
        public int idCalificacion { get; set; }
        public string puntajeCalificacion { get; set; }
        public int idPlatillo { get; set; }
        public int IdUsuario { get; set; }
    
        public virtual Platillo Platillo { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario> Comentario { get; set; }
    }
}