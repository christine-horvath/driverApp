using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverApp
{
    public class Driver
    {
        public string name { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string miles { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public TimeSpan interval { get; set; }
        public double time { get; set; }
        public int totalMiles { get; set; }
        public double mph { get; set; }
        

    }
}
