namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter length of the array");
            String len = Console.ReadLine();
            int length = Convert.ToInt32(len);
            int[] numbers = new int[length];

            Console.WriteLine("Enter the " + length + " numbers");

            for (int i = 0; i < length; i++)
            {
                String n = Console.ReadLine();
                numbers[i] = Convert.ToInt32(n);
            }

            Console.WriteLine("Enter the target");
            String target = Console.ReadLine();
            int target1 = Convert.ToInt32(target);

            int[] indices = new int[2];
            indices = TwosumFind(numbers, target1);
            Console.Write("Output: [");

            foreach (int k in indices)
            {
                Console.Write(k);
                Console.Write(' ');
            }
            Console.Write("]");
        }

        static int[] TwosumFind(int[] nums, int target)
        {
            int[] result = new int[2];
            int sum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                int aNum = nums[j];
                for (int i = 1; i < nums.Length; i++)
                {
                    
                    sum = aNum + nums[i];
                    Console.WriteLine("Sum=" + sum);
                    if ((sum == target) && (i!=j))
                    {
                        result[0] = j;
                        result[1] = i;
                    }

                }
            }
            return result;

        }
    }
    
}
