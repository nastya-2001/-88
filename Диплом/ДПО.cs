//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Диплом
{
    using System;
    using System.Collections.Generic;
    
    public partial class ДПО
    {
        public int id { get; set; }
        public string Наименование_доп_программы { get; set; }
        public Nullable<int> Наименование_области_проф_деятельности { get; set; }
        public Nullable<int> Укрупненные_группы_специальностей { get; set; }
        public string Наименование_квалиф_профессии { get; set; }
        public Nullable<int> Уровень_образования { get; set; }
        public string Фамилия_указанная_в_дипломе { get; set; }
        public string Серия_документа { get; set; }
        public string Номер_документа { get; set; }
        public Nullable<int> Год_начала { get; set; }
        public Nullable<int> Год_окончания { get; set; }
    
        public virtual гр_специальностей гр_специальностей { get; set; }
        public virtual область_проф_деятельности область_проф_деятельности { get; set; }
        public virtual Уровень_образования Уровень_образования1 { get; set; }
    }
}
