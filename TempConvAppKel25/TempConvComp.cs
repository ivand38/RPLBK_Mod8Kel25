using System;

namespace TempConv

{

    public class TempConvComp

    {

        public TempConvComp()

        {

        }

        public double cToR(double c)

        {

            return (int)((c * 4 / 5.0) * 100) / 100.0 ;

        }

        public double cToF(double c)

        {

            return (int)((9 / 5.0 * c + 32) * 100) / 100.0;

        }

        public double cToK(double c)

        {

            return (int)((c + 273) * 100) / 100.0;

        }

        public double rToC(double r)

        {

            return (int)((5 / 4.0 * r) * 100) / 100.0;

        }

        public double rToF(double r)

        {

            return (int)((9 / 4.0 * r + 32) * 100) / 100.0;

        }

        public double rToK(double r)

        {

            return (int)((5 / 4.0 * r + 273) * 100) / 100.0;

        }

        public double fToC(double f)

        {

            return (int)((5 / 9.0 * (f - 32)) * 100) / 100.0;

        }

        public double fToR(double f)

        {

            return (int)((4 / 9.0 * (f - 32)) * 100) / 100.0;

        }

        public double fToK(double f)

        {

            return (int)((5 / 9.0 * (f - 32) + 273) * 100) / 100.0;

        }

        public double kToC(double k)

        {

            return (int)((k - 273) * 100) / 100.0;

        }

        public double kToR(double k)

        {

            return (int)((4 / 5.0 *(k -273)) * 100) / 100.0;

        }

        public double kToF(double k)

        {

            return (int)((9 / 5.0 * (k - 273) + 32) * 100) / 100.0;

        }

    }

}