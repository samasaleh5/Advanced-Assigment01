namespace Advanced_Assigment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            int[] Array1= { 5, 1, 4, 2, 8 };
            BubbleSort<int>.OptimizedBubbleSort(Array1);
            foreach (int i in Array1) 
            { 
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
