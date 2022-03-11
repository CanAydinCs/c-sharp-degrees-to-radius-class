using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreesToRadius
{
    public class MathPlus
    {
        private const double pi = 3.1415926535897932384626433832795;

        public double Pi() => pi;

        public double Cos(double degre) => Math.Round(Math.Cos(degre * pi / 180), 5);

        public double Sin(double degre) => Math.Round(Math.Sin(degre * pi / 180), 5);

        public double Tan(double degre) => Math.Round(Math.Tan(degre * pi / 180), 2);

        public double Cot(double degre) => (1 / Tan(degre));

        public double Sec(double degre) => (1 / Cos(degre));

        public double Cosec(double degre) => (1 / Sin(degre));

        public double ArcSin(double length) => DegreToRadius(Math.Asin(length));

        public double ArcCos(double length) => DegreToRadius(Math.Acos(length));

        public double ArcTan(double length) => DegreToRadius(Math.Atan(length));

        public double ArcCot(double length) => (1 / ArcTan(length));

        public double ArcSec(double length) => (1 / ArcCos(length));

        public double ArcCosec(double length) => (1 / ArcSin(length));

        public double DegreToRadius(double degre) => (degre * pi / 180);

        public double RadiusToDegre(double radius) => (radius * 180 / pi);

        public double DegreToMinute(double degre) => (degre * 60);

        public double MinuteToSecond(double minute) => (minute * 60);

        public double SecondToMinute(double second) => (second / 60);

        public double MinuteToDegre(double minute) => (minute / 60);

        public override int GetHashCode() => 0;
    }
}
