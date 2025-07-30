namespace AssignmentAdvanced02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] arr1 = { 11, 5, 3 };
            int[] query = { 1, 5, 13 };
            foreach (int x in query)
                Console.WriteLine($"x={x} → {arr1.Count(num => num > x)}");
            
            #endregion
        }
    }
}
