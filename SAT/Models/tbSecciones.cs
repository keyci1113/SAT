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
    
    public partial class tbSecciones
    {
        public int sec_Id { get; set; }
        public string sec_Descripcion { get; set; }
        public int sec_UsuarioCrea { get; set; }
        public System.DateTime sec_FechaCrea { get; set; }
        public Nullable<int> sec_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> sec_FechaModifica { get; set; }
        public int jgra_Id { get; set; }
    
        public virtual tbJornadaGrados tbJornadaGrados { get; set; }
    }
}
