//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academia.Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class modulos_usuarios
    {
        public int id_modulo_usuario { get; set; }
        public int id_modulo { get; set; }
        public int id_usuario { get; set; }
    
        public virtual modulo modulo { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
