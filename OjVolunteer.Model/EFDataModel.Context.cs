﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace OjVolunteer.Model
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class OjVolunteerEntities : DbContext
{
    public OjVolunteerEntities()
        : base("name=OjVolunteerEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Activity> Activity { get; set; }

    public virtual DbSet<ActivityDetail> ActivityDetail { get; set; }

    public virtual DbSet<ActivityType> ActivityType { get; set; }

    public virtual DbSet<Department> Department { get; set; }

    public virtual DbSet<Favors> Favors { get; set; }

    public virtual DbSet<Integrals> Integrals { get; set; }

    public virtual DbSet<Major> Major { get; set; }

    public virtual DbSet<OrganizeInfo> OrganizeInfo { get; set; }

    public virtual DbSet<Political> Political { get; set; }

    public virtual DbSet<Talks> Talks { get; set; }

    public virtual DbSet<UserDuration> UserDuration { get; set; }

    public virtual DbSet<UserEnroll> UserEnroll { get; set; }

    public virtual DbSet<UserInfo> UserInfo { get; set; }

    public virtual DbSet<Badge> Badge { get; set; }

    public virtual DbSet<UserBadge> UserBadge { get; set; }

    public virtual DbSet<v_User_ActDetail> v_User_ActDetail { get; set; }

    public virtual DbSet<UserIDcard> UserIDcard { get; set; }

}

}

