using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceRegister
{
    internal abstract class Device
    {
        // --- fields ---------------------------------------------------------

        private readonly int mProductionYear;

        private int mCapacity;
        private string mCPUType;

        // --- properties -----------------------------------------------------

        public int ProductionYear => mProductionYear;

        public int Capacity { get => mCapacity; set => mCapacity = value; }
        public string CPUType { get => mCPUType; set => mCPUType = value; }

        // --- constructors ---------------------------------------------------

        public Device(int pProductionYear)
        {
            mProductionYear = pProductionYear;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            return
                "Type of device: " + GetType().Name.ToLower() + RegisterHelper.SetNewLine() +
                "Year of production: " + mProductionYear + RegisterHelper.SetNewLine() +
                "Capacity: " + mCapacity + " GB" + RegisterHelper.SetNewLine() +
                "CPU type: " + mCPUType;
        }
    }
}