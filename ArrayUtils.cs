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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
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

            else throw new FormatException("Expected a non-empty array!");
        }

        public int Mode(int[] nums)  // AFAIK i'm not allowed to use dictionaries, given that they're defined in System.Collections.Generic. That's not gonna stop me.
        {
            if (nums.Length > 0)
            {
                int[] values = new int[0]; //list of unique values in the array
                int[] counts = new int[0]; //corresponding array of their number of occurrences

                foreach (int i in nums) //get entries of all of the numbers and their number of occurrences
                {
                    if (!Contains(values, i)) //if values doesn't have an entry for a number
                    {
                        Append(values, i); //create one, and a corresponding entry in counts containing its occurrences
                        Append(counts, HowMany(nums, i));
                    }
                }

                int maxcount = Max(counts); //get the number of occurrences of the mode

                if (HowMany(counts, maxcount) > 1) //if there is more than one number with that number of occurrences (no mode!)
                {
                    throw new Exception(); // cry like a little baby to indicate such
                }

                //otherwise, we know there's a mode!
                return values[IndexOf(counts, maxcount)]; //return the corresponding value from the values array'
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        public float Mode(float[] nums)
        {
            if (nums.Length > 0)
            {
                float[] values = new float[0];
                int[] counts = new int[0];

                foreach (int i in nums)
                {
                    if (!Contains(values, i))
                    {
                        Append(values, i);
                        Append(counts, HowMany(nums, i));
                    }
                }

                int maxcount = Max(counts);

                if (HowMany(counts, maxcount) > 1)
                {
                    throw new Exception();
                }

                return values[IndexOf(counts, maxcount)];
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        public double Mode(double[] nums)
        {
            if (nums.Length > 0)
            {

                double[] values = new double[0];
                int[] counts = new int[0];

                foreach (int i in nums)
                {
                    if (!Contains(values, i))
                    {
                        Append(values, i);
                        Append(counts, HowMany(nums, i));
                    }
                }

                int maxcount = Max(counts);

                if (HowMany(counts, maxcount) > 1)
                {
                    throw new Exception();
                }

                return values[IndexOf(counts, maxcount)];
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        public decimal Mode(decimal[] nums)
        {
            if (nums.Length > 0) {
                decimal[] values = new decimal[0];
                int[] counts = new int[0];

                foreach (int i in nums)
                {
                    if (!Contains(values, i))
                    {
                        Append(values, i);
                        Append(counts, HowMany(nums, i));
                    }
                }

                int maxcount = Max(counts);

                if (HowMany(counts, maxcount) > 1)
                {
                    throw new ArithmeticException();
                }

                return values[IndexOf(counts, maxcount)];
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        //append
        public int[] Append(int[] x, int y)
        {
            int[] z = new int[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        public float[] Append(float[] x, float y)
        {
            float[] z = new float[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        public double[] Append(double[] x, double y)
        {
            double[] z = new double[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        public decimal[] Append(decimal[] x, decimal y)
        {
            decimal[] z = new decimal[x.Length + 1];
            z[x.Length] = y;

            return z;
        }


        //contains
        public bool Contains(int[] x, int y)
        {
            foreach (int i in x)
            {
                if (i == y)
                {
                    return true; //return early to terminate the function
                }
            }

            return false;
        }

        public bool Contains(float[] x, float y)
        {
            foreach (float i in x)
            {
                if (i == y)
                {
                    return true; //return early to terminate the function
                }
            }

            return false;
        }

        public bool Contains(double[] x, double y)
        {
            foreach (double i in x)
            {
                if (i == y)
                {
                    return true; //return early to terminate the function
                }
            }

            return false;
        }

        public bool Contains(decimal[] x, decimal y)
        {
            foreach (decimal i in x)
            {
                if (i == y)
                {
                    return true; //return early to terminate the function
                }
            }

            return false;
        }


        // indexof
        public int IndexOf(int[] x, int y)
        {
            if (Contains(x, y))
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == y)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else return -1;
        }

        public int IndexOf(float[] x, float y)
        {
            if (Contains(x, y))
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == y)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else return -1;
        }

        public int IndexOf(double[] x, double y)
        {
            if (Contains(x, y))
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == y)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else return -1;
        }

        public int IndexOf(decimal[] x, decimal y)
        {
            if (Contains(x, y))
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == y)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else return -1;
        }



        // howmany
        public int HowMany(int[] x, int y)
        {
            int count = 0;

            foreach (int i in x)
            {
                if (i == y)
                {
                    count++;
                };
            }
            return count;
        }

        public int HowMany(float[] x, float y)
        {
            int count = 0;

            foreach (float i in x)
            {
                if (i == y)
                {
                    count++;
                };
            }
            return count;
        }

        public int HowMany(double[] x, double y)
        {
            int count = 0;

            foreach (double i in x)
            {
                if (i == y)
                {
                    count++;
                };
            }
            return count;
        }

        public int HowMany(decimal[] x, decimal y)
        {
            int count = 0;

            foreach (decimal i in x)
            {
                if (i == y)
                {
                    count++;
                };
            }
            return count;
        }

    }

}