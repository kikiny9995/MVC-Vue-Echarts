using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vue_Echarts.Mdl.Enum;

namespace Vue_Echarts.Mdl.Model
{
    /// <summary>
    /// 門診
    /// </summary>
    public struct OutpatientStruct
    {

        /// <summary>
        /// 就診日期
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 疾病分類碼
        /// </summary>
        public string DiseaseCode { get; set; }


        /// <summary>
        /// 疾病分類碼
        /// </summary>
        public string DiseaseName { get; set; }


        /// <summary>
        /// 門診代號
        /// </summary>
        public EOutpatient OutpatientType { get; set; }
    }
}
