using Xunit;
using ArrayUtils;
using MathUtils;
using StringUtils;
public class Tests
{

    [Fact]
    public void ArrayTests()
    {
        {
            int[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0 / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new int[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new int[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new int[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new int[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new int[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new int[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(-1, ArrayUtilities.IndexOf(nums, 69));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));

            nums = new int[] { 1, 2, -1, 2, 3 }; // test mode properly
            Assert.Equal(2, ArrayUtilities.Mode(nums));
        }
        {
            float[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0f / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new float[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new float[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new float[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new float[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new float[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new float[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));
        }

        {
            double[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0 / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new double[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new double[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new double[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new double[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new double[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new double[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));
        }

        {
            decimal[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0m / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new decimal[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new decimal[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new decimal[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5m, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new decimal[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new decimal[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new decimal[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));
        }

        { //make sure things explode properly
            int[] nums = { };

            Assert.Throws<FormatException>(() => ArrayUtilities.Average(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Max(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Min(nums));

            Assert.Throws<FormatException>(() => ArrayUtilities.Sum(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Product(nums));

            Assert.Throws<FormatException>(() => ArrayUtilities.Reverse(nums));

            Assert.Throws<FormatException>(() => ArrayUtilities.Median(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Mode(nums));
        }
    }


    [Fact]
    public void MathTests()
    {
        {
            Assert.Equal(243, MathUtilities.Power(3, 5));
            Assert.Equal(1.7320508100147274, MathUtilities.SquareRoot(3));
            Assert.Equal(5, MathUtilities.AbsoluteValue(-5));

            Assert.Equal(6, MathUtilities.Min(6, 9));
            Assert.Equal(9, MathUtilities.Max(6, 9));

            Assert.Equal(19, MathUtilities.Add(9, 10));
            Assert.Equal(-1, MathUtilities.Subtract(9, 10));
            Assert.Equal(90, MathUtilities.Multiply(9, 10));
            Assert.Equal(0, MathUtilities.Divide(9, 10));
            Assert.Equal(90, MathUtilities.Percentage(9, 10));

            Assert.Equal("1001", MathUtilities.Binary(9));

            Assert.Equal(100, MathUtilities.round(100.2));
            Assert.Equal(100, MathUtilities.Floor(100.2));
            Assert.Equal(101, MathUtilities.ceiling(100.2));
        }

        {
            Assert.Equal(243f, MathUtilities.Power(3f, 5));
            Assert.Equal(1.7320508100147274, MathUtilities.SquareRoot(3f));
            Assert.Equal(5f, MathUtilities.AbsoluteValue(-5f));

            Assert.Equal(6f, MathUtilities.Min(6f, 9f));
            Assert.Equal(9f, MathUtilities.Max(6f, 9f));

            Assert.Equal(19f, MathUtilities.Add(9f, 10f));
            Assert.Equal(-1f, MathUtilities.Subtract(9f, 10f));
            Assert.Equal(90f, MathUtilities.Multiply(9f, 10f));
            Assert.Equal(0.9f, MathUtilities.Divide(9f, 10f));
            Assert.Equal(90f, MathUtilities.Percentage(9f, 10f));

            Assert.Equal(100f, MathUtilities.round(100.2f));
            Assert.Equal(100f, MathUtilities.Floor(100.2f));
            Assert.Equal(101f, MathUtilities.ceiling(100.2f));
        }

        {
            Assert.Equal(243.0, MathUtilities.Power(3.0, 5.0));
            Assert.Equal(1.7320508100147274, MathUtilities.SquareRoot(3.0));
            Assert.Equal(5.0, MathUtilities.AbsoluteValue(-5.0));

            Assert.Equal(6.0, MathUtilities.Min(6.0, 9.0));
            Assert.Equal(9.0, MathUtilities.Max(6.0, 9.0));

            Assert.Equal(19.0, MathUtilities.Add(9.0, 10.0));
            Assert.Equal(-1.0, MathUtilities.Subtract(9.0, 10.0));
            Assert.Equal(90.0, MathUtilities.Multiply(9.0, 10.0));
            Assert.Equal(0.9, MathUtilities.Divide(9.0, 10.0));
            Assert.Equal(90.0, MathUtilities.Percentage(9.0, 10.0));

            Assert.Equal(100.0, MathUtilities.round(100.2));
            Assert.Equal(100.0, MathUtilities.Floor(100.2));
            Assert.Equal(101.0, MathUtilities.ceiling(100.2));
        }

        {
            Assert.Equal(243.0m, MathUtilities.Power(3.0m, 5.0m));
            Assert.Equal(1.732050810014727540500736377m, MathUtilities.SquareRoot(3.0m));
            Assert.Equal(5.0m, MathUtilities.AbsoluteValue(-5.0m));

            Assert.Equal(6.0m, MathUtilities.Min(6.0m, 9.0m));
            Assert.Equal(9.0m, MathUtilities.Max(6.0m, 9.0m));

            Assert.Equal(19.0m, MathUtilities.Add(9.0m, 10.0m));
            Assert.Equal(-1.0m, MathUtilities.Subtract(9.0m, 10.0m));
            Assert.Equal(90.0m, MathUtilities.Multiply(9.0m, 10.0m));
            Assert.Equal(0.9m, MathUtilities.Divide(9.0m, 10.0m));
            Assert.Equal(90.0m, MathUtilities.Percentage(9.0m, 10.0m));

            Assert.Equal(100.0m, MathUtilities.round(100.2m));
            Assert.Equal(100.0m, MathUtilities.Floor(100.2m));
            Assert.Equal(101.0m, MathUtilities.ceiling(100.2m));
        }
    }

    [Fact]
    public void StringTests()
    {
        string s = "Word123! .";
        char[] array = new char[] { 'W', 'o', 'r', 'd', '1', '2', '3', '!', ' ', '.' };
        Assert.Equal(array, StringUtilities.ToCharArray(s));
        Assert.Equal('C', StringUtilities.ToUpper('c'));
        Assert.Equal("WORD123! .", StringUtilities.ToUpper(s));
        Assert.Equal("word123! .", StringUtilities.ToLower(s));
        Assert.Equal(10, StringUtilities.Length(s));
        Assert.Equal("Word123! .", StringUtilities.ToStringArray(array));
        Assert.Equal(". !321droW", StringUtilities.reverse(s));
        Assert.Equal(1, StringUtilities.CountVowels(s));
        Assert.Equal(3, StringUtilities.CountConsonants(s));
        Assert.Equal(true, StringUtilities.HasLetter(s, 'w'));
        Assert.Equal(false, StringUtilities.HasLetter(s, 'p'));
        Assert.Equal("xpse123! .", StringUtilities.CaesarCipher(s, 1));
        Assert.Equal(false, StringUtilities.isUpper('c'));
        Assert.Equal(true, StringUtilities.isUpper('C'));
        Assert.Equal("WoRd123! .", StringUtilities.ToAlternatingCase(s));
        Assert.Equal(" ", StringUtilities.OnlySpace(s));
        Assert.Equal("Word123!.", StringUtilities.RemoveWhiteSpace(s));
        // Assert.Equal("", StringUtilities.RemoveWhiteSpace("         "));

    }
}