/*
This code reverses a string and counts the number of times a particular character appears
*/
string message = "The quick brown fox jumps over the lazy dog.";
char letterToCount = 'o';

char[] letters = message.ToCharArray();
int letterCount = 0;

foreach (char letter in letters)
{
  if (letter == letterToCount)
  {
    letterCount++;
  }
}

Array.Reverse(letters);

Console.WriteLine(letters);
Console.WriteLine($"'{letterToCount}' appears {letterCount} times.");