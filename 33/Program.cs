﻿string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(",");
Array.Sort(orders);

foreach (string order in orders)
{
  string error = "\t- Error";
  Console.WriteLine(order.Length == 4 ? order : order + error);
}
