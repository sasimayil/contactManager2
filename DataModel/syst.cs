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
    
    public partial class syst
    {
        public syst()
        {
            this.insts = new HashSet<inst>();
        }
    
        public int syst_skey { get; set; }
        public string aud_ins_id { get; set; }
        public string aud_upd_id { get; set; }
        public System.DateTime aud_ins_tmstp { get; set; }
        public System.DateTime aud_upd_tmstp { get; set; }
        public string actv_ind { get; set; }
        public string syst_nm { get; set; }
        public string syst_desc { get; set; }
        public string db_nm { get; set; }
        public string server_nm { get; set; }
    
        public virtual ICollection<inst> insts { get; set; }
    }
}
