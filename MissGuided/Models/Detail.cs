using System;
using System.Collections.Generic;
using System.Text;

namespace MissGuided.Models
{
    public class Detail
    {
        public int detailID { get; set; }
        public string detailTitle { get; set; }

        public Master detailMaster { get; set; }
    }
}
