// Code project 1

// string? readResult;
// int userValue = 0;
// bool validEntry = false;
// Console.WriteLine("Enter an integer value between 5 and 10: ");

// while (!validEntry)
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (int.TryParse(readResult, out userValue))
//         {
//             if (userValue > 4 && userValue < 11)
//             {
//                 validEntry = true;
//             }
//             else
//             {
//                 Console.WriteLine($"You entered {userValue}. Please enter a number between 5 and 10.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Sorry, you entered an invalid number, please try again.");
//         }
//     }
// }
// Console.WriteLine($"Your input value ({userValue}) has been accepted.");



// Code project 2
// string? readResult;
// bool validEntry = false;
// string role = "";

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// while (!validEntry)
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         switch (readResult.Trim().ToLower())
//         {
//             case "administrator":
//                 role = "Administrator";
//                 validEntry = true;
//                 break;
//             case "manager":
//                 role = "Manager";
//                 validEntry = true;
//                 break;
//             case "user":
//                 role = "User";
//                 validEntry = true;
//                 break;
//             default:
//                 Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//                 break;
//         }
//     }
// }

// Console.WriteLine($"Your input value ({role}) has been accepted.");

// Code project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string currentString, currentSentence;
int currentPeriodLocation;

for (int i = 0; i < myStrings.Length; i++)
{
    currentString = myStrings[i];
    currentPeriodLocation = currentString.IndexOf(".");
    while (currentPeriodLocation != -1)
    {
        currentSentence = currentString.Remove(currentPeriodLocation);
        currentString = currentString.Substring(currentPeriodLocation + 1);
        currentString = currentString.TrimStart();
        currentPeriodLocation = currentString.IndexOf(".");
        Console.WriteLine(currentSentence);
    }
    currentSentence = currentString.Trim();
    Console.WriteLine(currentSentence);
}