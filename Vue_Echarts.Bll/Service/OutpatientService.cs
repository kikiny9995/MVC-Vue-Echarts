using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vue_Echarts.Dal;
using Vue_Echarts.Mdl;
using Vue_Echarts.Mdl.Model;
using static Vue_Echarts.Mdl.Enum;

namespace Vue_Echarts.Bll.Service
{
    public class OutpatientService
    {
        HealthEntities _db;

        public OutpatientChartStruct GetOutpatients()
        {
            using (var _db = new HealthEntities())
            {
                var entities = _db.Outpatients.GroupBy(r => r.VisitDate);

                //取日期(同天合併)、中醫同一天總數、西醫同一天總數

                var model = new OutpatientChartStruct();
                model.Dates = new List<string>();
                model.ChineseMedicineCount = new List<int>();
                model.WesternMedicineCount = new List<int>();
                var outpatients = _db.Outpatients;
                if (entities.Any() == true)
                {
                    foreach (var item in entities)
                    {
                        var date = item.Key;
                        var chineseMedicineCount = outpatients.Where(r => r.OutpatientType == EOutpatient.中醫 && r.VisitDate == date).Count();
                        var westernMedicineCount = outpatients.Where(r => r.OutpatientType == EOutpatient.西醫 && r.VisitDate == date).Count();
                        model.Dates.Add(date.ToString("yyyy-MM-dd"));
                        model.ChineseMedicineCount.Add(chineseMedicineCount);
                        model.WesternMedicineCount.Add(westernMedicineCount);
                    }
                }


                return model;
            }
        }
    }
}
