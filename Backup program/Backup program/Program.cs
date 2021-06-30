using System;

namespace Backup_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash
            {
                Model = "Sandisk",
                MediaName = "Flash",
                Memory = 1024,
                UsbSpeed = 640
                
            };
            Dvd dvd = new Dvd
            {
                Model = "Panasonic dvd",
                MediaName = "Dvd",
                Memory = 1024 * 1024,
                ReadSpeed = 1.3,              
                WriteSpeed = 300
            };
            Hdd hdd = new Hdd
            {
                Model = "Panasonic dvd",
                MediaName = "Dvd",
                Memory = 1024 * 10,
                UsbSpeed=200
            };
            flash.CopyMethod();
            dvd.CopyMethod();
            hdd.CopyMethod();
           // flash.PrintDeviceInfo();
        }
       
       
     
       
    }
}
