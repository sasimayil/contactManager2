//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class run_job_det_stats
    {
        public run_job_det_stats()
        {
            this.run_err_typ_stats = new HashSet<run_err_typ_stats>();
            this.run_tgt_stats = new HashSet<run_tgt_stats>();
            this.run_parm_stats = new HashSet<run_parm_stats>();
            this.run_src_stats = new HashSet<run_src_stats>();
        }
    
        public int run_job_det_stats_skey { get; set; }
        public string aud_ins_id { get; set; }
        public string aud_upd_id { get; set; }
        public Nullable<System.DateTime> aud_upd_tmstp { get; set; }
        public System.DateTime aud_ins_tmstp { get; set; }
        public int job_det_skey { get; set; }
        public int run_job_stats_skey { get; set; }
        public Nullable<System.DateTime> run_strt_tm { get; set; }
        public Nullable<System.DateTime> run_end_tm { get; set; }
        public string run_tot_exec_tm { get; set; }
        public Nullable<int> run_recs_read { get; set; }
        public Nullable<int> run_recs_ins { get; set; }
        public Nullable<int> run_recs_upd { get; set; }
        public Nullable<int> run_err_cnt { get; set; }
        public string run_status_cd { get; set; }
    
        public virtual job_det job_det { get; set; }
        public virtual ICollection<run_err_typ_stats> run_err_typ_stats { get; set; }
        public virtual run_job_stats run_job_stats { get; set; }
        public virtual ICollection<run_tgt_stats> run_tgt_stats { get; set; }
        public virtual ICollection<run_parm_stats> run_parm_stats { get; set; }
        public virtual ICollection<run_src_stats> run_src_stats { get; set; }
    }
}
