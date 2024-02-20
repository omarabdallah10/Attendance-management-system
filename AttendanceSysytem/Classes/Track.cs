using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSysytem.Classes
{
    public class Track
    {
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public List<string> Teachers { get; set;}
        public List<string> Students { get; set; }

    }
}
