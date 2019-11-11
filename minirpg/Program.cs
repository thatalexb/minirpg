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
        }
        public static void Intro()
        {
            Console.WriteLine("Welcome to MiniRPG!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("Your adventure will soon begin.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();


        }
        public static void Session01()
        {

            Random rnd = new Random();

            // Integers

            int keyPosX = rnd.Next(-2, 3);
            int keyPosY = rnd.Next(-2, 3);

            int xPos = 0;
            int yPos = 0;

            int calcKeyPos = rnd.Next(1, 11);



            // Booleans

            bool won = false;
            bool hasKey = false;
            bool keyInBoxes = false;


            if (calcKeyPos < 6)
            {
                keyInBoxes = true;
            }
            else
            {
                keyInBoxes = false;
            }

            Console.WriteLine("You find yourself in a house.");
            Console.WriteLine("All doors and windows are locked.");
            Console.WriteLine("The only way out is through the door leading down to the basement in the kitchen.");
            Console.WriteLine("Find the key and get out of here.");
            Console.WriteLine("--------------------------------------------------------------");

            while (won == false)
            {


                string pos = xPos + ":" + yPos;




                switch (pos)
                {
                    case "-2:-2":
                        {
                            Console.WriteLine("-Master Bedroom-");
                            Console.WriteLine("It is very messy in here...");
                        }
                        break;
                    case "-1:-2":
                        {
                            Console.WriteLine("-Master Bedroom-");
                            Console.WriteLine("It is very messy in here...");
                            Console.WriteLine("The Hallway is to the east.");
                        }
                        break;
                    case "0:-2":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("The Master Bedroom is to the west.");
                            Console.WriteLine("The Storage Room is to the east.");
                        }
                        break;
                    case "1:-2":
                        {
                            Console.WriteLine("-Storage Room-");
                            Console.WriteLine("There is a lot of boxes in here.");
                            Console.WriteLine("The Hallway is to the west.");
                        }
                        break;
                    case "2:-2":
                        {
                            Console.WriteLine("-Storage Room-");
                            Console.WriteLine("There is a lot of boxes in here.");
                        }
                        break;
                    case "-2:-1":
                        {
                            Console.WriteLine("-Master Bedroom-");
                            Console.WriteLine("It is very messy in here...");
                            Console.WriteLine("The Hallway is to the north.");
                        }
                        break;
                    case "-1:-1":
                        {
                            Console.WriteLine("-Master Bedroom-");
                            Console.WriteLine("It is very messy in here...");
                            Console.WriteLine("The Hallway is to the north and to the east.");
                        }
                        break;
                    case "0:-1":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("The Kitchen is to the north.");
                            Console.WriteLine("The Master Bedroom is to the west.");
                            Console.WriteLine("The Storage Room is to the east.");

                        }
                        break;
                    case "1:-1":
                        {
                            Console.WriteLine("-Storage Room-");
                            Console.WriteLine("There is a lot of boxes in here.");
                            Console.WriteLine("The Hallway is to the west and to the north.");
                        }
                        break;
                    case "2:-1":
                        {
                            Console.WriteLine("-Storage Room-");
                            Console.WriteLine("There is a lot of boxes in here.");
                            Console.WriteLine("The Hallway is to the north.");
                        }
                        break;
                    case "-2:0":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Master Bedroom is to the south.");
                        }
                        break;
                    case "-1:0":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Master Bedroom is to the south.");
                            Console.WriteLine("The Kitchen is to the east.");
                        }
                        break;
                    case "0:0":
                        {
                            Console.WriteLine("-Kitchen-");
                            Console.WriteLine("This is the center of the house. Walk in any direction");
                            Console.WriteLine("to find the Hallway.");
                            Console.WriteLine("There is a door in here.");
                        }
                        break;
                    case "1:0":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Kitchen is to the west.");
                            Console.WriteLine("The Storage Room is to the south.");
                        }
                        break;
                    case "2:0":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Storage Room is to the south.");
                        }
                        break;
                    case "-2:1":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Bathroom is to the north.");
                        }
                        break;
                    case "-1:1":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Bathroom is to the north.");
                        }
                        break;
                    case "0:1":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Kitchen is to the south.");
                        }
                        break;
                    case "1:1":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Office is to the north.");

                        }
                        break;
                    case "2:1":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("There is a lot of paintings in here. Useless...");
                            Console.WriteLine("The Office is to the north.");
                        }
                        break;
                    case "-2:2":
                        {
                            Console.WriteLine("-Bathroom-");
                            Console.WriteLine("It smells horrible in here...");
                            Console.WriteLine("The Hallway is to the south.");
                        }
                        break;
                    case "-1:2":
                        {
                            Console.WriteLine("-Bathroom-");
                            Console.WriteLine("It smells horrible in here...");
                            Console.WriteLine("The Hallway is to the south and to the east.");
                        }
                        break;
                    case "0:2":
                        {
                            Console.WriteLine("-Hallway-");
                            Console.WriteLine("The Bathroom is to the west.");
                            Console.WriteLine("The Office is to the east.");
                        }
                        break;
                    case "1:2":
                        {
                            Console.WriteLine("-Office-");
                            Console.WriteLine("There is a lot of cabinets in here.");
                            Console.WriteLine("The Hallway is the the west and to the south.");
                        }
                        break;
                    case "2:2":
                        {
                            Console.WriteLine("-Office-");
                            Console.WriteLine("There is a lot of binders and files in here.");
                            Console.WriteLine("The Hallway is to the south.\n");
                            Console.WriteLine("A strange voice whispers:");
                            Console.WriteLine("'Hello there.'");
                            Console.WriteLine("What are you looking for?");
                            string answer = Console.ReadLine().ToLower();
                            switch (answer)
                            {
                                case "key":
                                case "a key":
                                case "the key":
                                case "keys":
                                    {
                                        Console.WriteLine("'I see...'");
                                        if (keyInBoxes == true)
                                        {
                                            Console.WriteLine("'I have stayed in this office for so long.'");
                                            Console.WriteLine("'You may need to search some boxes.'");
                                            Console.WriteLine("'Try the storage room.'");
                                        }
                                        else
                                        {
                                            Console.WriteLine("'I wish I could help but I can't.'");
                                            Console.WriteLine("'It is somewhere in the house though.'");                                        }
                                    }
                                    break;
                                default:
                                    {
                                        Console.WriteLine("I don't know what that is. Sorry.");
                                    }
                                    break;
                            }

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
                            Console.WriteLine("");

                            if (yPos < 2)
                            {

                                yPos++;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("You went north");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the north.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case "s":
                        {
                            Console.WriteLine("");

                            if (yPos > -2)
                            {
                                yPos--;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("You went south");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the south.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case "e":
                        {
                            Console.WriteLine("");

                            if (xPos < 2)
                            {
                                xPos++;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("You went east");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the east.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case "w":
                        {
                            Console.WriteLine("");

                            if (xPos > -2)
                            {
                                xPos--;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("You went west");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            else
                            {
                                Console.WriteLine("You can't walk any further to the west.");
                                Console.WriteLine("Coordinates: " + xPos + ", " + yPos);
                            }
                            Console.WriteLine("");
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
                                else
                                {
                                    Console.WriteLine("There is nothing to pick up.");
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
                            switch (pos)
                            {
                                case "1:-1":
                                case "2:-1":
                                case "1:-2":
                                case "2:-2":
                                    {
                                        if (hasKey == false)
                                        { 
                                            if (keyInBoxes == true)
                                            {
                                                Console.WriteLine("You searched the boxes and found the key.");
                                                hasKey = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("There is nothing in the boxes...");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is nothing in the boxes...");
                                        }
                                    }
                                    break;
                                case "0:0":
                                    {
                                        if (hasKey == true)
                                        {
                                            Console.WriteLine("You unlocked and opened the door.");
                                            Console.WriteLine("There is a staircase leading to the basement.");
                                            Console.WriteLine("Press any key to continue.");
                                            Console.ReadLine();
                                            Win();
                                        }
                                        else
                                        {
                                            Console.WriteLine("The door is locked. Find a key first.");
                                        }
                                    }
                                    break;
                                default:
                                    {
                                        Console.WriteLine("There is nothing to open here");
                                    }
                                    break;
                            }


                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid input, please try something else.");
                        }
                        break;
                }
                if (xPos == keyPosX && yPos == keyPosY)
                {
                    if (keyInBoxes == false)
                    {
                        if (hasKey == false)
                        {

                            Console.WriteLine("\nThere is a key on the ground.\n");

                        }
                    }


                }
            }
        }
        public static void Win()
        {
            Console.WriteLine("Congratulations! You won the game.");
            System.Environment.Exit(0);
        }


    }
}
