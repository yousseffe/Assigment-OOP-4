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

            #region Shallow Copy VS Deep Copy
/*
            int[] Arr01 = { 1 , 2 , 3 };
            int[] Arr02 = { 4 , 5 , 6 };
            Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");
            #region Shallow copy
            *//*//shallow copy
                Arr02 = Arr01;
                // this object {1,2,3} has 2 refrences []
                // this object {4,5,6} unreachable object
                Console.WriteLine("After shallow copy");

                Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
                Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");

                Arr02[0] = 100;
                Console.WriteLine(Arr01[0]);*//*
            #endregion

            #region Deep copy
            *//*Arr02 = (int[])Arr01.Clone();

            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");

            Arr02[0] = 100;
            Console.WriteLine(Arr01[0]);
            Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");*//*
            #endregion
*/
            #endregion
        
            
        }
    }
}
