using MathUtils; //ignore this lol i was using this for debuggging
using ArrayUtils;
using StringUtils;

namespace guh;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 1, 2, -1, 2, 3};
        int[] x = ArrayUtilities.SortAscending(nums);
        Console.WriteLine(ArrayUtilities.Median(nums));

        Console.WriteLine(StringUtilities.CaesarCipher("among us joke", 1)); //hi
    }
}