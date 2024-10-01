Random randomNumberGenerator = new Random();


//int knightHealth = randomNumberGenerator.Next(1, 101);
int knightHealth;
int goblinHealth = randomNumberGenerator.Next(1, 101);
string input;
int attackKnight = randomNumberGenerator.Next(1,21);
int attackGoblin = randomNumberGenerator.Next(1, 11);
int heal = randomNumberGenerator.Next(5, 16);


Console.Write("Geef de levenspunten van de ridder in: ");
input = Console.ReadLine();
bool isValidNumber = int.TryParse(input, out knightHealth);
if (isValidNumber == true) {

    if(knightHealth <=0 || knightHealth >100)
    {
        Console.WriteLine("Invalid input, default 100 is used");
    }
}

else
{
    Console.WriteLine("Invalid input, default 100 is used.");
        knightHealth = 100;
}

Console.WriteLine($"Knight health = {knightHealth}");
Console.WriteLine($"Goblin health = {goblinHealth}");

Console.WriteLine("Choose an action: ");
Console.WriteLine("1. Attack");
Console.WriteLine("2. Heal");
Console.Write("Please select an action: ");
string action = Console.ReadLine();

switch(action)
{
    case "1": goblinHealth -= attackKnight;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"You dealt {attackKnight} damage to the goblin");
        Console.ResetColor();
        break;

    case "2": knightHealth =+ 10;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"You healed {heal} hitpoints.");
        Console.ResetColor();
        break;
    default:
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine("Invalid input");
        Console.ResetColor();
        break;
}

if (goblinHealth > 0) ;
{
    knightHealth -= attackKnight;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"You were attacked by the goblin for {attackGoblin} damage");
    Console.ResetColor();
}

if (knightHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You died");
    Console.ResetColor();
}
else
{
    Console.WriteLine($"Knight health: {knightHealth}");
}

if (goblinHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Enemy slayed");
    Console.ResetColor();
}
else
{
    Console.WriteLine($"Goblin health: {goblinHealth}");
}


/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
