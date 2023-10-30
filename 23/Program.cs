int heroHealth = 10;
int monsterHealth = 10;
Random attack = new Random();
int damage;

do
{
  damage = attack.Next(1, 11);
  monsterHealth -= damage;
  Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

  if (monsterHealth <= 0) continue;

  damage = attack.Next(1, 11);
  heroHealth -= damage;
  Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(monsterHealth <= 0 ? "Hero Wins!" : "Monster Wins!");