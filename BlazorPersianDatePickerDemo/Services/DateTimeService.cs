using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersianDatePickerDemo.Services
{
    public class DateTimeService
    {
        public PersianCalendar _pc { get; set; }

        public DateTimeService()
        {
            _pc = new PersianCalendar();
        }

        public DateTime GetPersianDateTime(DateTime dt)
        {
            var year = _pc.GetYear(dt);
            var month = _pc.GetMonth(dt);//1-12
            var day = _pc.GetDayOfMonth(dt);

            return new DateTime(year, month, day);
        }
        public DateTime GetDateTime(DateTime persianDt)
        {
            return _pc.ToDateTime(persianDt.Year, persianDt.Month, persianDt.Day, persianDt.Hour, persianDt.Minute, persianDt.Second, persianDt.Millisecond);
        }
    }
}
