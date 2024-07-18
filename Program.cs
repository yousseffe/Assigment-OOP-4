using Assigment_OOP_4.Interface;

namespace Assigment_OOP_4
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++) {
                Console.Write($"{series.Current}\t");
                series.getNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ISeries seriesByTwo = new SeriesByTwo();
            ISeries seriesByThree = new SeriesByThree();
            ISeries seriesByFour = new SeriesByFour();

            Print10NumbersFromSeries(seriesByFour);
        }
    }
}
