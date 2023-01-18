using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_test_ui.Models
{
    public class ManualPump
    {
        public bool Enabled { get; private set; }

        public Direction Direction { get; set; }


        public void Start()
        {
            Enabled = true;
            Console.WriteLine($"Manual Pump started {Direction}");
        }

        public void Stop()
        {
            Enabled = false;
            Console.WriteLine("Manual Pump stopped");
        }
    }
}
