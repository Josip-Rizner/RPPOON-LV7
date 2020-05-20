using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{


    /*          3. zadatak
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad != this.previousCPULoad)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float CurrentAvailableRAM = this.AvailableRAM;
            if(CurrentAvailableRAM != this.previousRAMAvailable)
            {
                this.Notify();
            }
            this.previousRAMAvailable = CurrentAvailableRAM;
            return CurrentAvailableRAM;
        }
    }*/




    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (Math.Abs(previousCPULoad - currentLoad) >= previousCPULoad * 0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float CurrentAvailableRAM = this.AvailableRAM;
            if (Math.Abs(previousRAMAvailable - CurrentAvailableRAM) >= previousRAMAvailable * 0.1)
            {
                this.Notify();
            }
            this.previousRAMAvailable = CurrentAvailableRAM;
            return CurrentAvailableRAM;
        }
    }
}
