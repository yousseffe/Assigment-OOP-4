using Assigment_OOP_4.Interface;
using Assigment_OOP_4.Interface03;

namespace Assigment_OOP_4
{
    internal class Program
    {
        /*public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++) {
                Console.Write($"{series.Current}\t");
                series.getNext();
            }
            series.Reset();
            Console.WriteLine();
        }*/
        static void Main(string[] args)
        {
            #region Example 2
            /*ISeries seriesByTwo = new SeriesByTwo();
                ISeries seriesByThree = new SeriesByThree();
                ISeries seriesByFour = new SeriesByFour();

                Print10NumbersFromSeries(seriesByFour);*/
            #endregion

            #region Implicity vs Explicity
            /*Airplane airplane = new Airplane();
                airplane.Forward();

                IMovable airplane2 = new Airplane();
                IFlyable airplane3 = new Airplane();

                airplane3.Forward();
                airplane2.Forward();*/ 
            #endregion
        
            
        }
    }
}
