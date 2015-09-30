namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ABCDataModel : DbContext
    {
        public ABCDataModel()
            : base("name=ABCDataModel")
        {
        }

        public virtual DbSet<err_cat> err_cat { get; set; }
        public virtual DbSet<err_typ> err_typ { get; set; }
        public virtual DbSet<fldr> fldrs { get; set; }
        public virtual DbSet<inst> insts { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<job_det> job_det { get; set; }
        public virtual DbSet<job_typ> job_typ { get; set; }
        public virtual DbSet<parm_ctrl> parm_ctrl { get; set; }
        public virtual DbSet<run_err_typ_stats> run_err_typ_stats { get; set; }
        public virtual DbSet<run_job_det_stats> run_job_det_stats { get; set; }
        public virtual DbSet<run_job_stats> run_job_stats { get; set; }
        public virtual DbSet<run_parm_stats> run_parm_stats { get; set; }
        public virtual DbSet<run_src_stats> run_src_stats { get; set; }
        public virtual DbSet<run_tgt_stats> run_tgt_stats { get; set; }
        public virtual DbSet<src_inst> src_inst { get; set; }
        public virtual DbSet<src_inst_xref> src_inst_xref { get; set; }
        public virtual DbSet<syst> systs { get; set; }
        public virtual DbSet<tgt_inst> tgt_inst { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<err_cat>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<err_cat>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<err_cat>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<err_cat>()
                .Property(e => e.err_cat_nm)
                .IsUnicode(false);

            modelBuilder.Entity<err_cat>()
                .Property(e => e.err_cat_desc)
                .IsUnicode(false);

            modelBuilder.Entity<err_cat>()
                .HasMany(e => e.err_typ)
                .WithRequired(e => e.err_cat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<err_typ>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<err_typ>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<err_typ>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<err_typ>()
                .Property(e => e.err_typ_cd)
                .IsUnicode(false);

            modelBuilder.Entity<err_typ>()
                .Property(e => e.err_typ_desc)
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .Property(e => e.fldr_nm)
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .Property(e => e.fldr_desc)
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .Property(e => e.repstry_nm)
                .IsUnicode(false);

            modelBuilder.Entity<fldr>()
                .HasMany(e => e.jobs)
                .WithRequired(e => e.fldr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_nm)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_desc)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_typ)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_file_locn)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_file_nm)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_server_locn)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_db_nm)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_tble_nm)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .Property(e => e.inst_tble_locn)
                .IsUnicode(false);

            modelBuilder.Entity<inst>()
                .HasMany(e => e.tgt_inst)
                .WithRequired(e => e.inst)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inst>()
                .HasMany(e => e.src_inst_xref)
                .WithRequired(e => e.inst)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_nm)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_desc)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_schd_nm)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .HasMany(e => e.job_det)
                .WithRequired(e => e.job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job>()
                .HasMany(e => e.run_job_stats)
                .WithRequired(e => e.job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job_det>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<job_det>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<job_det>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<job_det>()
                .Property(e => e.job_det_nm)
                .IsUnicode(false);

            modelBuilder.Entity<job_det>()
                .Property(e => e.job_det_desc)
                .IsUnicode(false);

            modelBuilder.Entity<job_det>()
                .Property(e => e.job_det_map_nm)
                .IsUnicode(false);

            modelBuilder.Entity<job_det>()
                .HasMany(e => e.run_job_det_stats)
                .WithRequired(e => e.job_det)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job_det>()
                .HasMany(e => e.tgt_inst)
                .WithRequired(e => e.job_det)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job_det>()
                .HasMany(e => e.src_inst)
                .WithRequired(e => e.job_det)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job_typ>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<job_typ>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<job_typ>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<job_typ>()
                .Property(e => e.job_typ_nm)
                .IsUnicode(false);

            modelBuilder.Entity<job_typ>()
                .Property(e => e.job_typ_desc)
                .IsUnicode(false);

            modelBuilder.Entity<job_typ>()
                .HasMany(e => e.jobs)
                .WithRequired(e => e.job_typ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.parm_nm)
                .IsUnicode(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.parm_desc)
                .IsUnicode(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.static_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<parm_ctrl>()
                .Property(e => e.parm_lst_run_val)
                .IsUnicode(false);

            modelBuilder.Entity<run_err_typ_stats>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_det_stats>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_det_stats>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_det_stats>()
                .Property(e => e.run_tot_exec_tm)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_det_stats>()
                .Property(e => e.run_status_cd)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_det_stats>()
                .HasMany(e => e.run_tgt_stats)
                .WithRequired(e => e.run_job_det_stats)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<run_job_stats>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_stats>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_stats>()
                .Property(e => e.run_tot_exec_tm)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_stats>()
                .Property(e => e.run_status_cd)
                .IsUnicode(false);

            modelBuilder.Entity<run_job_stats>()
                .HasMany(e => e.run_job_det_stats)
                .WithRequired(e => e.run_job_stats)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<run_parm_stats>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_parm_stats>()
                .Property(e => e.run_parm_val)
                .IsUnicode(false);

            modelBuilder.Entity<run_src_stats>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_tgt_stats>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<run_tgt_stats>()
                .Property(e => e.prcs_typ)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<src_inst>()
                .Property(e => e.src_inst_nm)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst>()
                .Property(e => e.src_inst_desc)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst>()
                .HasMany(e => e.src_inst_xref)
                .WithRequired(e => e.src_inst)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<src_inst_xref>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst_xref>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<src_inst_xref>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.syst_nm)
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.syst_desc)
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.db_nm)
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .Property(e => e.server_nm)
                .IsUnicode(false);

            modelBuilder.Entity<syst>()
                .HasMany(e => e.insts)
                .WithRequired(e => e.syst)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tgt_inst>()
                .Property(e => e.aud_ins_id)
                .IsUnicode(false);

            modelBuilder.Entity<tgt_inst>()
                .Property(e => e.aud_upd_id)
                .IsUnicode(false);

            modelBuilder.Entity<tgt_inst>()
                .Property(e => e.actv_ind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tgt_inst>()
                .Property(e => e.tgt_inst_nm)
                .IsUnicode(false);

            modelBuilder.Entity<tgt_inst>()
                .Property(e => e.tgt_inst_desc)
                .IsUnicode(false);

            modelBuilder.Entity<tgt_inst>()
                .HasMany(e => e.run_tgt_stats)
                .WithRequired(e => e.tgt_inst)
                .WillCascadeOnDelete(false);
        }
    }
}
