//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StaCatalina
{
    using System;
    using System.Collections.Generic;
    
    public partial class comUsuarioEnviaMail
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Usuario_EnviaMail { get; set; }
    
        public virtual TBL_Usuarios TBL_Usuarios { get; set; }
    }
}
