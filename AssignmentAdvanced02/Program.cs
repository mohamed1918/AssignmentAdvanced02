namespace AssignmentAdvanced02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] arr1 = { 11, 5, 3 };
            //int[] query = { 1, 5, 13 };
            //foreach (int x in query)
            //    Console.WriteLine($"x={x} → {arr1.Count(num => num > x)}");

            #endregion

            #region Q2
            //int[] arr1 = { 1, 3, 2, 3, 1 };
            ////int[] arr1 = { 1, 3, 2, 3, 3 };
            //bool isPalindrome = true;
            //for (int i = 0; i < arr1.Length / 2; i++)
            //{
            //    if (arr1[i] != arr1[arr1.Length - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isPalindrome ? "yes" : "no");
            #endregion

            #region Q3
            //Queue<int> q1 = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //Stack<int> s1 = new Stack<int>();
            //while (q1.Count > 0) s1.Push(q1.Dequeue());
            //while (s1.Count > 0) q1.Enqueue(s1.Pop());
            //Console.WriteLine(string.Join(", ", q1));
            #endregion

            #region Q4
            string input = "[()]{}";
            //string input = "[()]{";
            Stack<char> stack1 = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { ')', '(' }, { ']', '[' }, { '}', '{' }
            };
            bool balanced = true;
            foreach (char c in input)
            {
                if ("([{".Contains(c)) stack1.Push(c);
                else if (")]}".Contains(c))
                {
                    if (stack1.Count == 0 || stack1.Pop() != pairs[c])
                    {
                        balanced = false;
                        break;
                    }
                }
            }
            Console.WriteLine(balanced && stack1.Count == 0 ? "Balanced" : "Not Balanced");
            #endregion
        }
    }
}
