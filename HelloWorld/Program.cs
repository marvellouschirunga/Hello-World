
            Console.Title = "C# Hello World";
            DisplayWelcomeMessage();
            
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Display 'Hello World'");
                Console.WriteLine("2. See a special message");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayHelloWorld();
                        break;
                    case "2":
                        ShowSpecialMessage();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Goodbye! Have a great day!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*         Welcome to my Hello World Program!    *");
            Console.WriteLine("*     Enjoy a fun twist on the classic 'Hello'   *");
            Console.WriteLine("**************************************************");
        }

        static void DisplayHelloWorld()
        {
            Console.Clear();
            string helloWorld = "Hello, World!";
            foreach (char c in helloWorld)
            {
                Console.Write(c);
                Thread.Sleep(100); // Adds a typewriter effect
            }
            Console.WriteLine();
        }

        static void ShowSpecialMessage()
        {
            Console.Clear();
            string[] specialMessage = {
                " Jesus Christ took upon Himself your sins, ",
                " your pains, your heartaches, and your infirmities.   ",
                " His infinite Atonement is for you!",
                "\nThis is a special message from President Nelson! Keep coding and stay creative!"
            };

            foreach (string line in specialMessage)
            {
                Console.WriteLine(line);
                Thread.Sleep(150); // Adds a typewriter effect
            }
        }