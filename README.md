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
