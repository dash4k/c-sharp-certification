/*
    The point of this program is to reverse a message and counts
    how many of the letter 'o' is appears in the message
*/
string message = "The quick brown fox jumps over the lazy dog.";

char[] messageChar = message.ToCharArray();
Array.Reverse(messageChar);

int oCounts = 0;

foreach (char character in messageChar) 
{ 
    if (character == 'o') 
    { 
        oCounts++; 
    }
}

string new_message = new String(messageChar);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {oCounts} times.");