string permission = "Admin|Manager";
int level = 55;


bool isAdmin = permission.Contains("Admin");
bool isManager = permission.Contains("Manager");
string super = level > 55 ? "Super " : " ";

if (level < 20 || (!isAdmin && !isManager))
  Console.WriteLine("You do not have sufficient privileges.");
else if (isAdmin)
  Console.WriteLine($"Welcome,{super}Admin user.");
else if (isManager)
  Console.WriteLine("Contact an Admin for access.");