using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceRegister
{
    internal class Laptop : Device
    {
        // --- fields ---------------------------------------------------------

        private readonly double mScreenSize;
        private readonly double mWeight;

        // --- properties -----------------------------------------------------

        public double ScreenSize => mScreenSize;
        public double Weight => mWeight;

        // --- constructors ---------------------------------------------------

        public Laptop(int pProductionYear, double pScreenSize, double pWeight) : base(pProductionYear)
        {
            mScreenSize = pScreenSize;
            mWeight = pWeight;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            return
                base.ToString() + RegisterHelper.SetNewLine() +
                "Screen size: " + mScreenSize + " inch" + RegisterHelper.SetNewLine() +
                "Weight: " + mWeight + " kg" + RegisterHelper.SetNewLine();
        }
    }
}