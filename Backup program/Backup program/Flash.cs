using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_program
{
    class Flash:Storage
    {
        public double UsbSpeed { get; set; }
        public double Memory { get; set; }
        
        public override void CopyMethod()
        {
            double time = 780 / UsbSpeed;//780 mb ucun lazim olan saniye usb 3.0
            double allMemory = 565 * 1024;//Umumi faylin olducu: 565 gb i mb a ceviririk.1 gb=1024mb
            int countFile = Convert.ToInt32(allMemory / 780);//780 mb olan faylin sayi
            double allMemoryRound = 780 * countFile;//Umumi faylin 780 mb lerden ibaret yuvarlaq yaddasi
            double memoryWithout780mb = allMemory - allMemoryRound;//565 gb faylin icerisinde  780 mb xaricinde qalan yaddas yeri
            int needCount = Convert.ToInt32(allMemoryRound / Memory);//Umumi ehtiyac olan say
            double needTime = countFile * time;//Umimi ehtiyac olan zaman
            Console.WriteLine($"Media count:{needCount + Convert.ToInt32(memoryWithout780mb / Memory)} ");
            if (needTime > 60)
            {
                Console.WriteLine($"Copy time:{Convert.ToInt32(needTime/60)} minute {Convert.ToInt32(needTime-(Convert.ToInt32(needTime/60)*60))} second ");
            }
            else Console.WriteLine($"Copy time:{needTime} second ");

        }
        public override void MediaSize()
        {
            Console.WriteLine($"Media Size: {Memory}");
        }
        public override double FreeMemory()
        {
            double freeMemory = 565 * 1024 - Memory;
            return freeMemory;
        }
        public override void PrintDeviceInfo()
        {
            base.PrintDeviceInfo();
            Console.WriteLine($"Usb speed: {UsbSpeed}");
            Console.WriteLine($"Memory: {Memory} MB");
        }
    }
}
