using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Wt
    {
        private string date;
        private int minTemp;
        private int maxTemp;
        private string dayday;

        public string Date { get => date; set => date = value; }
        public int MinTemp { get => minTemp; set => minTemp = value; }
        public int MaxTemp { get => maxTemp; set => maxTemp = value; }
        public string Dayday { get => dayday; set => dayday = value; }

        public Wt(string date, int minTemp, int maxTemp, string dayday)
        {
            this.date = date;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.dayday = dayday;
        }



    }
}
