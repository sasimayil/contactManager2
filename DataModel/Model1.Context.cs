﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ABCEntities : DbContext
    {
        public ABCEntities()
            : base("name=ABCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<err_cat> err_cat { get; set; }
        public DbSet<err_typ> err_typ { get; set; }
        public DbSet<fldr> fldrs { get; set; }
        public DbSet<inst> insts { get; set; }
        public DbSet<job> jobs { get; set; }
        public DbSet<job_det> job_det { get; set; }
        public DbSet<job_typ> job_typ { get; set; }
        public DbSet<parm_ctrl> parm_ctrl { get; set; }
        public DbSet<run_err_typ_stats> run_err_typ_stats { get; set; }
        public DbSet<run_job_det_stats> run_job_det_stats { get; set; }
        public DbSet<run_job_stats> run_job_stats { get; set; }
        public DbSet<run_parm_stats> run_parm_stats { get; set; }
        public DbSet<run_src_stats> run_src_stats { get; set; }
        public DbSet<run_tgt_stats> run_tgt_stats { get; set; }
        public DbSet<src_inst> src_inst { get; set; }
        public DbSet<src_inst_xref> src_inst_xref { get; set; }
        public DbSet<syst> systs { get; set; }
        public DbSet<tgt_inst> tgt_inst { get; set; }
    }
}
