// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);

// Console.WriteLine(result);
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted

// Console.WriteLine(yourDiscount);

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"   Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
