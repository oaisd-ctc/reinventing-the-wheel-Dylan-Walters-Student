namespace ArrayUtils
{
    public class ArrayUtilities
    {

        //average
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


        //max
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

            else throw new Exception();
        }

        public float Max(float[] nums)
        {
            if (nums.Length > 0)
            {
                float x = nums[0];
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

            else throw new Exception();
        }

        public double Max(double[] nums)
        {
            if (nums.Length > 0)
            {
                double x = nums[0];
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

            else throw new Exception();
        }

        public decimal Max(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal x = nums[0];
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

            else throw new Exception();
        }


        //min
        public int Min(int[] nums)
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
                        if (x > nums[i])
                        {
                            x = nums[i];
                        }
                    }
                    return x;
                }
            }

            else throw new Exception();
        }

        public float Min(float[] nums)
        {
            if (nums.Length > 0)
            {
                float x = nums[0];
                if (nums.Length == 1)
                {
                    return x;
                }
                else
                {
                    for (int i = 1; i < nums.Length; i++)
                    {
                        if (x > nums[i])
                        {
                            x = nums[i];
                        }
                    }
                    return x;
                }
            }

            else throw new Exception();
        }

        public double Min(double[] nums)
        {
            if (nums.Length > 0)
            {
                double x = nums[0];
                if (nums.Length == 1)
                {
                    return x;
                }
                else
                {
                    for (int i = 1; i < nums.Length; i++)
                    {
                        if (x > nums[i])
                        {
                            x = nums[i];
                        }
                    }
                    return x;
                }
            }

            else throw new Exception();
        }

        public decimal Min(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal x = nums[0];
                if (nums.Length == 1)
                {
                    return x;
                }
                else
                {
                    for (int i = 1; i < nums.Length; i++)
                    {
                        if (x > nums[i])
                        {
                            x = nums[i];
                        }
                    }
                    return x;
                }
            }

            else throw new Exception();
        }


        //sum
        public int Sum(int[] nums) {
            if (nums.Length > 0) {
                int x = 0;
                foreach (int i in nums) {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }

        public float Sum(float[] nums) {
            if (nums.Length > 0) {
                float x = 0;
                foreach (float i in nums) {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }

        public double Sum(double[] nums) {
            if (nums.Length > 0) {
                double x = 0;
                foreach (double i in nums) {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }

        public decimal Sum(decimal[] nums) {
            if (nums.Length > 0) {
                decimal x = 0;
                foreach (decimal i in nums) {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }


        //product
        public int Product(int[] nums) {
            if (nums.Length > 0) {
                int x = 1;
                foreach (int i in nums) {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

        public float Product(float[] nums) {
            if (nums.Length > 0) {
                float x = 1;
                foreach (float i in nums) {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

        public double Product(double[] nums) {
            if (nums.Length > 0) {
                double x = 1;
                foreach (double i in nums) {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

        public decimal Product(decimal[] nums) {
            if (nums.Length > 0) {
                decimal x = 1;
                foreach (decimal i in nums) {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

    }

}