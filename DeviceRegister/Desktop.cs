using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceRegister
{
    internal class Desktop : Device
    {
        // --- fields ---------------------------------------------------------

        private readonly double mHeight;
        private readonly double mWidth;
        private readonly double mDepth;

        // --- properties -----------------------------------------------------

        public double Height => mHeight;
        public double Width => mWidth;
        public double Depth => mDepth;

        // --- constructors ---------------------------------------------------

        public Desktop(int pProductionYear, double pHeigth, double pWidth, double pDepth) : base(pProductionYear)
        {
            mHeight = pHeigth;
            mWidth = pWidth;
            mDepth = pDepth;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            return
                base.ToString() + RegisterHelper.SetNewLine() +
                "Height: " + mHeight + SetMeasureDimension() + RegisterHelper.SetNewLine() +
                "Width: " + mWidth + SetMeasureDimension() + RegisterHelper.SetNewLine() +
                "Depth: " + mDepth + SetMeasureDimension() + RegisterHelper.SetNewLine();
        }

        // --- private methods ------------------------------------------------

        private string SetMeasureDimension()
        {
            return " cm";
        }
    }
}