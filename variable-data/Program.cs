// Console.WriteLine("Signed integral types: ");

// Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("\nUnsigned integral types: ");

// Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("\nFloating point types:");
// Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue}");
// Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue}");
// Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");

// int[] data = new int[3];

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// int first = 5;
// int second = 7;

// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string first = "5";
// string second = "7";
// int sum = Convert.ToInt32(first) * Convert.ToInt32(second);
// Console.WriteLine(sum);

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

using System.Diagnostics;
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string message = "";
// decimal total = 0;

// foreach (var value in values)
// {
//     if (decimal.TryParse(value, out decimal fv)) total += fv;
//     else message += value;
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
// decimal result2 = value2 / Convert.ToDecimal(value3);
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
// float result3 = value3 / (float)value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"REsizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets) Console.WriteLine($"-- {pallet}");

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 .. count: {pallets.Length}");

// foreach (var pallet in pallets) Console.WriteLine($"-- {pallet}");

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items) Console.WriteLine(item);

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] chopped = pangram.Split(' ');

// for (int i = 0; i < chopped.Length; i++)
// {
//     char[] temp = chopped[i].ToArray();
    
//     Array.Reverse(temp);
    
//     chopped[i] = String.Join("", temp);
// }

// pangram = String.Join(" ", chopped);

// Console.WriteLine(pangram);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] chopped = orderStream.Split(',');

// Array.Sort(chopped);

// for (int i = 0; i < chopped.Length; i++)
// {
//     if (chopped[i].Length != 4) Console.WriteLine($"{chopped[i]}\t- Error");
//     else Console.WriteLine(chopped[i]);
// }


// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!");
// Console.WriteLine("{0} {0} {0}!", first, second);

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.789912m;
// Console.WriteLine($"Measurement: {measurement:N5} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P3}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price-salePrice)/price):P2}!";

// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"\tShares: {productShares:N3} Product");
// Console.WriteLine($"\t\tSub Total: {subtotal:C}");
// Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
// Console.WriteLine($"\t\tTotal Billed: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input.PadRight(40, '-'));

// Console.WriteLine("1234567890123456789012345678901234567890");

// string paymentID = "769C";

// var formattedLine = paymentID.PadRight(6);

// Console.Write(formattedLine);

// string payeeName = "Mr. Stephen Ortega";

// formattedLine = payeeName.PadRight(25);

// Console.Write(formattedLine);

// int price = 5000;

// formattedLine = $"{price:C}";

// Console.Write(formattedLine);

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here
// Console.WriteLine($"Dear {customerName}");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
// Console.WriteLine($"\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
// Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// // Your logic here

// comparisonMessage += currentProduct.PadRight(20);
// comparisonMessage += $"{currentReturn:P2}".PadRight(8);
// comparisonMessage += $"{currentProfit:C}".PadLeft(8);
// comparisonMessage += $"\n{newProduct}".PadRight(21);
// comparisonMessage += $"{newReturn:P2}".PadRight(8);
// comparisonMessage += $"{newProfit:C}".PadLeft(8);

// Console.WriteLine(comparisonMessage);

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// openingPosition++;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);
// Console.WriteLine(openingPosition);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;
    
//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     message = message.Substring(closingPosition + 1);
// }

// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using start position: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
    
//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int opening = input.IndexOf("<span>");
int closing = input.IndexOf("</span>");

opening += "<span>".Length;

int length = closing - opening;

quantity = $"Quantity: {input.Substring(opening, length)}";

output = input;

opening = output.IndexOf("<div>");
closing = output.IndexOf("</div>");

opening += "<div>".Length;

length = closing - opening;

output = output.Substring(opening, length);

output = output.Replace("&trade;", "&reg;");

output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);