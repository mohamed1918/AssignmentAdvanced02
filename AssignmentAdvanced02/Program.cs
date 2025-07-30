using System.Collections;

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
            //string input = "[()]{}";
            ////string input = "[()]{";
            //Stack<char> stack1 = new Stack<char>();
            //Dictionary<char, char> pairs = new Dictionary<char, char>
            //{
            //    { ')', '(' }, { ']', '[' }, { '}', '{' }
            //};
            //bool balanced = true;
            //foreach (char c in input)
            //{
            //    if ("([{".Contains(c)) stack1.Push(c);
            //    else if (")]}".Contains(c))
            //    {
            //        if (stack1.Count == 0 || stack1.Pop() != pairs[c])
            //        {
            //            balanced = false;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(balanced && stack1.Count == 0 ? "Balanced" : "Not Balanced");
            #endregion

            #region Q5
            //int[] arr1 = { 1, 2, 2, 3, 4, 4, 5 };
            //Console.WriteLine(string.Join(", ", arr1.Distinct()));
            #endregion

            #region Q6
            //ArrayList arr1 = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            //for (int i = arr1.Count - 1; i >= 0; i--)
            //    if ((int)arr1[i] % 2 != 0) arr1.RemoveAt(i);
            //Console.WriteLine(string.Join(", ", arr1.ToArray()));
            #endregion

            #region Q7
            //Queue queue1 = new Queue();
            //queue1.Enqueue(1);
            //queue1.Enqueue("Apple");
            //queue1.Enqueue(5.28);
            //foreach (var item in queue1)
            //    Console.WriteLine(item);
            #endregion

            #region Q8
            //Stack<int> stack1 = new Stack<int>();
            //for (int i = 1; i <= 10; i++) stack1.Push(i);
            //int target = 11;
            //int count = 0;
            //bool found = false;
            //foreach (var item in stack1)
            //{
            //    count++;
            //    if (item == target)
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(found
            //    ? $"Target {target} was found successfully and the count = {count}"
            //    : $"Target {target} was not found");
            #endregion

            #region Q9
            int[] arr1 = { 1, 2, 3, 4, 4 };
            int[] arr2 = { 10, 4, 4 };
            List<int> result = new List<int>();
            var dict = arr1.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            foreach (int num in arr2)
            {
                if (dict.ContainsKey(num) && dict[num] > 0)
                {
                    result.Add(num);
                    dict[num]--;
                }
            }
            Console.WriteLine("[" + string.Join(", ", result) + "]");
            #endregion
        }
    }
}
