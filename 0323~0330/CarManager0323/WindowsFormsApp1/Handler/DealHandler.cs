using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Handler
{
    class DealHandler
    {
        List<Deal> dealList = new List<Deal>();
        public DealHandler()
        {
            dealList.Add(new Deal("0000", null, null, null));
        }

        public List<Deal> getDealList()
        {
            return dealList;
        }
        public void dealListClear()
        {
            dealList[0].Car = null;
            dealList[0].Customer = null;
            dealList[0].Seller = null;
            dealList[0].Date = "0000";
        }
        }

    }

