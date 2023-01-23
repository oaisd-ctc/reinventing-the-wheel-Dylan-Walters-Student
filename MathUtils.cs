namespace MathUtils;

public class MathUtilities
{

    // Raised to a power functions/ overloads
    public int Power(int b, int e)
    {
        int x = 1;
        for(int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }
    public float Power(float b, float e)
    {
        float x = 1;
        for(int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }
    public double Power(double b, double e)
    {
        double x = 1;
        for(int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }
    public decimal Power(decimal b, decimal e)
    {
        decimal x = 1;
        for(int i = 0; i < e; i++)
        {
            x *= b;
        }
        return x;
    }

    // square root functions/ overloads
    public double SquareRoot(int b)
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
    public double SquareRoot(double b)
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
        public double SquareRoot(float b)
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
        public decimal SquareRoot(decimal b)
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

    // Absolute value functions/ overloads
    public int AbsoluteValue(int x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public double AbsoluteValue(double x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public float AbsoluteValue(float x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public decimal AbsoluteValue(decimal x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }

    // min functions/ overides
    public int Min(int x, int y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
        public double Min(double x, double y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
    public float Min(float x, float y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
    public decimal Min(decimal x, decimal y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
        // Max functions/ overides
    public int Max(int x, int y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
        public double Max(double x, double y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
    public float Max(float x, float y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
    public decimal Max(decimal x, decimal y)
    {
        if(x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    // Add functions/ overrides
    public int Add(int x, int y)
    {
        return x + y;
    }
    public double Add(double x, double y)
    {
        return x + y;
    }
    public float Add(float x, float y)
    {
        return x + y;
    }
    public decimal Add(decimal x, decimal y)
    {
        return x + y;
    }

    // Subtract functions/ overrides
    public int Subtract(int x, int y)
    {
        return x - y;
    }
    public double Subtract(double x, double y)
    {
        return x - y;
    }
    public float Subtract(float x, float y)
    {
        return x - y;
    }
    public decimal Subtract(decimal x, decimal y)
    {
        return x - y;
    }

    // Multiply functions/ overrides
    public int Multiply(int x, int y)
    {
        return x * y;
    }
    public double Multiply(double x, double y)
    {
        return x * y;
    }
    public float Multiply(float x, float y)
    {
        return x * y;
    }
    public decimal Multiply(decimal x, decimal y)
    {
        return x * y;
    }

    // Divide functions/ overrides
    public int Divide(int x, int y)
    {
        return x / y;
    }
    public double Divide(double x, double y)
    {
        return x / y;
    }
    public float Divide(float x, float y)
    {
        return x / y;
    }
    public decimal Divide(decimal x, decimal y)
    {
        return x / y;
    }

    // Percentage functions/ overrides
    public int Percentage(int value, int total)
    {
        return (value / total) * 100;
    }
    public double Percentage(double value, double total)
    {
        return (value / total) * 100;
    }
    public float Percentage(float value, float total)
    {
        return (value / total) * 100;
    }
    public decimal Percentage(decimal value, decimal total)
    {
        return (value / total) * 100;
    }

    // Binary function/ overrides.
    // public int Binary(int x)
    // {
    //     if(x != 0)
    //     {

    //     }
    // }
}     