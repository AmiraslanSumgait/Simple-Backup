using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_program
{
   abstract class Storage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }
        public virtual void PrintDeviceInfo()
        {
            Console.WriteLine($"Media name: {MediaName}");
            Console.WriteLine($"Model: {Model}");
        }
        public abstract void CopyMethod();
        public abstract double FreeMemory();
        public abstract void MediaSize();
        
       
       
    }
}
