namespace ArrayUtils
{
    public static class ArrayUtilities
    {

        //average
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


        //max
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


        //min
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

        //sortascending
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

        public static int[] SortDescending(int[] nums) {
            return Reverse(SortAscending(nums)); // just sort it and reverse it lol. this is ok bc we're returning a copy
        }

        public static float[] SortDescending(float[] nums) {
            return Reverse(SortAscending(nums));
        }

        public static double[] SortDescending(double[] nums) {
            return Reverse(SortAscending(nums));
        }

        public static decimal[] SortDescending(decimal[] nums) {
            return Reverse(SortAscending(nums));
        }

        //sum
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


        //product
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


        //reverse
        public static int[] Reverse(int[] nums)
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

        public static float[] Reverse(float[] nums)
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

        public static double[] Reverse(double[] nums)
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

        public static decimal[] Reverse(decimal[] nums)
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


        //median
        public static double Median(int[] nums)
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

        public static float Median(float[] nums)
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

        public static double Median(double[] nums)
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

        public static decimal Median(decimal[] nums)
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



        //mode
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
                        values = Append(counts, HowMany(nums, i));
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
                    throw new ArithmeticException();
                }

                return values[IndexOf(counts, maxcount)];
            }

            else throw new FormatException("Expected a non-empty array!");
        }

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



        //append
        public static int[] Append(int[] x, int y)
        {
            int[] z = new int[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        public static float[] Append(float[] x, float y)
        {
            float[] z = new float[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        public static double[] Append(double[] x, double y)
        {
            double[] z = new double[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        public static decimal[] Append(decimal[] x, decimal y)
        {
            decimal[] z = new decimal[x.Length + 1];
            z[x.Length] = y;

            return z;
        }

        //remove

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

        


        //contains
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


        //indexof
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



        //howmany
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