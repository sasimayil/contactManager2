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
    
    public partial class err_typ
    {
        public err_typ()
        {
            this.run_err_typ_stats = new HashSet<run_err_typ_stats>();
        }
    
        public int err_typ_skey { get; set; }
        public string aud_ins_id { get; set; }
        public string aud_upd_id { get; set; }
        public System.DateTime aud_ins_tmstp { get; set; }
        public System.DateTime aud_upd_tmstp { get; set; }
        public string actv_ind { get; set; }
        public string err_typ_cd { get; set; }
        public string err_typ_desc { get; set; }
        public int err_cat_skey { get; set; }
    
        public virtual err_cat err_cat { get; set; }
        public virtual ICollection<run_err_typ_stats> run_err_typ_stats { get; set; }
    }
}