//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCarreras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCarreras()
        {
            this.tbCarreraAsignaturas = new HashSet<tbCarreraAsignaturas>();
        }
    
        public int car_Id { get; set; }
        public string car_Descripcion { get; set; }
        public int car_Encargado { get; set; }
        public int car_UsuarioCrea { get; set; }
        public System.DateTime car_FechaCrea { get; set; }
        public Nullable<int> car_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> car_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCarreraAsignaturas> tbCarreraAsignaturas { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
