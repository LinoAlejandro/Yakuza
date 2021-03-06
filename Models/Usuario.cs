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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Calificacion = new HashSet<Calificacion>();
            this.Carrito = new HashSet<Carrito>();
            this.Consumidor = new HashSet<Consumidor>();
        }
    
        public int IdUsuario { get; set; }
        public string nickNameUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoPaternoUsuario { get; set; }
        public string apellidoMaternoUsuario { get; set; }
        public System.DateTime fechaNacimientoUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string passwordUsuario { get; set; }
        public string Id { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calificacion> Calificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carrito> Carrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consumidor> Consumidor { get; set; }
    }
}
