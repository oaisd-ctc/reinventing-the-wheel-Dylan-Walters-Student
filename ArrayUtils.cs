namespace ArrayUtils
{
    public class ArrayUtilities
    {
        public double Average(int[] nums)
        {
            double x = 0;

            foreach (int i in nums)
            {
                x += i;
            }

            x /= nums.Length;

            return x;
        }

        public float Average(float[] nums)
        {
            float x = 0;

            foreach (float i in nums)
            {
                x += i;
            }

            x /= nums.Length;

            return x;
        }

        public double Average(double[] nums)
        {
            double x = 0;

            foreach (double i in nums)
            {
                x += i;
            }

            x /= nums.Length;

            return x;
        }

        public decimal Average(decimal[] nums)
        {
            decimal x = 0;

            foreach (decimal i in nums)
            {
                x += i;
            }

            x /= nums.Length;

            return x;
        }

        public int Max(int[] nums)
        {
            if (nums.Length > 0)
            {
                int x = nums[0];
                if (nums.Length == 1)
                {
                    return x;
                }
                else
                {
                    for (int i = 1; i < nums.Length; i++)
                    {
                        if (x < nums[i])
                        {
                            x = nums[i];
                        }
                    }
                    return x;
                }
            }

            else throw new Exception("Average() received empty array!");
        }

    }

}