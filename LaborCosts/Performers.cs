//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaborCosts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Performers
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public int IdUser { get; set; }
        public Nullable<int> Hours { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}
