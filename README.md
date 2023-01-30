# Wheel 2: Electric Boogaloo
## It's like your wheel, but better! Why? Because we said so!

**What it is:** A package of rudimentary functions for use with arrays, strings, and for general mathematical purposes. Reimplements some of the functionality from derivatives of the System namespace, but adds a couple bells and whistles here and there.

**Why:** Partially to demonstrate understanding of the inner workings of functions we use on a daily basis, that otherwise would have been paid no attention. Also, some of these are really useful to have. Appending to arrays, floor and ceiling operations for fractions, checking character cases, et cetera.

**The how:** This library comes in 3 namespaces: `MathUtils`, `StringUtils`, and `ArrayUtils`. Simply include the namespace(s) of your choosing in a file. Next, to use a function, prefix it with `xUtilities`, where x is the desired type of function, followed by the actual function name. For instance:

`string funnyJoke = StringUtilities.CaesarCipher("hdnozm wzzzzzvno!!!", 5);`

`int[] Top10NumbersOfAllTime = ArrayUtilities.Append(Top9NumbersOfAllTime, 4);`

`int ResultOfExtremelyImportantCalculation = MathUtilities.Add(2, 2);`

It's that easy!


## Documentation

**ArrayUtilities**

`double Average(int[] nums)`
Finds the average of an array of integers, where nums is the set of integers to return an average from.
Throws a FormatException if the provided array has no elements.

Overloads: float, double, decimal

`int Max(int[] nums)`
Finds the greatest integer in an array, where nums is the set of integers to return a maximum from.
Throws a FormatException if the provided array has no elements.

Overloads: float, double, decimal

**MathUtilities**

`int Power(int b, int e)`
Finds the result of an integer raised to a power.
Returns: b raised to the power of e.

Example: `MathUtilities.Power(3, 5)` returns 243

Overloads: float, double, decimal


`double SquareRoot(int b)`
Finds the square root of a number.

Example: `MathUtilities.SquareRoot(3)` returns 1.73205080757

Overloads: float, double, decimal

`int AbsoluteValue(int x)`
Finds the absolute value of a number.

Example: `MathUtilities.AbsoluteValue(-5)` returns 5

Overloads: float, double, decimal

`int Min(int x, int y)`
Finds the least of two integers.

Example: `MathUtilities.Min(6, 9)` returns 6

Overloads: float, double, decimal

`int Max(int x, int y)`
Finds the greatest of two integers.

Example: `MathUtilities.Min(6, 9)` returns 9

Overloads: float, double, decimal

`int Add(int x, int y)`
Calculates the sum of two decimals.

Example: `MathUtilities.Add(9, 10)` returns 19

Overloads: float, double, decimal

`int Subtract(int x, int y)`
Calculates the difference of two integers.

Example: `MathUtilities.Subtract(9, 10)` returns -1

Overloads: float, double, decimal

`int Multiply(int x, int y)`
Calculates the product of two doubles.

Example: `MathUtilities.Multiply(9, 10)` returns 90

Overloads: float, double, decimal

`int Divide(int x, int y)`
Calculates the quotient of two doubles.

Example: `MathUtilities.Divide(9, 10)` returns 0

Overloads: float, double, decimal

`int Percentage(int value, int total)`
Calculates the percentage of two numbers.
returns: The percentage of total represented by value.

Example: `MathUtilities.Percentage(9, 10)` returns 90

Overloads: float, double, decimal

`string Binary(int x)`
Calculates the binary representation of an integer.
returns: A string representing the number in binary.

Example: `MathUtilities.Binary(9)` returns 1001

No overloads

`int Floor(double x)`
Rounds down a provided value to the nearest integer.

Example: `MathUtilities.Floor(100.2)` returns 100

Overloads: float, double, decimal

`int ceiling(double x)`
Rounds up a provided value to the nearest integer.

Example: `MathUtilities.ceiling(100.2)` returns 101

Overloads: float, double, decimal

`int round(double x)`
Rounds a provided value to the nearest integer.

Example: `MathUtilities.round(100.2)` returns 100

Overloads: float, double, decimal

