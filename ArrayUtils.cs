namespace ArrayUtils
{
    public class ArrayUtilities
    {

        //average
        public double Average(int[] nums)
        {
            if (nums.Length > 0) //empty arrays are cringe!!!
            {
                double x = 0;

                foreach (int i in nums)
                {
                    x += i;
                }

                x /= nums.Length;

                return x;
            }

            else throw new Exception();
        }

        public float Average(float[] nums)
        {
            if (nums.Length > 0)
            {
                float x = 0;

                foreach (float i in nums)
                {
                    x += i;
                }

                x /= nums.Length;

                return x;
            }

            else throw new Exception();
        }

        public double Average(double[] nums)
        {
            if (nums.Length > 0)
            {
                double x = 0;

                foreach (double i in nums)
                {
                    x += i;
                }

                x /= nums.Length;

                return x;
            }

            else throw new Exception();
        }

        public decimal Average(decimal[] nums)
        {

            if (nums.Length > 0)
            {
                decimal x = 0;

                foreach (decimal i in nums)
                {
                    x += i;
                }

                x /= nums.Length;

                return x;
            }

            else throw new Exception();
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
        public int Sum(int[] nums)
        {
            if (nums.Length > 0)
            {
                int x = 0;
                foreach (int i in nums)
                {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }

        public float Sum(float[] nums)
        {
            if (nums.Length > 0)
            {
                float x = 0;
                foreach (float i in nums)
                {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }

        public double Sum(double[] nums)
        {
            if (nums.Length > 0)
            {
                double x = 0;
                foreach (double i in nums)
                {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }

        public decimal Sum(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal x = 0;
                foreach (decimal i in nums)
                {
                    x += i;
                }
                return x;
            }

            else throw new Exception();
        }


        //product
        public int Product(int[] nums)
        {
            if (nums.Length > 0)
            {
                int x = 1;
                foreach (int i in nums)
                {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

        public float Product(float[] nums)
        {
            if (nums.Length > 0)
            {
                float x = 1;
                foreach (float i in nums)
                {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

        public double Product(double[] nums)
        {
            if (nums.Length > 0)
            {
                double x = 1;
                foreach (double i in nums)
                {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }

        public decimal Product(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal x = 1;
                foreach (decimal i in nums)
                {
                    x *= i;
                }
                return x;
            }

            else throw new Exception();
        }


        //reverse
        public int[] Reverse(int[] nums)
        {
            if (nums.Length > 0)
            {
                int[] nums2 = new int[nums.Length];
                int x = 0;
                for (int i = nums.Length; i > 0; i--)
                { // iterate through the array in reverse
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new Exception();
        }

        public float[] Reverse(float[] nums)
        {
            if (nums.Length > 0)
            {
                float[] nums2 = new float[nums.Length];
                int x = 0;
                for (int i = nums.Length; i > 0; i--)
                {
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new Exception();
        }

        public double[] Reverse(double[] nums)
        {
            if (nums.Length > 0)
            {
                double[] nums2 = new double[nums.Length];
                int x = 0;
                for (int i = nums.Length; i > 0; i--)
                {
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new Exception();
        }

        public decimal[] Reverse(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal[] nums2 = new decimal[nums.Length];
                int x = 0;
                for (int i = nums.Length; i > 0; i--)
                {
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new Exception();
        }

        public double Median(int[] nums)
        {
            if (nums.Length > 0)
            {
                if (nums.Length % 2 == 1)  //if the array has an odd length...
                {
                    return nums[nums.Length / 2 - 1]; // just get the middle integer.
                }
                else //otherwise...
                {
                    double x = nums[nums.Length / 2]; //average the middle two numbers.
                    double y = nums[nums.Length / 2 - 1];
                    return (x + y / 2);
                }
            }

            else throw new Exception();
        }

        public float Median(float[] nums)
        {
            if (nums.Length > 0)
            {
                if (nums.Length % 2 == 1)
                { 
                    return nums[nums.Length / 2 - 1]; 
                }
                else
                {
                    float x = nums[nums.Length / 2];
                    float y = nums[nums.Length / 2 - 1];
                    return (x + y / 2);
                }
            }

            else throw new Exception();
        }

        public double Median(double[] nums)
        {
            if (nums.Length > 0)
            {
                if (nums.Length % 2 == 1)
                { 
                    return nums[nums.Length / 2 - 1]; 
                }
                else
                {
                    double x = nums[nums.Length / 2];
                    double y = nums[nums.Length / 2 - 1];
                    return (x + y / 2);
                }
            }

            else throw new Exception();
        }

        public decimal Median(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                if (nums.Length % 2 == 1)
                { 
                    return nums[nums.Length / 2 - 1]; 
                }
                else
                {
                    decimal x = nums[nums.Length / 2];
                    decimal y = nums[nums.Length / 2 - 1];
                    return (x + y / 2);
                }
            }

            else throw new Exception();
        }

    }

}