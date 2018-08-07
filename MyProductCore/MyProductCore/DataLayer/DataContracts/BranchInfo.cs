using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Core.DataLayer.DataContracts
{
    class BranchInfo
    {
        public BranchInfo()
        {
        }

        public String branch_code { get; set; }
        public String branch_desc { get; set; }
        public String branch_name { get; set; }
        public String area_code { get; set; }
        public String area_desc { get; set; }
        public String state { get; set; }
        public String business_unit_code { get; set; }
        public String business_unit_desc { get; set; }
        public String business_unit_group { get; set; }
    }
}
