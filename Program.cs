namespace Assignment2._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetQuadrant();
        }

        public static void GetQuadrant()
        {
            Console.Write("Input the value for X coordinate :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            int y = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[] { x, y };
            string result = FindQuadrant(input);
            Console.WriteLine(result.Replace("{x}", x.ToString()).Replace("{y}", y.ToString()));
        }

        public static string FindQuadrant(int[] input)
        {
            switch(input)
            {
                case int[] ia when ia[0] > 0 && ia[1] > 0 :
                    return "The coordinate point ({x},{y}) lies in the First quadrant.";
                case int[] ia when ia[0] < 0 && ia[1] > 0 :
                    return "The coordinate point ({x},{y}) lies in the Second quadrant.";
                case int[] ia when ia[0] < 0 && ia[1] < 0:
                    return "The coordinate point ({x},{y}) lies in the Third quadrant.";
                case int[] ia when ia[0] > 0 && ia[1] < 0:
                    return "The coordinate point ({x},{y}) lies in the Fourth quadrant.";
                case int[] ia when ia[0] == 0 && ia[1] != 0:
                    return "The coordinate point ({x},{y}) lies on the Y axis.";
                case int[] ia when ia[1] == 0 && ia[0] != 0:
                    return "The coordinate point ({x},{y}) lies on the X axis.";
                case int[] ia when ia[0] == 0 && ia[1] == 0:
                    return "The coordinate point ({x},{y}) is at the Origin.";
                default:
                    return "Not a valid input";
            }
        }
    }
}
