// Exercise 1

string? readResult;
int parsedInteger = 0;
bool validInteger = false;

Console.WriteLine("Enter an integer value between 5 and 10.");

do
{
  readResult = Console.ReadLine();
  validInteger = int.TryParse(readResult, out parsedInteger);

  if (!validInteger)
    Console.WriteLine("Sorry, you entered an invalid number, please try again.");
  else if (parsedInteger < 5 || parsedInteger > 10)
    Console.WriteLine($"You entered {parsedInteger}. Please enter a number between 5 and 10.");

} while (!validInteger || parsedInteger < 5 || parsedInteger > 10);

Console.WriteLine($"Your input value ({parsedInteger}) has been accepted.");

// Exercise 2

bool validRole = false;
string query = "Enter your role name (Administrator, Manager, or User)";

Console.WriteLine(query);

do
{
  readResult = Console.ReadLine();
  string role = readResult.Trim().ToLower();
  validRole = role == "administrator" || role == "manager" || role == "user";

  if (!validRole)
    Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. {query}");

} while (!validRole);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");

// Exercise 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
  string myString = myStrings[i];
  int periodLocation = myString.IndexOf(".");

  while (periodLocation != -1)
  {
    Console.WriteLine(myString.Remove(periodLocation));

    myString = myString.Substring(periodLocation + 1).TrimStart();

    periodLocation = myString.IndexOf(".");
  }

  Console.WriteLine(myString.Trim());
}