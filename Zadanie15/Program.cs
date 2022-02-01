using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    public interface ISeries
    {
        void SetStart(int х); 
        int GetNext(); 
        void Reset(); 
    }
    public class Class : ISeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия:");
            ArithProgression.Funk(3, 5, 8);
            Console.WriteLine("Геометрическая прогрессия:");
            GeomProgression.Funk(2, 9);
            Console.ReadLine();
        }

        int ISeries.GetNext()
        {
            throw new NotImplementedException();
        }

        void ISeries.Reset()
        {
            throw new NotImplementedException();
        }

        void ISeries.SetStart(int х)
        {
            throw new NotImplementedException();
        }

        
    }
    class ArithProgression : ISeries 
    {

        public static void Funk(double firstElem, double stepOfElem, int endElem)
        {
            double[] ArefmProgrArray = new double[endElem];
            ArefmProgrArray[0] = firstElem;
            double ArefmSumElem = 0;

            for (int i = 1; i < endElem; i++)
            {
                ArefmProgrArray[i] = ArefmProgrArray[0] + (i - 1) * stepOfElem;
                Console.Write(ArefmProgrArray[i] + " ");
                ArefmSumElem += ArefmProgrArray[i];
            }
            Console.WriteLine("\nХарактеристики: \nпервый член = {0} \nшаг = {1} \nномер последнего члена = {2}", firstElem, stepOfElem, endElem);
            Console.WriteLine("Sum= " + (ArefmSumElem + firstElem));
        }

        int ISeries.GetNext()
        {
            throw new NotImplementedException();
        }

        void ISeries.Reset()
        {
            throw new NotImplementedException();
        }

        void ISeries.SetStart(int х)
        {
            throw new NotImplementedException();
        }
    }
    public class GeomProgression : ISeries 
    {

        public static void Funk(double firstElem, int endElem)
        {
            double[] GeomProgrArray = new double[endElem];
            GeomProgrArray[0] = firstElem;
            double GeomSumElem = 0;

            for (int i = 1; i < endElem; i++)
            {
                GeomProgrArray[i] = Math.Pow(GeomProgrArray[0], i);
                Console.Write(GeomProgrArray[i] + " ");
                GeomSumElem += GeomProgrArray[i];
            }
            Console.WriteLine("\nХарактеристики: \nпервый член = {0}\nномер последнего члена = {1}", firstElem, endElem);
            Console.WriteLine("Sum= " + (GeomSumElem + firstElem));
        }

        public int GetNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetStart(int х)
        {
            throw new NotImplementedException();
        }
    }

}