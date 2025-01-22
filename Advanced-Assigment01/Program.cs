namespace Advanced_Assigment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //int[] Array1= { 5, 1, 4, 2, 8 };
            //BubbleSort<int>.OptimizedBubbleSort(Array1);
            //foreach (int i in Array1) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Question2

            Range<int> IntegerRange = new Range<int>(50, 5);

            Console.WriteLine(IntegerRange);

            Console.WriteLine("Is 30 in The Range? "+IntegerRange.IsInRange(30));
            Console.WriteLine("Is 21 in The Range? " + IntegerRange.IsInRange(21));
            Console.WriteLine("Is 51 in The Range? " + IntegerRange.IsInRange(51));

            Console.WriteLine("Range Length: " + IntegerRange.length());


            #endregion
        }
    }
}
