using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
//using PLplot;
using System.Diagnostics;

namespace Main.yonor
{

    public sealed class StockManagement
    {
        private StockManagement()
        {

        }
        //Here we can lock it to be threat safe! to discuss with the team.
        private static StockManagement instance = null;
        public static StockManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StockManagement();
                }
                return instance;
            }
        }
        public int burgetStock { get; set; }
        public int steakStock { get; set; }
        public int pulletStock { get; set; }
        public int sodaStock { get; set; }
        public int waterStock { get; set; }
        public int colaStock { get; set; }

        public int remainingDishes()
        {
            return (burgetStock + steakStock + pulletStock + sodaStock + waterStock + colaStock);
        }


    }

}