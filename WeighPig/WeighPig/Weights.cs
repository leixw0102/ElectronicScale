using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeighPig
{
    class Weights
    {
        public int id { get; set; }
        public int sn { get; set; }
        public string create_time { get; set; }
        public string weight { get; set; }
        public string level { get; set; }
        public string remarks { get; set; }
        public string type { get; set; }
        public int is_upload { get; set; }
        public int life_cycle { get; set; }
        public int is_handwrite { get; set; }
    }
}
