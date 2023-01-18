using System;

namespace wpf_test_ui.Models
{
    public class AutoPump
    {
        public bool Enabled { get; private set; }

        public Direction Direction { get; set; }


        public void Start()
        {
            Enabled = true;
            Console.WriteLine($"Auto Pump started {Direction}");
        }

        public void Stop()
        {
            Enabled = false;
            Console.WriteLine("Auto Pump stopped");
        }
    }
}
