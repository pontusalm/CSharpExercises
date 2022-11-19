namespace Ovn4
{
    /* övn1.
 * 1_2: När femte elementet läggs in.
 * 1_3: Den fördubblas från 4 till 8 , 16, 32.
 * 1_4: Vet inte.
 * 1_5: Nej
 * 1_6: När vi vet hur många element den kommer innehålla.
 */



    internal class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\tPlease navigate through the menu by inputting the number \n\t(1, 2, 3 ,4, 0) of your choice"
                    + "\n\t1.\t Examine a List"
                    + "\n\t2.\t Examine a Queue"
                    + "\n\t3.\t Examine a Stack"
                    + "\n\t4.\t CheckParanthesis"
                    + "\n\t0.\t Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    Console.Write("\t"); input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("\t Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            Console.Clear();
            List<string> theList = new List<string>();
            while (true)
            {
                
                Console.WriteLine("\n\tPlease enter + or - followed by a Name to either add or remove the Name from a list:"
                   + "\n\t+Name\tAdds a Name to the list."
                   + "\n\t-Name\tRemoves a Name from the list."
                   + "\n\t0\tTo go back to main menu.");

                Console.Write("\t"); string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        Console.WriteLine($"\n\tYou added {value} to the list.");
                        theList.Add(value);
                        Console.Write("\t"); foreach (var item in theList) Console.Write($"{item}. ");
                        break;
                    case '-':
                        Console.WriteLine($"\n\tYou removed {value} from the list.");
                        theList.Remove(value);
                        Console.Write("\t"); foreach (var item in theList) Console.Write($"{item}. ");
                        break;
                    case '0':
                        Console.WriteLine("\n\tBack to main menu choosen\n");
                        return;
                    default:
                        Console.WriteLine("\n\tPlease enter a valid input (+ or - followed by Name, or  0 for main manu.)");
                        break;
                }
                Console.WriteLine($"\n\tCapacity Is: {theList.Capacity}");

            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Console.Clear();
            Queue<string> theLine = new Queue<string>();
            while (true)
            {
                Console.WriteLine("\n\tPlease choose one of the options:"
                   + "\n\t+ \tTo add a person to the que."
                   + "\n\t- \tTo  remove the first person in the queue."
                   + "\n\t0 \tTo go Back to main menu.");

                Console.Write("\t"); string input = Console.ReadLine();
                char nav = input[0];


                switch (nav)
                {
                    case '+':
                        Console.WriteLine("\n\tEnter name of person that enters queue:");
                        Console.Write("\t"); string name = Console.ReadLine();
                        theLine.Enqueue(name);
                        Console.Write("\tIn Queue are: ");
                        Console.Write("\t"); foreach (var item in theLine) Console.Write($"{ item}. ");
                        Console.WriteLine("");
                        break;
                    case '-':
                        theLine.Dequeue();
                        Console.WriteLine($"\n\tYou removed the first person from the que.");
                        Console.Write("\tIn Queue are: ");
                        Console.Write("\t"); foreach (var item in theLine) Console.Write($"{item}. ");
                        Console.WriteLine("");
                        break;
                    case '0':
                        Console.WriteLine("\n\tBack to main menu choosen\n");
                        return;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Console.Clear();

            while (true)
            {
                Console.WriteLine("\n\t Please choose one of the options:"
                   + "\n\t 1 \t To enter a string that will be reverssed."
                   + "\n\t 0 \t To go Back to main menu.");

                Console.Write("\t "); string input = Console.ReadLine();
                char nav = input[0];

                switch (nav)
                {
                    case '1':
                        Console.WriteLine("\n \t Enter the string to be reversed:");
                        Console.Write("\t "); string text = Console.ReadLine();
                        string reversedText = new string(text.Reverse().ToArray());

                        Console.WriteLine($"\t {reversedText}");

                        break;
                    case '0':
                        Console.WriteLine("\nBack to main menu chosen\n");
                        return;
                    default:
                        Console.WriteLine("");
                        break;
                }

            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Console.Clear();

            while (true)
            {
                Console.WriteLine("\n\t Please choose one of the options:"
                   + "\n\t 1 \tTo enter a string with parantheses, () [] {}, and check if parentheses are balanced." +
                   "\n\t\tThat is if the nr of left and right paretheses match and are in the right order." +
                   
                   "\n\t 0 \tTo go Back to main menu.");

                Console.Write("\t "); string input = Console.ReadLine();
                char nav = input[0];

                switch (nav)
                {
                    case '1':
                        Console.WriteLine("\n \t Enter a string with some parentheses:");
                        Console.Write("\t "); string text2 = Console.ReadLine();

                        int NP = 0;
                        int CP = 0;
                        int SP = 0;
                        bool parenthesesUnbalanced = false;
                        foreach (var c in text2)
                        {
                            if (c.Equals('('))
                            { NP = NP + 1; }
                            else if (c.Equals(')'))
                            { NP = NP - 1; }

                            else if (c.Equals('{'))
                            { CP = CP + 1; }
                            else if (c.Equals('}'))
                            { CP = CP - 1; }

                            else if (c.Equals('['))
                            { SP = SP + 1; }
                            else if (c.Equals(']'))
                            { SP = SP - 1; }

                            if (NP < 0 || CP < 0 || SP < 0)
                            {
                                parenthesesUnbalanced = true;
                                break;
                            }
                        }
                        if (parenthesesUnbalanced == true)
                        { Console.WriteLine("Parentheses are unbalanced"); }

                        else if (NP == 0 && CP == 0 && SP == 0)
                        {
                            Console.WriteLine("Parentheses are balanced");
                        }
                        else Console.WriteLine("Parentheses are unbalanced");

                        //Console.WriteLine($"NP={NP}, Cp={CP}, SP={SP}");

                        break;

                    case '0':
                        Console.WriteLine("\nBack to main menu chosen\n");
                        return;
                    default:
                        Console.WriteLine("");

                        break;

                }

            }



        }


    
    }
}