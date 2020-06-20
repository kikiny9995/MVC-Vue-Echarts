using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue_Echarts.Mdl
{
    public struct ModifyResult
    {
        public bool IsSuccess { get; set; }

        public string SuccessMessage { get; set; }

        public string ExMessage { get; set; }

        public string ObjectException { get; set; }
    }
}
