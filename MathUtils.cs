namespace MathUtils;

public static class MathUtilities
{

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
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
    public static float Power(float b, float e)
    {
        float x = 1;
        for (int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }
    public static double Power(double b, double e)
    {
        double x = 1;
        for (int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int AbsoluteValue(int x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public static double AbsoluteValue(double x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public static float AbsoluteValue(float x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public static decimal AbsoluteValue(decimal x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static double Add(double x, double y)
    {
        return x + y;
    }
    public static float Add(float x, float y)
    {
        return x + y;
    }
    public static decimal Add(decimal x, decimal y)
    {
        return x + y;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static double Subtract(double x, double y)
    {
        return x - y;
    }
    public static float Subtract(float x, float y)
    {
        return x - y;
    }
    public static decimal Subtract(decimal x, decimal y)
    {
        return x - y;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static double Multiply(double x, double y)
    {
        return x * y;
    }
    public static float Multiply(float x, float y)
    {
        return x * y;
    }
    public static decimal Multiply(decimal x, decimal y)
    {
        return x * y;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int Divide(int x, int y)
    {
        return x / y;
    }
    public static double Divide(double x, double y)
    {
        return x / y;
    }
    public static float Divide(float x, float y)
    {
        return x / y;
    }
    public static decimal Divide(decimal x, decimal y)
    {
        return x / y;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int Percentage(int value, int total)
    {
        double x = value;
        double y = total;
        return (int) ((x / y) * 100);
    }
    public static double Percentage(double value, double total)
    {
        return (value / total) * 100;
    }
    public static float Percentage(float value, float total)
    {
        return (value / total) * 100;
    }
    public static decimal Percentage(decimal value, decimal total)
    {
        return (value / total) * 100;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
        public static int Floor(int x)
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int ceiling(int x)
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
    ///
    /// </summary>
    /// <param name=""> </param>
    /// <param name=""> </param>
    /// <returns>
    ///
    /// </returns>
    public static int round(int x)
    {
        return Convert.ToInt32(x);
    }
    public static int round(double x)
    {
        return Convert.ToInt32(x);
    }
    public static int round(float x)
    {
        return Convert.ToInt32(x);
    }
    public static int round(decimal x)
    {
        return Convert.ToInt32(x);
    }
}