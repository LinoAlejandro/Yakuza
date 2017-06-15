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
    
    public partial class Direccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Direccion()
        {
            this.Consumidor = new HashSet<Consumidor>();
            this.Sucursal = new HashSet<Sucursal>();
        }
    
        public int idDireccion { get; set; }
        public string municipioDireccion { get; set; }
        public string coloniaDireccion { get; set; }
        public string calleDireccion { get; set; }
        public string numeroExterior { get; set; }
        public string numeroInterior { get; set; }
        public string latitudDirecicon { get; set; }
        public string longitudDireccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consumidor> Consumidor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}
