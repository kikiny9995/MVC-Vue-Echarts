using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue_Echarts.Mdl.Model
{
    public struct OutpatientChartStruct
    {
        /// <summary>
        /// 日期
        /// </summary>
        public List<string> Dates { get; set; }

        /// <summary>
        /// 中醫數量
        /// </summary>
        public List<int> ChineseMedicineCount { get; set; }

        /// <summary>
        /// 西醫數量
        /// </summary>
        public List<int> WesternMedicineCount { get; set; }
    }
}
