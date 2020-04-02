using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CheckInfo
    {
        public DateTime Date { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Temperture { get; set; }
        public string IsSuspected { get; set; }
        public string Isconfirmed { get; set; }

        public CheckInfo(DateTime date, string province, string city, string temperture, string isSuspected, string isconfirmed)
        {
            Date = date;
            Province = province;
            City = city;
            Temperture = temperture;
            IsSuspected = isSuspected;
            Isconfirmed = isconfirmed;
        }
    }
}
