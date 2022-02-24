using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("DriveAbstract method motorcycle");    
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();    
        }
    }
}
