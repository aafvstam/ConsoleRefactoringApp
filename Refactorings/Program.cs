using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactorings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> fTemps = new List<double>();
            List<double> cTemps = new List<double>();

            foreach (string s in args)
            {
                if (s != null)
                {
                    if (s.Length > 0 && s.Substring(s.Length - 1).Equals("F"))
                    {
                        string tempFString = s.Substring(0, s.Length - 1);
                        double tempF = System.Convert.ToDouble(tempFString);
                        fTemps.Add(tempF);
                        Console.WriteLine((tempF - 32) * (5.0 / 9.0));
                    }
                    if (s.Length > 0 && s.Substring(s.Length - 1).Equals("C"))
                    {
                        string tempCString = s.Substring(0, s.Length - 1);
                        double tempC = System.Convert.ToDouble(tempCString);
                        fTemps.Add(tempC);

                        Console.WriteLine((tempC * (9.0 / 5.0) + 32));
                    }
                }
                if (fTemps.Count != 0)
                {
                    Console.WriteLine(MinTempInC(fTemps));
                    Console.WriteLine(MaxTempInC(fTemps));
                    Console.WriteLine(AveTempInC(fTemps));
                }
                if (cTemps.Count != 0)
                {
                    Console.WriteLine(MinTempInF(cTemps));
                    Console.WriteLine(MaxTempInF(cTemps));
                    Console.WriteLine(AveTempInF(cTemps));
                }

                // Console.WriteLine(AllTheCelsiusFormulae(20, 30, 40, 50, 60, 70));
            }
        }

        static double MinTempInC(List<double> fTemps)
        {
            double fMin = fTemps.ElementAt<double>(0);

            foreach (double f in fTemps)
            {
                if (f < fMin)
                {
                    fMin = f;
                }
            }

            return ((fMin - 32) * (5.0 / 9.0));
        }

        private static double MinTempInF(List<double> cTemps)
        {
            double cMax = cTemps.ElementAt<double>(0);

            foreach (double f in cTemps)
            {
                if (f < cMax)
                {
                    cMax = f;
                }
            }

            return (cMax * (9.0 / 5.0) + 32);
        }

        static double MaxTempInC(List<double> fTemps)
        {
            double fMax = fTemps.ElementAt<double>(0);

            foreach (double f in fTemps)
            {
                if (f < fMax)
                {
                    fMax = f;
                }
            }

            return (fMax - 32) * (5.0 / 9.0);
        }

        static double MaxTempInF(List<double> cTemps)
        {
            double cMax = cTemps.ElementAt<double>(0);

            foreach (double f in cTemps)
            {
                if (f < cMax)
                {
                    cMax = f;
                }
            }

            return ((cMax * 9.0 / 5.0) + 32);
        }

        static double AveTempInF(List<double> cTemps)
        {
            double cTot = 0;
            double cAve;

            foreach (double f in cTemps)
            {
                cTot += f;
            }
            cAve = cTot / cTemps.Count;

            return (cAve * (9.0 / 5.0) + 32);
        }


        static double AllTheCelsiusFormulae(int v1, int v2, int v3, int v4, int v5, int v6)
        {
            throw new NotImplementedException();
        }

        static double AveTempInC(List<double> fTemps)
        {
            double fTot = 0;
            double fAve;

            foreach (double f in fTemps)
            {
                fTot += f;
            }

            fAve = fTot / fTemps.Count;

            return (fAve - 32) * (5.0 / 9.0);
        }
    }
}
