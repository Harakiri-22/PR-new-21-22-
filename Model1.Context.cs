﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace basedata21
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB1Entities : DbContext
    {
        public DB1Entities()
            : base("name=DB1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Группа_основных_средств> Группа_основных_средств { get; set; }
        public virtual DbSet<МОЛ> МОЛ { get; set; }
        public virtual DbSet<Основные_средства> Основные_средства { get; set; }
        public virtual DbSet<Подразделение> Подразделение { get; set; }

        private static DB1Entities context;

        public static DB1Entities GetContext()
        {
            if (context == null)
            {
                context = new DB1Entities();
            }
            return context;
        }
    }
}
