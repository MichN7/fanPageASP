//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fanPageASP.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUserRole
    {
        public int SYSUserRoleID { get; set; }
        public int SYSUserID { get; set; }
        public int LOOKUPRoleID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int RowCreatedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowModifiedDateTime { get; set; }
    
        public virtual LOOKUPRole LOOKUPRole { get; set; }
        public virtual SYSUser SYSUser { get; set; }
    }
}