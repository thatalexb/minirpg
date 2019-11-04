using System;

namespace minirpg
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "MiniRPG";
            Intro();
            Session01();
            Session02();
        }
        public static void Intro()
        {
            Console.WriteLine("Welcome to MiniRPG!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("Your adventure will begin.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            
            
        }
        public static void Session01()
        {

            Random rnd = new Random();
            int keyPosX = rnd.Next(-2, 3);
            int keyPosY = rnd.Next(-2, 3);
            
            int xPos = 0;
            int yPos = 0;
            bool isWon = false;
            bool hasKey = false;
            Console.WriteLine("You may walk in any direction.");

            while (isWon == false)
            {
                if (xPos == keyPosX && yPos == keyPosY)
                {
                    if (hasKey == false)
                    {
                        Console.WriteLine("There is a key on the ground.");
                    }
                    else
                    {

                    }
                }
                
                

                string pos = xPos + ":" + yPos;

                switch (pos)
                {
                    case "-2:-2":
                        {
                            Console.WriteLine("-Master Bedroom-");
                        }
                        break;
                    case "-1:-2":
                        {
                            
                        }
                        break;
                    case "0:-2":
                        {

                        }
                        break;
                    case "1:-2":
                        {

                        }
                        break;
                    case "2:-2":
                        {

                        }
                        break;
                    case "-2:-1":
                        {

                        }
                        break;
                    case "-1:-1":
                        {

                        }
                        break;
                    case "0:-1":
                        {

                        }
                        break;
                    case "1:-1":
                        {

                        }
                        break;
                    case "2:-1":
                        {

                        }
                        break;
                    case "-2:0":
                        {

                        }
                        break;
                    case "-1:0":
                        {

                        }
                        break;
                    case "0:0":
                        {
                            Console.WriteLine("-Kitchen-");
                            Console.WriteLine("You are standing in the kitchen.");
                            Console.WriteLine("There is a door here.");
                        }
                        break;
                    case "1:0":
                        {

                        }
                        break;
                    case "2:0":
                        {

                        }
                        break;
                    case "-2:1":
                        {
                            Console.WriteLine("-Hallway-");
                        }
                        break;
                    case "-1:1":
                        {
                            Console.WriteLine("-Hallway-");
                        }
                        break;
                    case "0:1":
                        {
                            Console.WriteLine("-Hallway-");
                        }
                        break;
                    case "1:1":
                        {
                            Console.WriteLine("-Hallway-");
                        }
                        break;
                    case "2:1":
                        {
                            Console.WriteLine("-Hallway-");
                        }
                        break;
                    case "-2:2":
                        {

                        }
                        break;
                    case "-1:2":
                        {

                        }
                        break;
                    case "0:2":
                        {

                        }
                        break;
                    case "1:2":
                        {

                        }
                        break;
                    case "2:2":
                        {

                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
                
                string keyInput = Console.ReadLine().ToLower();
                switch (keyInput)
                {
                    case "n":
                        {

                            if (yPos < 2)
                            {
                                yPos++;
                                Console.WriteLine("You went north");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the north.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }

                        }
                        break;
                    case "s":
                        {
                            if (yPos > -2)
                            {
                                yPos--;
                                Console.WriteLine("You went south");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the south.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }

                        }
                        break;
                    case "e":
                        {
                            if (xPos < 2)
                            {
                                xPos++;
                                Console.WriteLine("You went east");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the east.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }

                        }
                        break;
                    case "w":
                        {
                            if (xPos > -2)
                            {
                                xPos--;
                                Console.WriteLine("You went west");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the west.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }

                        }
                        break;
                    case "h":
                        {
                            Console.WriteLine("To walk:");
                            Console.WriteLine("Enter 'n' for north");
                            Console.WriteLine("Enter 's' for south");
                            Console.WriteLine("Enter 'w' for west");
                            Console.WriteLine("Enter 'e' for east");
                            Console.WriteLine("-------------------");
                            Console.WriteLine("Interact:");
                            Console.WriteLine("Enter 'p' to pick up items.");
                            Console.WriteLine("Enter 'o' to open doors.");
                        }
                        break;
                    case "p":
                    case "pick":
                        {
                            if (xPos == keyPosX && yPos == keyPosY)
                            {
                                if (hasKey == false)
                                {
                                    Console.WriteLine("You reach for the key...");
                                    Console.WriteLine("The key is now in you inventory.");
                                    hasKey = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is nothing to pick up.");
                            }
                        }
                        break;
                    case "o":
                    case "open":
                        {
                            if (xPos == 0 && yPos == 0)
                            {
                                if (hasKey == true)
                                {
                                    Console.WriteLine("You unlocked and opened the door.");
                                    Console.WriteLine("There is a staircase leading to the basement.");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("The door is locked. Find a key first.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is nothing to open here.");
                            }
                        }
                        break;
                        
                    default:
                        {
                            Console.WriteLine("Invalid input, please try something else.");
                        }
                        break;
                }
            }
        }
        public static void Session02()
        {
            Console.WriteLine("BASEMENT");
            Console.WriteLine("-------------------");


        }

    }
}
