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
    
    public partial class run_parm_stats
    {
        public int run_parm_stats_skey { get; set; }
        public string aud_ins_id { get; set; }
        public Nullable<System.DateTime> aud_ins_tmstp { get; set; }
        public Nullable<int> parm_ctrl_skey { get; set; }
        public Nullable<int> run_job_stats_skey { get; set; }
        public Nullable<int> run_job_det_stats_skey { get; set; }
        public string run_parm_val { get; set; }
    
        public virtual parm_ctrl parm_ctrl { get; set; }
        public virtual run_job_det_stats run_job_det_stats { get; set; }
        public virtual run_job_stats run_job_stats { get; set; }
    }
}
