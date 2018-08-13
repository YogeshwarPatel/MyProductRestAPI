using System;
using System.Collections.Generic;
using System.Text;

namespace MyProductCore.DataLayer.DataContracts
{
    class BranchInfo //Not Used for now as at 10 Aug 2018
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
