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

### ArrayUtilities

`double Average(int[] nums)`

Finds the average of an array of integers, where nums is the set of integers to return an average from.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Average({3, 5})` returns 4

Overloads: float, double, decimal


`int Max(int[] nums)`

Finds the greatest integer in an array, where nums is the set of integers to return a maximum from.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Max({2, 7})` returns 7

Overloads: float, double, decimal


`int Min(int[] nums)`

Finds the least integer in an array, where nums is the set of integers to return a minimum from.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Min({3, 5, 7})` returns 3

Overloads: float, double, decimal


`int[] SortAscending(int[] nums)`

Sorts an array of integers from least to greatest, where nums is the set of integers to sort.

Example: `ArrayUtilities.SortAscending({1, 5, 2})` returns {1, 2, 5}

Overloads: float, double, decimal


`int[] SortDescending(int[] nums)`

Sorts an array of integers from greatest to least, where nums is the set of integers to sort.

Example: `ArrayUtilities.SortDescending({1, 5, 2})` returns {5, 2, 1}

Overloads: float, double, decimal


`int Sum(int[] nums)`

Finds the sum of all of the integers in an array, where nums is the set of integers to add.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Sum({3, 5, 7})` returns 15

Overloads: float, double, decimal


`int Product(int[] nums)`

Finds the product of all of the integers in an array, where nums is the set of integers to multiply.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Product({3, 5, 7})` returns 105

Overloads: float, double, decimal


`int[] Reverse(int[] nums)`

Reverses the order of the elements in an array of integers, where nums is the set of integers to reverse.
Throws a FormatException if the provided array has no elements.
*Note:* Does not affect the provided array, instead returns a shallow copy with the reversed order.

Example: `ArrayUtilities.SortDescending({4, 3, 7})` returns {7, 3, 4}

Overloads: float, double, decimal


`double Median(int[] nums)`

Finds the median of a set of integers, where nums is the set of integers to find the median of.
If the provided array has an even length, the average of the two middle numbers is calculated.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Median({3, 5, 7})` returns 5

Overloads: float, double, decimal


`int Mode(int[] nums)`

Finds the mode of a set of integers, where nums is the set of integers to find the mode of.
If the provided array has no mode, this method throws an Exception.
Throws a FormatException if the provided array has no elements.

Example: `ArrayUtilities.Mode({3, 5, 7, 5})` returns 5

Overloads: float, double, decimal


`int[] AddToAll(int[] x, int y)`

Adds a specified value to all of the values in an array of integers, where x is the set of integers to apply the operation to. y is the integer added to each value in the array.

Example: `ArrayUtilities.AddToAll({3, 5, 7}, 3)` returns {6, 8, 10}

Overloads: float, double, decimal


`int[] Append(int[] x, int y)`

Appends an element to an array of integers, where x is the array to append to, and y is the value to append to the array.
*Note:* Does not affect the provided array, instead returns a copy with the appended element.

Example: `ArrayUtilities.Append({3, 5, 7}, 3)` returns {3, 5, 7, 3}

Overloads: float, double, decimal


`int[] Remove(int[] x, int y)`

Removes an element at a specified index from an array of integers, where x is the array to remove from, and y is the index of the value to be removed from the array.
*Note:* Does not affect the provided array, instead returns a copy with the removed element.

Example: `ArrayUtilities.Remove({3, 5, 7}, 1)` returns {3, 7}

Overloads: float, double, decimal


`bool Contains(int[] x, int y)`

Determines if an array of integers contains a specified value, where x is the array to check, and y is the value to check for.

Example: `ArrayUtilities.Contains({3, 5, 7}, 3)` returns true

Overloads: float, double, decimal


`int IndexOf(int[] x, int y)`

Finds the first occurrence of a value in a given array of integers, where x is the array to check, and y is the value to check for. If the provided value has no occurrences in the array, this method returns -1.

Example: `ArrayUtilities.IndexOf({3, 5, 7}, 3)` returns 0

Overloads: float, double, decimal


`int HowMany(int[] x, int y)`

Finds the number of occurrences of a value in a given array of integers, where x is the array to check, and y is the value to check for.

Example: `ArrayUtilities.HowMany({3, 5, 7, 3}, 3)` returns 2

Overloads: float, double, decimal


### MathUtilities

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


**StringUtilities**
`string ToUpper(string s)`
Changes each letter to be capitalized.
Example: `StringUtilities.ToUpper('c')` returns 'C'

Overloads: char

`string ToLower(string s)`
Changes each letter to be un-capitalized.
Example: `StringUtilities.ToLower("word123! .")` returns "word123! ."

`int Length(string s)`
Finds length of a string.
Example: `StringUtilities.Length("word123! .")` returns 10

`char[] ToCharArray(string s)`
Converts string to character array.
Example: `StringUtilities.ToCharArray("Word123! .")` returns { 'W', 'o', 'r', 'd', '1', '2', '3', '!', ' ', '.' }

`string ToStringArray(char[] characters)`
Converts Char[] to a string.
Example: `StringUtilities.ToStringArray({ 'W', 'o', 'r', 'd', '1', '2', '3', '!', ' ', '.' })` returns "Word123! ."

`string reverse(string s)`
Reverses string.
Example: `StringUtilities.reverse(s)` returns ". !321droW"

`int CountVowels(string s)`
Counts the number of vowels in a string.
Example: `StringUtilities.CountVowels("word123! .")` returns 1

`int CountConsonants(string s)`
Counts every non-vowel (consonant) in a string
Example: `StringUtilities.CountConsonants("word123! .")` returns 3

`bool HasLetter(string s, char c)`
Finds specified letter in a given string.
Example: `StringUtilities.HasLetter("word123! .", 'w')` returns true

`string CaesarCipher(string s, int arrange)`
Moves each letter through the alphabet by the given amount.
Example: `StringUtilities.CaesarCipher("word123! .", 1)` returns "xpse123! ."

`bool isUpper(char c)`
Determines if a character is uppercase.
Example: `StringUtilities.isUpper('c')` returns false

`string ToAlternatingCase(string s)`
Alternates each letter as capitalized and uncapitalized.
Example: `StringUtilities.ToAlternatingCase("word123! .")` returns "WoRd123! ."

`string OnlySpace(string s)`
Takes out anything that is not a space/ whitespace.
Example: `StringUtilities.OnlySpace("word123! .")` returns " "

`string RemoveWhiteSpace(string s)`
Removes any spaces from a string.
Example: `StringUtilities.RemoveWhiteSpace("word123! .")` returns "Word123!."

## Legal

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Have fun! :)