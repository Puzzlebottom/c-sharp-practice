Random coin = new Random();
string toss = coin.Next(2) == 0 ? "heads" : "tails";
Console.WriteLine(toss);