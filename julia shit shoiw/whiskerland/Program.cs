using System;

namespace WhiskerlandAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            Console.WriteLine("Welcome to Whiskerland!");
            Console.WriteLine("You are Midnight, a brave hero tasked with saving this land.");
            Console.WriteLine("Whiskerland needs you now.");

            // Start first choice
            Console.WriteLine("\nThe mouse tells you that you can choose to go to:");
            Console.WriteLine("1. Kitty Corner Forest");
            Console.WriteLine("2. The Town of Whiskerland");
            Console.Write("Where would you like to go? (1/2): ");
            string choice1 = Console.ReadLine();

            if (choice1 == "1")
            {
                GoToForest();
            }
            else if (choice1 == "2")
            {
                GoToTown();
            }
            else
            {
                Console.WriteLine("Invalid choice. The story ends here.");
            }
        }

        static void GoToForest()
        {
            Console.WriteLine("\nYou have chosen to go to the Kitty Corner Forest.");
            Console.WriteLine("On your way, you meet a lurking cat who tells you a piece of the Cat Eye Orb is up the tallest tree.");
            Console.WriteLine("You can either:");
            Console.WriteLine("1. Climb the tree right away.");
            Console.WriteLine("2. Go to the puzzle plant to gain climbing abilities.");
            Console.Write("What would you like to do? (1/2): ");
            string forestChoice = Console.ReadLine();

            if (forestChoice == "1")
            {
                ClimbTree();
            }
            else if (forestChoice == "2")
            {
                GoToPuzzlePlant();
            }
            else
            {
                Console.WriteLine("Invalid choice. The story ends here.");
            }
        }

        static void GoToPuzzlePlant()
        {
            Console.WriteLine("\nYou encounter a talking tree that gives you a riddle:");
            Console.WriteLine("\"I have no legs, but I can take you high. My body is steep, and you'll reach the top step by step. But if you fall, it's a sudden drop. What am I?\"");
            Console.WriteLine("Your options are:");
            Console.WriteLine("1. Ladder");
            Console.WriteLine("2. Staircase");
            Console.WriteLine("3. Rope");
            Console.WriteLine("4. Mountain");
            Console.Write("Your answer: ");
            string riddleAnswer = Console.ReadLine();

            if (riddleAnswer.ToLower() == "ladder")
            {
                Console.WriteLine("Correct! The tree gives you a ladder to climb the tallest tree.");
                ClimbTreeWithLadder();
            }
            else
            {
                Console.WriteLine("Wrong answer. You fall and the adventure ends here.");
            }
        }

        static void ClimbTreeWithLadder()
        {
            Console.WriteLine("\nYou use the ladder to climb the tallest tree and find the first piece of the Cat Eye Orb!");
            Console.WriteLine("Congratulations, you have succeeded in the forest adventure.");
        }

        static void ClimbTree()
        {
            Console.WriteLine("\nYou attempt to climb the tree, but it is too dangerous. You fall and the adventure ends here.");
        }

        static void GoToTown()
        {
            Console.WriteLine("\nYou have chosen to go to the Town of Whiskerland.");
            Console.WriteLine("You encounter Miss Beaver who asks for help in fixing her family's dam.");
            Console.WriteLine("You can either:");
            Console.WriteLine("1. Help fix the dam first.");
            Console.WriteLine("2. Look for the orb in the pond immediately.");
            Console.Write("What would you like to do? (1/2): ");
            string townChoice = Console.ReadLine();

            if (townChoice == "1")
            {
                HelpFixDam();
            }
            else if (townChoice == "2")
            {
                LookForOrbInPond();
            }
            else
            {
                Console.WriteLine("Invalid choice. The story ends here.");
            }
        }

        static void HelpFixDam()
        {
            Console.WriteLine("\nYou help Miss Beaver fix the dam. In gratitude, she shows you the orb piece in the pond.");
            Console.WriteLine("Congratulations, you have succeeded in the town adventure and found the second piece of the Cat Eye Orb.");
        }

        static void LookForOrbInPond()
        {
            Console.WriteLine("\nYou search for the orb in the pond, but the dam breaks, and the orb is washed away.");
            Console.WriteLine("The beavers angrily send you away. The adventure ends here.");
        }
    }
}
