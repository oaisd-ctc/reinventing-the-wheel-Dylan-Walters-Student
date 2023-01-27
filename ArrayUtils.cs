namespace ArrayUtils
{
    public static class ArrayUtilities
    {

        /// <summary>
        /// Finds the average of an array of integers.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to return an average from.</param>
        /// <returns>
        /// The average of array nums.
        /// </returns>
        public static double Average(int[] nums)
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

        /// <summary>
        /// Finds the average of an array of floats.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to return an average from.</param>
        /// <returns>
        /// The average of array nums.
        /// </returns>
        public static float Average(float[] nums)
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

        /// <summary>
        /// Finds the average of an array of doubles.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to return an average from.</param>
        /// <returns>
        /// The average of array nums.
        /// </returns>
        public static double Average(double[] nums)
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

        /// <summary>
        /// Finds the average of an array of decimals.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to return an average from.</param>
        /// <returns>
        /// The average of array nums.
        /// </returns>
        public static decimal Average(decimal[] nums)
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


        /// <summary>
        /// Finds the greatest integer in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to return a maximum from.</param>
        /// <returns>
        /// The greatest integer in array nums.
        /// </returns>
        public static int Max(int[] nums)
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

        /// <summary>
        /// Finds the greatest float in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to return a maximum from.</param>
        /// <returns>
        /// The greatest float in array nums.
        /// </returns>
        public static float Max(float[] nums)
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

        /// <summary>
        /// Finds the greatest double in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to return a maximum from.</param>
        /// <returns>
        /// The greatest double in array nums.
        /// </returns>
        public static double Max(double[] nums)
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

        /// <summary>
        /// Finds the greatest decimal in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to return a maximum from.</param>
        /// <returns>
        /// The greatest decimal in array nums.
        /// </returns>
        public static decimal Max(decimal[] nums)
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


        /// <summary>
        /// Finds the least integer in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to return a minimum from.</param>
        /// <returns>
        /// The least integer in array nums.
        /// </returns>
        public static int Min(int[] nums)
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

        /// <summary>
        /// Finds the least float in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to return a minimum from.</param>
        /// <returns>
        /// The least float in array nums.
        /// </returns>
        public static float Min(float[] nums)
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

        /// <summary>
        /// Finds the least double in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to return a minimum from.</param>
        /// <returns>
        /// The least double in array nums.
        /// </returns>
        public static double Min(double[] nums)
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

        /// <summary>
        /// Finds the least decimal in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to return a minimum from.</param>
        /// <returns>
        /// The least decimal in array nums.
        /// </returns>
        public static decimal Min(decimal[] nums)
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

        /// <summary>
        /// Sorts an array of integers from least to greatest.
        /// </summary>
        /// <param name="nums">The set of integers to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static int[] SortAscending(int[] nums) { //probably terribly inefficient lol
            int[] x = nums; //create a shallow copy of nums so we don't overwrite it lol
            int[] y = new int[0]; // create a new array to sort into
            int temp;
            while (x.Length > 0) { //for every item in x
                temp = Min(x); //get the minimum
                y = Append(y, temp); //put it in y
                x = Remove(x, IndexOf(x, temp)); //remove it from x
            }
            // at the end you should have a sorted array
            return y;
        }

        /// <summary>
        /// Sorts an array of floats from least to greatest.
        /// </summary>
        /// <param name="nums">The set of floats to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static float[] SortAscending(float[] nums) {
            float[] x = nums;
            float[] y = new float[0];
            float temp;
            while (x.Length > 0) {
                temp = Min(x);
                y = Append(y, temp);
                x = Remove(x, IndexOf(x, temp));
            }
            
            return y;
        }

        /// <summary>
        /// Sorts an array of doubles from least to greatest.
        /// </summary>
        /// <param name="nums">The set of doubles to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static double[] SortAscending(double[] nums) {
            double[] x = nums;
            double[] y = new double[0];
            double temp;
            while (x.Length > 0) {
                temp = Min(x);
                y = Append(y, temp);
                x = Remove(x, IndexOf(x, temp));
            }
            
            return y;
        }

        /// <summary>
        /// Sorts an array of decimals from least to greatest.
        /// </summary>
        /// <param name="nums">The set of decimals to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static decimal[] SortAscending(decimal[] nums) {
            decimal[] x = nums;
            decimal[] y = new decimal[0];
            decimal temp;
            while (x.Length > 0) {
                temp = Min(x);
                y = Append(y, temp);
                x = Remove(x, IndexOf(x, temp));
            }
            
            return y;
        }

        /// <summary>
        /// Sorts an array of integers from greatest to least.
        /// </summary>
        /// <param name="nums">The set of integers to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static int[] SortDescending(int[] nums) {
            return Reverse(SortAscending(nums)); // just sort it and reverse it lol. this is ok bc we're returning a copy
        }

        /// <summary>
        /// Sorts an array of floats from greatest to least.
        /// </summary>
        /// <param name="nums">The set of floats to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static float[] SortDescending(float[] nums) {
            return Reverse(SortAscending(nums));
        }

        /// <summary>
        /// Sorts an array of doubles from greatest to least.
        /// </summary>
        /// <param name="nums">The set of doubles to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static double[] SortDescending(double[] nums) {
            return Reverse(SortAscending(nums));
        }

        /// <summary>
        /// Sorts an array of decimals from greatest to least.
        /// </summary>
        /// <param name="nums">The set of decimals to sort.</param>
        /// <returns>
        /// The sorted array.
        /// </returns>
        public static decimal[] SortDescending(decimal[] nums) {
            return Reverse(SortAscending(nums));
        }


        /// <summary>
        /// Finds the sum of all of the integers in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to add.</param>
        /// <returns>
        /// The sum of the integers in nums.
        /// </returns>
        public static int Sum(int[] nums)
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

        /// <summary>
        /// Finds the sum of all of the floats in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to add.</param>
        /// <returns>
        /// The sum of the floats in nums.
        /// </returns>
        public static float Sum(float[] nums)
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


        /// <summary>
        /// Finds the sum of all of the doubles in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to add.</param>
        /// <returns>
        /// The sum of the doubles in nums.
        /// </returns>
        public static double Sum(double[] nums)
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

        /// <summary>
        /// Finds the sum of all of the decimals in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to add.</param>
        /// <returns>
        /// The sum of the decimals in nums.
        /// </returns>
        public static decimal Sum(decimal[] nums)
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


        /// <summary>
        /// Finds the product of all of the integers in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to multiply.</param>
        /// <returns>
        /// The product of the integers in nums.
        /// </returns>
        public static int Product(int[] nums)
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

        /// <summary>
        /// Finds the product of all of the floats in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to multiply.</param>
        /// <returns>
        /// The product of the floats in nums.
        /// </returns>
        public static float Product(float[] nums)
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

        /// <summary>
        /// Finds the product of all of the doubles in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to multiply.</param>
        /// <returns>
        /// The product of the doubles in nums.
        /// </returns>
        public static double Product(double[] nums)
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


        /// <summary>
        /// Finds the product of all of the decimals in an array.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to multiply.</param>
        /// <returns>
        /// The product of the decimals in nums.
        /// </returns>
        public static decimal Product(decimal[] nums)
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


        /// <summary>
        /// Reverses the order of the elements in an array of integers.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to reverse.</param>
        /// <returns>
        /// A reversed, shallow copy of nums.
        /// </returns>
        public static int[] Reverse(int[] nums)
        {
            if (nums.Length > 0)
            {
                int[] nums2 = new int[nums.Length];
                int x = 0;
                for (int i = nums.Length - 1; i >= 0; i--)
                { // iterate through the array in reverse
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        /// <summary>
        /// Reverses the order of the elements in an array of floats.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to reverse.</param>
        /// <returns>
        /// A reversed, shallow copy of nums.
        /// </returns>
        public static float[] Reverse(float[] nums)
        {
            if (nums.Length > 0)
            {
                float[] nums2 = new float[nums.Length];
                int x = 0;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        /// <summary>
        /// Reverses the order of the elements in an array of doubles.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to reverse.</param>
        /// <returns>
        /// A reversed, shallow copy of nums.
        /// </returns>
        public static double[] Reverse(double[] nums)
        {
            if (nums.Length > 0)
            {
                double[] nums2 = new double[nums.Length];
                int x = 0;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        /// <summary>
        /// Reverses the order of the elements in an array of decimals.
        /// </summary>
        /// <remarks>
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to reverse.</param>
        /// <returns>
        /// A reversed, shallow copy of nums.
        /// </returns>
        public static decimal[] Reverse(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal[] nums2 = new decimal[nums.Length];
                int x = 0;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    nums2[x] = nums[i];
                    x++;
                }

                return nums2;
            }

            else throw new FormatException("Expected a non-empty array!");
        }


        /// <summary>
        /// Finds the median of a set of integers.
        /// </summary>
        /// <remarks>
        /// If the provided array has an even length, the average of the two middle numbers is calculated.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to find the median of.</param>
        /// <returns>
        /// The median of nums.
        /// </returns>
        public static double Median(int[] nums)
        {
            if (nums.Length > 0)
            {
                int[] nums2 = SortAscending(nums);
                if (nums.Length % 2 == 1)  //if the array has an odd length...
                {
                    return nums2[nums.Length / 2 - 1]; // just get the middle integer.
                }
                else //otherwise...
                {
                    double x = nums2[nums2.Length / 2]; //average the middle two numbers.
                    double y = nums2[nums2.Length / 2 - 1];
                    return ((x + y) / 2);
                }
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        /// <summary>
        /// Finds the median of a set of floats.
        /// </summary>
        /// <remarks>
        /// If the provided array has an even length, the average of the two middle numbers is calculated.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to find the median of.</param>
        /// <returns>
        /// The median of nums.
        /// </returns>
        public static float Median(float[] nums)
        {
            if (nums.Length > 0)
            {
                float[] nums2 = SortAscending(nums);
                if (nums.Length % 2 == 1)  //if the array has an odd length...
                {
                    return nums2[nums.Length / 2 - 1]; // just get the middle integer.
                }
                else //otherwise...
                {
                    float x = nums2[nums2.Length / 2]; //average the middle two numbers.
                    float y = nums2[nums2.Length / 2 - 1];
                    return ((x + y) / 2);
                }
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        /// <summary>
        /// Finds the median of a set of doubles.
        /// </summary>
        /// <remarks>
        /// If the provided array has an even length, the average of the two middle numbers is calculated.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to find the median of.</param>
        /// <returns>
        /// The median of nums.
        /// </returns>
        public static double Median(double[] nums)
        {
            if (nums.Length > 0)
            {
                double[] nums2 = SortAscending(nums);
                if (nums.Length % 2 == 1)  //if the array has an odd length...
                {
                    return nums2[nums.Length / 2 - 1]; // just get the middle integer.
                }
                else //otherwise...
                {
                    double x = nums2[nums2.Length / 2]; //average the middle two numbers.
                    double y = nums2[nums2.Length / 2 - 1];
                    return ((x + y) / 2);
                }
            }

            else throw new FormatException("Expected a non-empty array!");
        }

        /// <summary>
        /// Finds the median of a set of decimals.
        /// </summary>
        /// <remarks>
        /// If the provided array has an even length, the average of the two middle numbers is calculated.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to find the median of.</param>
        /// <returns>
        /// The median of nums.
        /// </returns>
        public static decimal Median(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal[] nums2 = SortAscending(nums);
                if (nums.Length % 2 == 1)  //if the array has an odd length...
                {
                    return nums2[nums.Length / 2 - 1]; // just get the middle integer.
                }
                else //otherwise...
                {
                    decimal x = nums2[nums2.Length / 2]; //average the middle two numbers.
                    decimal y = nums2[nums2.Length / 2 - 1];
                    return ((x + y) / 2);
                }
            }

            else throw new FormatException("Expected a non-empty array!");
        }



        /// <summary>
        /// Finds the mode of a set of integers.
        /// </summary>
        /// <remarks>
        /// If the provided array has no mode, this method throws an Exception.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of integers to find the mode of.</param>
        /// <returns>
        /// The mode of nums.
        /// </returns>
        public static int Mode(int[] nums)  // AFAIK i'm not allowed to use dictionaries, given that they're defined in System.Collections.Generic. That's not gonna stop me.
        {
            if (nums.Length > 0)
            {
                int[] values = new int[0]; //list of unique values in the array
                int[] counts = new int[0]; //corresponding array of their number of occurrences

                foreach (int i in nums) //get entries of all of the numbers and their number of occurrences
                {
                    if (!Contains(values, i)) //if values doesn't have an entry for a number
                    {
                        values = Append(values, i); //create one, and a corresponding entry in counts containing its occurrences
                        counts = Append(counts, HowMany(nums, i));
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

        /// <summary>
        /// Finds the mode of a set of floats.
        /// </summary>
        /// <remarks>
        /// If the provided array has no mode, this method throws an Exception.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of floats to find the mode of.</param>
        /// <returns>
        /// The mode of nums.
        /// </returns>
        public static float Mode(float[] nums)
        {
            if (nums.Length > 0)
            {
                float[] values = new float[0];
                int[] counts = new int[0];

                foreach (int i in nums)
                {
                    if (!Contains(values, i))
                    {
                        values = Append(values, i);
                        counts = Append(counts, HowMany(nums, i));
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

        /// <summary>
        /// Finds the mode of a set of doubles.
        /// </summary>
        /// <remarks>
        /// If the provided array has no mode, this method throws an Exception.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of doubles to find the mode of.</param>
        /// <returns>
        /// The mode of nums.
        /// </returns>
        public static double Mode(double[] nums)
        {
            if (nums.Length > 0)
            {

                double[] values = new double[0];
                int[] counts = new int[0];

                foreach (int i in nums)
                {
                    if (!Contains(values, i))
                    {
                        values = Append(values, i);
                        counts = Append(counts, HowMany(nums, i));
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

        /// <summary>
        /// Finds the mode of a set of decimals.
        /// </summary>
        /// <remarks>
        /// If the provided array has no mode, this method throws an Exception.
        /// Throws a FormatException if the provided array has no elements.
        /// </remarks>
        /// <param name="nums">The set of decimals to find the mode of.</param>
        /// <returns>
        /// The mode of nums.
        /// </returns>
        public static decimal Mode(decimal[] nums)
        {
            if (nums.Length > 0)
            {
                decimal[] values = new decimal[0];
                int[] counts = new int[0];

                foreach (int i in nums)
                {
                    if (!Contains(values, i))
                    {
                        values = Append(values, i);
                        counts = Append(counts, HowMany(nums, i));
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

        /// <summary>
        /// Adds a specified value to all of the values in an array of integers.
        /// </summary>
        /// <param name="x">The set of integers to apply the operation to.</param>
        /// <param name="y">The integer added to each value in the array.</param>
        /// <returns>
        /// A copy of x after the operation has been applied.
        /// </returns>
        public static int[] AddToAll(int[] x, int y)
        {
            int temp = 0;
            int[] z = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            { //deep copy x to z
                temp = x[i];
                temp += y; //add the number
                z[i] = temp;
            }

            return z;
        }

        /// <summary>
        /// Adds a specified value to all of the values in an array of floats.
        /// </summary>
        /// <param name="x">The set of floats to apply the operation to.</param>
        /// <param name="y">The float added to each value in the array.</param>
        /// <returns>
        /// A copy of x after the operation has been applied.
        /// </returns>
        public static float[] AddToAll(float[] x, float y)
        {
            float temp = 0;
            float[] z = new float[x.Length];

            for (int i = 0; i < x.Length; i++)
            { //deep copy x to z
                temp = x[i];
                temp += y; //add the number
                z[i] = temp;
            }

            return z;
        }

        /// <summary>
        /// Adds a specified value to all of the values in an array of doubles.
        /// </summary>
        /// <param name="x">The set of doubles to apply the operation to.</param>
        /// <param name="y">The double added to each value in the array.</param>
        /// <returns>
        /// A copy of x after the operation has been applied.
        /// </returns>
        public static double[] AddToAll(double[] x, double y)
        {
            double temp = 0;
            double[] z = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            { //deep copy x to z
                temp = x[i];
                temp += y; //add the number
                z[i] = temp;
            }

            return z;
        }

        /// <summary>
        /// Adds a specified value to all of the values in an array of decimals.
        /// </summary>
        /// <param name="x">The set of decimals to apply the operation to.</param>
        /// <param name="y">The decimal added to each value in the array.</param>
        /// <returns>
        /// A copy of x after the operation has been applied.
        /// </returns>
        public static decimal[] AddToAll(decimal[] x, decimal y)
        {
            decimal temp = 0;
            decimal[] z = new decimal[x.Length];

            for (int i = 0; i < x.Length; i++)
            { //deep copy x to z
                temp = x[i];
                temp += y; //add the number
                z[i] = temp;
            }

            return z;
        }



        /// <summary>
        /// Appends an element to an array of integers.
        /// </summary>
        /// <param name="x">The array to append to.</param>
        /// <param name="y">The value to be appended to the array.</param>
        /// <returns>
        /// A copy of x, with y appended to the end of it.
        /// </returns>
        public static int[] Append(int[] x, int y)
        {
            int[] z = new int[x.Length + 1];
            for (int i = 0; i < x.Length; i++) {
                z[i] = x[i];
            }
            z[x.Length] = y;

            return z;
        }

        /// <summary>
        /// Appends an element to an array of floats.
        /// </summary>
        /// <param name="x">The array to append to.</param>
        /// <param name="y">The value to be appended to the array.</param>
        /// <returns>
        /// A copy of x, with y appended to the end of it.
        /// </returns>
        public static float[] Append(float[] x, float y)
        {
            float[] z = new float[x.Length + 1];
            for (int i = 0; i < x.Length; i++) {
                z[i] = x[i];
            }
            z[x.Length] = y;

            return z;
        }

        /// <summary>
        /// Appends an element to an array of doubles.
        /// </summary>
        /// <param name="x">The array to append to.</param>
        /// <param name="y">The value to be appended to the array.</param>
        /// <returns>
        /// A copy of x, with y appended to the end of it.
        /// </returns>
        public static double[] Append(double[] x, double y)
        {
            double[] z = new double[x.Length + 1];
            for (int i = 0; i < x.Length; i++) {
                z[i] = x[i];
            }
            z[x.Length] = y;

            return z;
        }

        /// <summary>
        /// Appends an element to an array of decimals.
        /// </summary>
        /// <param name="x">The array to append to.</param>
        /// <param name="y">The value to be appended to the array.</param>
        /// <returns>
        /// A copy of x, with y appended to the end of it.
        /// </returns>
        public static decimal[] Append(decimal[] x, decimal y)
        {
            decimal[] z = new decimal[x.Length + 1];
            for (int i = 0; i < x.Length; i++) {
                z[i] = x[i];
            }
            z[x.Length] = y;

            return z;
        }

        /// <summary>
        /// Removes an element at a specified index from an array of integers.
        /// </summary>
        /// <param name="x">The array to remove from.</param>
        /// <param name="y">The index of the value to be removed from the array.</param>
        /// <returns>
        /// A copy of x, without the element at the specified index y.
        /// </returns>
        public static int[] Remove(int[] x, int y)
        {
            if (y >= x.Length || y < 0) return x; //if y is outside the bounds of the array, do nothing

            int[] z = new int[0];

            for (int i = 0; i < x.Length; i++)
            { //for everything in the array
                if (i != y)
                {   // if it's not at the specified index
                    z = Append(z, x[i]); // copy it over
                }
            }

            return z;
        }

        /// <summary>
        /// Removes an element at a specified index from an array of floats.
        /// </summary>
        /// <param name="x">The array to remove from.</param>
        /// <param name="y">The index of the value to be removed from the array.</param>
        /// <returns>
        /// A copy of x, without the element at the specified index y.
        /// </returns>
        public static float[] Remove(float[] x, float y)
        {
            if (y >= x.Length || y < 0) return x; //if y is outside the bounds of the array, do nothing

            float[] z = new float[0];

            for (int i = 0; i < x.Length; i++)
            { //for everything in the array
                if (i != y)
                {   // if it's not at the specified index
                    z = Append(z, x[i]); // copy it over
                }
            }

            return z;
        }

        /// <summary>
        /// Removes an element at a specified index from an array of doubles.
        /// </summary>
        /// <param name="x">The array to remove from.</param>
        /// <param name="y">The index of the value to be removed from the array.</param>
        /// <returns>
        /// A copy of x, without the element at the specified index y.
        /// </returns>
        public static double[] Remove(double[] x, double y)
        {
            if (y >= x.Length || y < 0) return x; //if y is outside the bounds of the array, do nothing

            double[] z = new double[0];

            for (int i = 0; i < x.Length; i++)
            { //for everything in the array
                if (i != y)
                {   // if it's not at the specified index
                    z = Append(z, x[i]); // copy it over
                }
            }

            return z;
        }

        /// <summary>
        /// Removes an element at a specified index from an array of decimals.
        /// </summary>
        /// <param name="x">The array to remove from.</param>
        /// <param name="y">The index of the value to be removed from the array.</param>
        /// <returns>
        /// A copy of x, without the element at the specified index y.
        /// </returns>
        public static decimal[] Remove(decimal[] x, decimal y)
        {
            if (y >= x.Length || y < 0) return x; //if y is outside the bounds of the array, do nothing

            decimal[] z = new decimal[0];

            for (int i = 0; i < x.Length; i++)
            { //for everything in the array
                if (i != y)
                {   // if it's not at the specified index
                    z = Append(z, x[i]); // copy it over
                }
            }

            return z;
        }

        


        /// <summary>
        /// Determines if an array of integers contains a specified value.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// True if x contains the value y, false otherwise.
        /// </returns>
        public static bool Contains(int[] x, int y)
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

        /// <summary>
        /// Determines if an array of floats contains a specified value.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// True if x contains the value y, false otherwise.
        /// </returns>
        public static bool Contains(float[] x, float y)
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

        /// <summary>
        /// Determines if an array of doubles contains a specified value.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// True if x contains the value y, false otherwise.
        /// </returns>
        public static bool Contains(double[] x, double y)
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

        /// <summary>
        /// Determines if an array of decimals contains a specified value.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// True if x contains the value y, false otherwise.
        /// </returns>
        public static bool Contains(decimal[] x, decimal y)
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


        /// <summary>
        /// Finds the first occurrence of a value in a given array of integers.
        /// </summary>
        /// <remarks>
        /// If the provided value has no occurrences in the array, this method returns -1.
        /// </remarks>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The index (zero-based) of the first occurrence of y in array x.
        /// If x does not contain y, returns -1.
        /// </returns>
        public static int IndexOf(int[] x, int y)
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

        /// <summary>
        /// Finds the first occurrence of a value in a given array of floats.
        /// </summary>
        /// <remarks>
        /// If the provided value has no occurrences in the array, this method returns -1.
        /// </remarks>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The index (zero-based) of the first occurrence of y in array x.
        /// If x does not contain y, returns -1.
        /// </returns>
        public static int IndexOf(float[] x, float y)
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

        /// <summary>
        /// Finds the first occurrence of a value in a given array of doubles.
        /// </summary>
        /// <remarks>
        /// If the provided value has no occurrences in the array, this method returns -1.
        /// </remarks>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The index (zero-based) of the first occurrence of y in array x.
        /// If x does not contain y, returns -1.
        /// </returns>
        public static int IndexOf(double[] x, double y)
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

        /// <summary>
        /// Finds the first occurrence of a value in a given array of decimals.
        /// </summary>
        /// <remarks>
        /// If the provided value has no occurrences in the array, this method returns -1.
        /// </remarks>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The index (zero-based) of the first occurrence of y in array x.
        /// If x does not contain y, returns -1.
        /// </returns>
        public static int IndexOf(decimal[] x, decimal y)
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



        /// <summary>
        /// Finds the number of occurrences of a value in a given array of integers.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The number of elements equal to y in array x.
        /// </returns>
        public static int HowMany(int[] x, int y)
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

        /// <summary>
        /// Finds the number of occurrences of a value in a given array of floats.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The number of elements equal to y in array x.
        /// </returns>
        public static int HowMany(float[] x, float y)
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

        /// <summary>
        /// Finds the number of occurrences of a value in a given array of doubles.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The number of elements equal to y in array x.
        /// </returns>
        public static int HowMany(double[] x, double y)
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

        /// <summary>
        /// Finds the number of occurrences of a value in a given array of decimals.
        /// </summary>
        /// <param name="x">The array to check.</param>
        /// <param name="y">The value to check for.</param>
        /// <returns>
        /// The number of elements equal to y in array x.
        /// </returns>
        public static int HowMany(decimal[] x, decimal y)
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