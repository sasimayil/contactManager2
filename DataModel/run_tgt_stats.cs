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
    
    public partial class run_tgt_stats
    {
        public int run_tgt_stats_skey { get; set; }
        public string aud_ins_id { get; set; }
        public System.DateTime aud_ins_tmstp { get; set; }
        public int tgt_inst_skey { get; set; }
        public int run_job_det_stats_skey { get; set; }
        public Nullable<int> recs_prcs { get; set; }
        public string prcs_typ { get; set; }
    
        public virtual run_job_det_stats run_job_det_stats { get; set; }
        public virtual tgt_inst tgt_inst { get; set; }
    }
}
