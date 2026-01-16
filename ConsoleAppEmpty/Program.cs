using GameEnums;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");
        Console.WriteLine("Hello world");

           
        Console.WriteLine("Changed it , hurray!!");
        int a = 5;
        int b = 10;
        int result = a + b;

        Console.WriteLine("Five plus 10 is " + result);


        Console.WriteLine("Please select a difficulty");
        Console.WriteLine("1.Easy");
        Console.WriteLine("2.Medium");
        Console.WriteLine("3.Hard");

        int userInput = int.Parse(Console.ReadLine());

        switch ((GameDifficulty)userInput)
        {
            case GameDifficulty.Easy:
                Console.WriteLine("Game difficulty set to easy");
                break;

            case GameDifficulty.Medium:
                Console.WriteLine("Game difficulty set to medium");
                break;

            case GameDifficulty.Hard:
                Console.WriteLine("Game difficulty set to hard");
                break;
        }


        Console.WriteLine("Please select a character class");
        Console.WriteLine("1.Warrior");
        Console.WriteLine("2.Mague");
        Console.WriteLine("3.Rogue");

        int userInput2 = int.Parse(Console.ReadLine());

        switch ((CharacterClass)userInput2)
        {
            case CharacterClass.Warrior:
                Console.WriteLine("You class is warrior");
                break;

            case CharacterClass.Mage:
                Console.WriteLine("You class is Mage");
                break;

            case CharacterClass.Rogue:
                Console.WriteLine("You class Rogue");
                break;
        }
         Console.WriteLine(" ");
        GameDifficulty info = (GameDifficulty)userInput;
        CharacterClass info2 = (CharacterClass)userInput2;

        Console.WriteLine("You selected:");
        Console.WriteLine(" ");
        Console.WriteLine("Difficulty: " + info);
        Console.WriteLine("Character Class: " + info2);

    }
}