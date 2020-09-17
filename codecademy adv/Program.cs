using System;

namespace codecademy_adv
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string noiseChoice, riddleAnswer;
            bool moveOn = false;
            //Ran into errors when not assigning blank value
            string doorChoice = "";
            string cabinRiddleAnswer = "";

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //Pet Class Creation
            Pet userPet = new Pet();
            Console.WriteLine("Before we begin, describe your favorite kind of pet. First with what it is.");
            Console.Write("Type your favorite pet: ");
            userPet.type = Console.ReadLine();
            Console.WriteLine($"What color would that {userPet.type} be?");
            Console.Write("Type a color: ");
            userPet.color = Console.ReadLine();
            Console.WriteLine("Finally, how big or smol is it?");
            Console.Write("Type a size: ");
            userPet.size = Console.ReadLine();


            Console.WriteLine("It begins on a old rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();

            //All these if statements are so messy
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!\nTHE END");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
                Console.Write("Type OPEN or KNOCK: ");
                doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();
            }

            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \nPoor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
                riddleAnswer = Console.ReadLine();
                riddleAnswer = riddleAnswer.ToUpper();

                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and nothing is there. You turn off the light and run back to your room and lock the door.");
                    moveOn = true;
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END");
                }
            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                int keyChoice = rand.Next(1, 4);

                switch (keyChoice)
                {
                    case 1:
                        Console.WriteLine("You choose the first key. Lucky choice! The door opens and nothing is there. Strange. . .\nTHE END");
                        break;
                    case 2:
                        Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END");
                        break;
                    case 3:
                        Console.WriteLine($"You choose the third key. The door doesn't open.\nTHE END");
                        break;
                }
            }

            //Used to separate between codecademy and new code
            //Also bc the code I wrote in codecademy is messy
            if (!moveOn)
            {
                return;
            }

            Console.WriteLine("As you sit back on your bed, you hear a knock your door. Do you answer the door?");
            Console.Write("Type IGNORE or ANSWER: ");
            string doorAnswer = Console.ReadLine();
            doorAnswer = doorAnswer.ToUpper();

            if (doorAnswer == "IGNORE")
            {
                Console.WriteLine("You ignore the door and try to go to bed.\nTHE END");
                return;
            }
            else if (doorAnswer == "ANSWER")
            {
                Console.WriteLine("You go to open the door but it's suddenly locked from the other side. Again you hear a voice say \"Answer this riddle: \nYou are walking through a forest and you suddenly hear a loud explosion-like sound. When you investigate you see a man dead in a cabin. How did he die?\"");
                Console.Write("Type your answer: ");
                cabinRiddleAnswer = Console.ReadLine();
                cabinRiddleAnswer = cabinRiddleAnswer.ToUpper();
            }

            if (cabinRiddleAnswer == "PLANE CRASH")
            {
                Colors(userPet.color);
                Console.WriteLine($"\"Correct\" says the voice. You go to open the door. Behind the door is a {userPet.size}, {userPet.color} {userPet.type}.\nTHE END");
                return;
            }
            else
            {
                Console.WriteLine("\"Wrong\" says the voice behind the door. Just then, you hear what you think is the sound of a plane. Looking out your window, you only have time to realize it's crashing into your house.\nTHE END");
                return;
            }


        }

        static void Colors(string petColor)
        {
            petColor = petColor.ToLower();

            switch (petColor)
            {
                case "black":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "dark blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dark green":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "dark cyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "dark red":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark magenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "dark yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "dark gray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
        }
    }
}