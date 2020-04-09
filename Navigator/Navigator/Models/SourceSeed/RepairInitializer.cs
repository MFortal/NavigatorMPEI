using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Navigator.Models.DataModels;

namespace Navigator.Models.SourceSeed
{
    public class RepairInitializer
    {
        public static Repair[] Initialize()
        {
            return new Repair[]
            {
                new Repair{Id=1, Name=0},
                new Repair{Id=1, Name=1}
            };
        }
    }
}