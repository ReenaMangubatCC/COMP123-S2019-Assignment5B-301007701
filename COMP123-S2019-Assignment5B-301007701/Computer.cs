using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2019_Assignment5B_301007701
{
    enum ComputerField
    {
        PRODUCT_ID,
        COST,
        MANUFACTURER,
        MODEL,
        RAM_TYPE,
        RAM_SIZE,
        LCD_TYPE,
        SCREEN_SIZE,
        RESOLUTION,
        CPU_CLASS,
        CPU_BRAND,
        CPU_TYPE,
        CPU_SPEED,
        CPU_NUMBER,
        CONDITION,
        OS,
        PLATFORM,
        HDD_SIZE,
        HDD_SPEED,
        GPU_TYPE,
        OPTICAL_DRIVE,
        WEBCAM
        
    }
    public class Computer
    {
        public int ProductID { get; set; }
        public decimal Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RAMType { get; set; }
        public string Memory { get; set; }
        public string LCDType { get; set; }
        public string ScreenSize { get; set; }
        public string Resolution { get; set; }
        public string CPUClass { get; set; }
        public string CPUBrand { get; set; }
        public string CPUType { get; set; }
        public string CPUSpeed { get; set; }
        public string CPUNumber { get; set; }
        public string Condition { get; set; }
        public string OS { get; set; }
        public string Platform { get; set; }
        public string HDDSize { get; set; }
        public string HDDSpeed { get; set; }
        public string GPUType { get; set; }
        public string OpticalDrive { get; set; }
        public string WebCam { get; set; }
       

    }
}
