string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");

for (int i = 0; i < words.Length; i++)
{
  char[] chars = words[i].ToCharArray();
  Array.Reverse(chars);
  words[i] = new string(chars);
}

Console.WriteLine(String.Join(" ", words));