﻿using Microsoft.EntityFrameworkCore;
using SplitwiseAbp.BalDetails;
using SplitwiseAbp.Expenses;
using SplitwiseAbp.FriendShips;
using SplitwiseAbp.Groups;
using SplitwiseAbp.Participants;
using System.Reflection.Emit;
using SplitwiseAbp.Transactions;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace SplitwiseAbp.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class SplitwiseAbpDbContext :
    AbpDbContext<SplitwiseAbpDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
    public DbSet<Group> Groups { get; set; }

    public DbSet<UserGroup> UserGroups { get; set; }
    public DbSet<Friends>  friends { get; set; }

    public DbSet<BalDetail> balDetails { get; set; }

    public DbSet<Participant> Participants { get; set; }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public SplitwiseAbpDbContext(DbContextOptions<SplitwiseAbpDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Group>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "Groups", SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            //auto configure for the base class props
            //...
        });

        builder.Entity<UserGroup>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "UserGroup", SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId);
        });

        builder.Entity<Friends>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "Friends", SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();

        });

        builder.Entity<BalDetail>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "BalanceTable", SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasOne(p => p.user).WithMany().HasForeignKey(p => p.userId);

        });

        builder.Entity<Participant>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "Participants", SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasKey(p => p.Id);
        });

        builder.Entity<Expense>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "Expenses", SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasOne(e => e.Group).WithMany().HasForeignKey(e => e.GroupId);
        });
        builder.Entity<Transaction>(b =>
        {
            b.ToTable(SplitwiseAbpConsts.DbTablePrefix + "Transactions" , SplitwiseAbpConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasOne(e => e.Expense)
            .WithMany()
            .HasForeignKey(e => e.expenseId);

        });

      

    }

}
