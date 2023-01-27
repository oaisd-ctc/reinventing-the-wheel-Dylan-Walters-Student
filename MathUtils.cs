namespace MathUtils;

public static class MathUtilities
{

    /// <summary>
    /// Finds the result of an integer raised to a power.
    /// </summary>
    /// <param name="b">The base number.</param>
    /// <param name="e">The exponent.</param>
    /// <returns>
    /// b raised to the power of e.
    /// </returns>
    public static int Power(int b, int e)
    {
        int x = 1;
        for (int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }

    /// <summary>
    /// Finds the result of a float raised to a power.
    /// </summary>
    /// <param name="b">The base number.</param>
    /// <param name="e">The exponent.</param>
    /// <returns>
    /// b raised to the power of e.
    /// </returns>
    public static float Power(float b, float e)
    {
        float x = 1;
        for (int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }

    /// <summary>
    /// Finds the result of a double raised to a power.
    /// </summary>
    /// <param name="b">The base number.</param>
    /// <param name="e">The exponent.</param>
    /// <returns>
    /// b raised to the power of e.
    /// </returns>
    public static double Power(double b, double e)
    {
        double x = 1;
        for (int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }

    /// <summary>
    /// Finds the result of a decimal raised to a power.
    /// </summary>
    /// <param name="b">The base number.</param>
    /// <param name="e">The exponent.</param>
    /// <returns>
    /// b raised to the power of e.
    /// </returns>
    public static decimal Power(decimal b, decimal e)
    {
        decimal x = 1;
        for (int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }


    /// <summary>
    /// Finds the square root of a number.
    /// </summary>
    /// <param name="b">The number to find the square root of.</param>
    /// <returns>
    /// The square root of b.
    /// </returns>
    public static double SquareRoot(int b)
    {
        double root = 1;
        int i = 0;
        while (true)
        {
            i += 1;
            root = (b / root + root) / 2;
            if (i == b + 1)
            {
                break;
            }
        }
        return root;
    }

    /// <summary>
    /// Finds the square root of a number.
    /// </summary>
    /// <param name="b">The number to find the square root of.</param>
    /// <returns>
    /// The square root of b.
    /// </returns>
    public static double SquareRoot(double b)
    {
        double root = 1;
        int i = 0;
        while (true)
        {
            i += 1;
            root = (b / root + root) / 2;
            if (i == b + 1)
            {
                break;
            }
        }
        return root;
    }

    /// <summary>
    /// Finds the square root of a number.
    /// </summary>
    /// <param name="b">The number to find the square root of.</param>
    /// <returns>
    /// The square root of b.
    /// </returns>
    public static double SquareRoot(float b)
    {
        double root = 1;
        int i = 0;
        while (true)
        {
            i += 1;
            root = (b / root + root) / 2;
            if (i == b + 1)
            {
                break;
            }
        }
        return root;
    }

    /// <summary>
    /// Finds the square root of a number.
    /// </summary>
    /// <param name="b">The number to find the square root of.</param>
    /// <returns>
    /// The square root of b.
    /// </returns>
    public static decimal SquareRoot(decimal b)
    {
        decimal root = 1;
        int i = 0;
        while (true)
        {
            i += 1;
            root = (b / root + root) / 2;
            if (i == b + 1)
            {
                break;
            }
        }
        return root;
    }


    /// <summary>
    /// Finds the absolute value of a number.
    /// </summary>
    /// <param name="x">The value to calculate the absolute value of.</param>
    /// <returns>
    /// The absolute value of x.
    /// </returns>
    public static int AbsoluteValue(int x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }

    /// <summary>
    /// Finds the absolute value of a number.
    /// </summary>
    /// <param name="x">The value to calculate the absolute value of.</param>
    /// <returns>
    /// The absolute value of x.
    /// </returns>
    public static double AbsoluteValue(double x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }

    /// <summary>
    /// Finds the absolute value of a number.
    /// </summary>
    /// <param name="x">The value to calculate the absolute value of.</param>
    /// <returns>
    /// The absolute value of x.
    /// </returns>
    public static float AbsoluteValue(float x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }

    /// <summary>
    /// Finds the absolute value of a number.
    /// </summary>
    /// <param name="x">The value to calculate the absolute value of.</param>
    /// <returns>
    /// The absolute value of x.
    /// </returns>
    public static decimal AbsoluteValue(decimal x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }

    /// <summary>
    /// Finds the least of two integers.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The lesser of the two provided numbers.
    /// </returns>
    public static int Min(int x, int y)
    {
        if (x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the least of two doubles.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The lesser of the two provided numbers.
    /// </returns>
    public static double Min(double x, double y)
    {
        if (x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the least of two floats.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The lesser of the two provided numbers.
    /// </returns>
    public static float Min(float x, float y)
    {
        if (x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the least of two decimals.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The lesser of the two provided numbers.
    /// </returns>
    public static decimal Min(decimal x, decimal y)
    {
        if (x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the greatest of two integers.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The greater of the two provided numbers.
    /// </returns>
    public static int Max(int x, int y)
    {
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the greatest of two doubles.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The greater of the two provided numbers.
    /// </returns>
    public static double Max(double x, double y)
    {
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the greatest of two floats.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The greater of the two provided numbers.
    /// </returns>
    public static float Max(float x, float y)
    {
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Finds the greatest of two decimals.
    /// </summary>
    /// <param name="x">The first number to compare.</param>
    /// <param name="y">The second number to compare.</param>
    /// <returns>
    /// The greater of the two provided numbers.
    /// </returns>
    public static decimal Max(decimal x, decimal y)
    {
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    /// <summary>
    /// Calculates the sum of two integers.
    /// </summary>
    /// <remarks>
    /// Why are you using this?
    /// </remarks>
    /// <param name="x">The first addend.</param>
    /// <param name="y">The second addend.</param>
    /// <returns>
    /// The sum of x and y.
    /// </returns>
    public static int Add(int x, int y)
    {
        return x + y;
    }

    /// <summary>
    /// Calculates the sum of two doubles.
    /// </summary>
    /// <param name="x">The first addend.</param>
    /// <param name="y">The second addend.</param>
    /// <returns>
    /// The sum of x and y.
    /// </returns>

    public static double Add(double x, double y)
    {
        return x + y;
    }

    /// <summary>
    /// Calculates the sum of two floats.
    /// </summary>
    /// <param name="x">The first addend.</param>
    /// <param name="y">The second addend.</param>
    /// <returns>
    /// The sum of x and y.
    /// </returns>
    public static float Add(float x, float y)
    {
        return x + y;
    }

    /// <summary>
    /// Calculates the sum of two decimals.
    /// </summary>
    /// <param name="x">The first addend.</param>
    /// <param name="y">The second addend.</param>
    /// <returns>
    /// The sum of x and y.
    /// </returns>
    public static decimal Add(decimal x, decimal y)
    {
        return x + y;
    }

    /// <summary>
    /// Calculates the difference of two integers.
    /// </summary>
    /// <param name="x">The minuend.</param>
    /// <param name="y">The subtrahend.</param>
    /// <returns>
    /// The difference of x and y.
    /// </returns>
    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    /// <summary>
    /// Calculates the difference of two doubles.
    /// </summary>
    /// <param name="x">The minuend.</param>
    /// <param name="y">The subtrahend.</param>
    /// <returns>
    /// The difference of x and y.
    /// </returns>
    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    /// <summary>
    /// Calculates the difference of two floats.
    /// </summary>
    /// <param name="x">The minuend.</param>
    /// <param name="y">The subtrahend.</param>
    /// <returns>
    /// The difference of x and y.
    /// </returns>
    public static float Subtract(float x, float y)
    {
        return x - y;
    }

    /// <summary>
    /// Calculates the difference of two decimals.
    /// </summary>
    /// <param name="x">The minuend.</param>
    /// <param name="y">The subtrahend.</param>
    /// <returns>
    /// The difference of x and y.
    /// </returns>
    public static decimal Subtract(decimal x, decimal y)
    {
        return x - y;
    }

    /// <summary>
    /// Calculates the product of two integers.
    /// </summary>
    /// <param name="x">The first factor.</param>
    /// <param name="y">The second factor.</param>
    /// <returns>
    /// The product of x and y.
    /// </returns>
    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    /// <summary>
    /// Calculates the product of two doubles.
    /// </summary>
    /// <param name="x">The first factor.</param>
    /// <param name="y">The second factor.</param>
    /// <returns>
    /// The product of x and y.
    /// </returns>
    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    /// <summary>
    /// Calculates the product of two floats.
    /// </summary>
    /// <param name="x">The first factor.</param>
    /// <param name="y">The second factor.</param>
    /// <returns>
    /// The product of x and y.
    /// </returns>
    public static float Multiply(float x, float y)
    {
        return x * y;
    }

    /// <summary>
    /// Calculates the product of two decimals.
    /// </summary>
    /// <param name="x">The first factor.</param>
    /// <param name="y">The second factor.</param>
    /// <returns>
    /// The product of x and y.
    /// </returns>
    public static decimal Multiply(decimal x, decimal y)
    {
        return x * y;
    }

    /// <summary>
    /// Calculates the quotient of two integers.
    /// </summary>
    /// <param name="x">The dividend.</param>
    /// <param name="y">The divisor.</param>
    /// <returns>
    /// The quotient of x and y.
    /// </returns>
    public static int Divide(int x, int y)
    {
        return x / y;
    }

    /// <summary>
    /// Calculates the quotient of two doubles.
    /// </summary>
    /// <param name="x">The dividend.</param>
    /// <param name="y">The divisor.</param>
    /// <returns>
    /// The quotient of x and y.
    /// </returns>
    public static double Divide(double x, double y)
    {
        return x / y;
    }

    /// <summary>
    /// Calculates the quotient of two floats.
    /// </summary>
    /// <param name="x">The dividend.</param>
    /// <param name="y">The divisor.</param>
    /// <returns>
    /// The quotient of x and y.
    /// </returns>
    public static float Divide(float x, float y)
    {
        return x / y;
    }

    /// <summary>
    /// Calculates the quotient of two decimals.
    /// </summary>
    /// <param name="x">The dividend.</param>
    /// <param name="y">The divisor.</param>
    /// <returns>
    /// The quotient of x and y.
    /// </returns>
    public static decimal Divide(decimal x, decimal y)
    {
        return x / y;
    }

    /// <summary>
    /// Calculates the percentage of two numbers.
    /// </summary>
    /// <param name="value">The value to calculate the percentage of.</param>
    /// <param name="total">The value to compare against.</param>
    /// <returns>
    /// The percentage of total represented by value.
    /// </returns>
    public static int Percentage(int value, int total)
    {
        double x = value;
        double y = total;
        return (int) ((x / y) * 100);
    }

    /// <summary>
    /// Calculates the percentage of two numbers.
    /// </summary>
    /// <param name="value">The value to calculate the percentage of.</param>
    /// <param name="total">The value to compare against.</param>
    /// <returns>
    /// The percentage of total represented by value.
    /// </returns>
    public static double Percentage(double value, double total)
    {
        return (value / total) * 100;
    }

    /// <summary>
    /// Calculates the percentage of two numbers.
    /// </summary>
    /// <param name="value">The value to calculate the percentage of.</param>
    /// <param name="total">The value to compare against.</param>
    /// <returns>
    /// The percentage of total represented by value.
    /// </returns>
    public static float Percentage(float value, float total)
    {
        return (value / total) * 100;
    }

    /// <summary>
    /// Calculates the percentage of two numbers.
    /// </summary>
    /// <param name="value">The value to calculate the percentage of.</param>
    /// <param name="total">The value to compare against.</param>
    /// <returns>
    /// The percentage of total represented by value.
    /// </returns>
    public static decimal Percentage(decimal value, decimal total)
    {
        return (value / total) * 100;
    }

    /// <summary>
    /// Calculates the binary representation of an integer.
    /// </summary>
    /// <param name="x">The number to convert to binary.</param>
    /// <returns>
    /// A string representing the number in binary.
    /// </returns>
    public static string Binary(int x)
    {
        string binary = "";
        while (x > 0)
        {
            int temp = x;
            temp %= 2;
            x /= 2;
            if(temp == 0) {
                binary = $"0{binary}";
            } else {
                binary = $"1{binary}";
            }
        }
        return binary;
    }

    /// <summary>
    /// Rounds down a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round down.</param>
    /// <returns>
    /// x, rounded down to the nearest integer.
    /// </returns>
    public static int Floor(double x)
    {
        int temp = Convert.ToInt32(x);
        if (temp > x)
        {
            return temp - 1;
        }
        else
        {
            return temp;
        }
    }

    /// <summary>
    /// Rounds down a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round down.</param>
    /// <returns>
    /// x, rounded down to the nearest integer.
    /// </returns>
    public static int Floor(decimal x)
    {
        int temp = Convert.ToInt32(x);
        if (temp > x)
        {
            return temp - 1;
        }
        else
        {
            return temp;
        }
    }

    /// <summary>
    /// Rounds down a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round down.</param>
    /// <returns>
    /// x, rounded down to the nearest integer.
    /// </returns>
    public static int Floor(float x)
    {
        int temp = Convert.ToInt32(x);
        if (temp > x)
        {
            return temp - 1;
        }
        else
        {
            return temp;
        }
    }

    /// <summary>
    /// Rounds up a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round up.</param>
    /// <returns>
    /// x, rounded up to the nearest integer.
    /// </returns>
    public static int ceiling(double x)
    {
        int temp = Convert.ToInt32(x);
        if (temp > x)
        {
            return temp;
        }
        else
        {
            return temp + 1;
        }
    }

    /// <summary>
    /// Rounds up a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round up.</param>
    /// <returns>
    /// x, rounded up to the nearest integer.
    /// </returns>
    public static int ceiling(decimal x)
    {
        int temp = Convert.ToInt32(x);
        if (temp > x)
        {
            return temp;
        }
        else
        {
            return temp + 1;
        }
    }

    /// <summary>
    /// Rounds up a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round up.</param>
    /// <returns>
    /// x, rounded up to the nearest integer.
    /// </returns>
    public static int ceiling(float x)
    {
        int temp = Convert.ToInt32(x);
        if (temp > x)
        {
            return temp;
        }
        else
        {
            return temp + 1;
        }
    }

    /// <summary>
    /// Rounds a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round.</param>
    /// <returns>
    /// x, rounded to the nearest integer.
    /// </returns>
    public static int round(double x)
    {
        return Convert.ToInt32(x);
    }

    /// <summary>
    /// Rounds a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round.</param>
    /// <returns>
    /// x, rounded to the nearest integer.
    /// </returns>
    public static int round(float x)
    {
        return Convert.ToInt32(x);
    }

    /// <summary>
    /// Rounds a provided value to the nearest integer.
    /// </summary>
    /// <param name="x">The value to round.</param>
    /// <returns>
    /// x, rounded to the nearest integer.
    /// </returns>
    public static int round(decimal x)
    {
        return Convert.ToInt32(x);
    }
}