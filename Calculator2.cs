using System;
using System.Globalization;



class Program
{
    public static void Main(string[] args)
    {
        ConsoleColor ccolor = new ConsoleColor();
        Console.Clear();
        
        do
        {


            Console.WriteLine("Welcome to Calculator 1.0");
            Console.WriteLine("Commands: operations, run, end, textcolor, clear, backcolor, info, updates");
            string command = Console.ReadLine();
            string uppercommand = command.ToUpper();

            switch(uppercommand)
            {
                case "RUN":
                    math.Calc();
                    break;

                case "UPDATE":
                case "UPDATES":
                case "NEW":
                    Console.WriteLine("1.0 Update : Creation of the Program using if statments for everything.\n");
                    Console.WriteLine("1.1 Update : Getting rid of almost all of the if statments, not the annoying ones. As well as changing all commands to upper case. Added update command. Added easter eggs. Added bug fixes as well as quaility of life aditions. Finally changed colors to numbers to make it easyer.\n");
                    Console.WriteLine("1.2 Update : Who knows because I dont.\n");
                    break;
                case "INFO":
                    Console.WriteLine("This is a Calculator project I made to practice c#, this is my first project. There are some things I may add in the future hense the name Calculator 1.1. Thanks for checking out my project feel free to let me know changes I should make. Checkout updates for new aditions.");

                    break;

                case "OPERATIONS":
                case "OPERATION":
                    Console.WriteLine("add to add, sub to subtract, div to divide, mul to multiply, max to find the greatest number, min to find the lowest number, sqr to find the square root, rnd to round, dou to square a number, rem to find the reminder of a divison equation");
                    break;

                case "CLEAR":
                    Console.Clear();
                    break;

                case "END":
                case "STOP":
                    Console.WriteLine("Shuting Down...");
                    goto exit_loop;

               
                case "EASTER EGGS":
                case "EASTEREGG":
                case "EASTER EGG":
                case "EASTEREGGS":
                    Console.WriteLine("The curent easter eggs are :\n");
                    Console.WriteLine("Anthony :\n");
                    Console.WriteLine("Sam\n");
                    Console.WriteLine("Quiz\n");
                    Console.WriteLine("When you set your back color to white\n");
                    Console.WriteLine("Sixnine, only do once you picked a text color");

                    break;
                case "ANT":
                case "NOTANT":
                case "ANTHONY":
                    Console.WriteLine("A very sexy man who is my friend he also likes c#");
                    break;

                case "SAM":
                case "SCHERSO":
                    Console.WriteLine("Rando who likes Java a nd thinks he is smart");
                    break;
                case "SIXNINE":
                case "SIX NINE":

                    for (int p = 0; p < 150; p++)
                    {
                        Console.WriteLine("Write a color to switch the backround too: ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Funny");
                        Console.ForegroundColor = ccolor;
                    }
                    break;
                case "QUIZ":
                    Console.WriteLine("How much are you like sky\n");
                    Console.WriteLine(" Do you have ADHD or extreme amounts of energy all the time?");
                    string awnser = Console.ReadLine();
                    string awnser1 = awnser.ToUpper();
                    if (awnser1 == "YES" || awnser1 == "YA" || awnser1 == "Y")
                    {

                        Console.WriteLine(" Do you like coding, but never get around to it?");
                    string awnser2 = Console.ReadLine();
                        string awnser3 = awnser2.ToUpper();
                        if (awnser3 == "YES" || awnser3 == "YA" || awnser3 == "Y")
                        {
                            question.Awn();
                        }
                        else
                        {
                            Console.WriteLine("You are 10 precent Sky");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are 0 precent Sky");
                    }
                    break;
            }
            if (uppercommand == "BACKCOLOR" || uppercommand == "BACK COLOR")
            {
                Console.WriteLine("Write a color to switch the backround too: ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Black = 0");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue = 9");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cyan = 11");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Dark Blue = 1");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Dark Cyan = 3");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Dark Gray = 8");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Dark Green = 2");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Dark Magenta = 5");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Dark Red = 4");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Dark Yellow = 6");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Gray = 7");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green = 10");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Magenta = 13");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red = 12");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("White = 15");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow = 14");
                Console.ForegroundColor = ccolor;
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                string inp = Console.ReadLine();
                int i = Int32.Parse(inp);
                Console.BackgroundColor = colors[i];

            }
            else if (uppercommand == "TEXTCOLOR" || uppercommand == "TEXT COLOR")
            {
                Console.WriteLine("Write a color to switch the backround too: ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Black = 0");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue = 9");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cyan = 11");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Dark Blue = 1");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Dark Cyan = 3");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Dark Gray = 8");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Dark Green = 2");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Dark Magenta = 5");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Dark Red = 4");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Dark Yellow = 6");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Gray = 7");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green = 10");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Magenta = 13");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red = 12");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("White = 15");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow = 14");
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                string inp = Console.ReadLine();
                int i = Int32.Parse(inp);
                Console.ForegroundColor = colors[i];
                ccolor = colors[i];
            }

        } while (1 == 1);
    exit_loop:;

    }
}
class math
{
    public static void Calc()
    {
        string ch = "";
 
        Console.WriteLine("\n\n\nMath");
        Console.WriteLine(" __________\n");
        Console.WriteLine("| ________ |\n");
        Console.WriteLine("||12345678||\n");
        Console.WriteLine("|\"\"\"\"\"\"\"\"\"\"|\n");
        Console.WriteLine("|[^|#|C][-]|\n");
        Console.WriteLine("|[7|8|9][+]|\n");
        Console.WriteLine("|[4|5|6][x]|\n");
        Console.WriteLine("|[1|2|3][>]|\n");
        Console.WriteLine("|[.|O|$][=]|\n");
        Console.WriteLine("\"----------\"\n\n\n");
        do
        {
            Console.WriteLine("\nEnter First Number");
            string num1 = Console.ReadLine();
            Console.WriteLine("\nEnter A Operation!");
            string op = Console.ReadLine();
            string op1 = op.ToUpper();
            if (op1 == "SQR")
            {
                float num3 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);


                Console.WriteLine("\n");
                Console.WriteLine(Math.Sqrt(num3));
            }
            else if (op1 == "RND")
            {
                float num3 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);



                Console.WriteLine(Math.Round(num3));
            }
            else if (op1 == "DOU" || op1 == "^")
            {
                float num3 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);


                double num5 = num3 * num3;
                Console.WriteLine(num5);
            }
            else
            {
                Console.WriteLine("\nEnter Second Number");
                string num2 = Console.ReadLine();
                switch (op1)
                {
                    case "ADD":
                    case "+":
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num5 = num3 + num4;
                        Console.WriteLine(num5);
                        break;
                    case "SUB":
                    case "-":
                        float num6 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num7 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num8 = num6 - num7;
                        Console.WriteLine(num8);
                        break;
                    case "MUL":
                    case "*":
                        float num9 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num10 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        float num11 = num9 * num10;
                        Console.WriteLine(num11);
                        break;
                    case "DIV":
                    case "/":
                        float num12 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num13 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        float num14 = num12 / num13;
                        Console.WriteLine(num14);
                        break;
                    case "MAX":
                    case "<":
                        float num15 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num16 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);


                        Console.WriteLine(Math.Max(num15, num16));
                        break;
                    case "MIN":
                    case ">":
                        float num17 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num18 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        Console.WriteLine(Math.Min(num17, num18));
                        break;
                    case "REM":
                    case "%":
                        float num19 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num20 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        float num21 = num19 % num20;
                        Console.WriteLine(num21);
                        break;
                    default:
                        Console.WriteLine("You Enterd A non Acceptable Operator\n\n");
      break;
                }



            }
            Console.WriteLine("Do you want to repeat the Program");
            ch = Console.ReadLine();

        }
        while (ch == "yes" || ch == "Yes" || ch == "y" || ch == "Y");
    }
}


class question
{
    public static void Awn()
    {
        Console.WriteLine(" Have you ever spent more then 5 minutes under a staircase?");
                    string awnser4 = Console.ReadLine();
        string awnser5 = awnser4.ToUpper();
        if (awnser5 == "YES" || awnser5 == "YA" || awnser5 == "Y")
        {
            Console.WriteLine(" Do you grind Hypixel Skyblock?");
                    string awnser6 = Console.ReadLine();
            string awnser7 = awnser6.ToUpper();
            if (awnser7 == "YES" || awnser7 == "YA" || awnser7 == "Y")
            {
                Console.WriteLine(" Do you like taking two showers a day?");
                    string awnser8 = Console.ReadLine();
                string awnser9 = awnser8.ToUpper();
                if (awnser9 == "YES" || awnser9 == "YA" || awnser9 == "Y")
                {
                    Console.WriteLine(" Do you make random goblin sounds?");
                    string awnser13 = Console.ReadLine();
                    string awnser10 = awnser13.ToUpper();
                    if (awnser10 == "YES" || awnser10 == "YA" || awnser10 == "Y")
                    {
                        Console.WriteLine(" Do you have bad posture?");
                         string awnser11 = Console.ReadLine();
                        string awnser12 = awnser11.ToUpper();
                        if (awnser12 == "YES" || awnser12 == "YA" || awnser12 == "Y")
                        {
                            Console.WriteLine(" Do you like wearing cat ears or praticapting as an animal?");
                    string awnser14 = Console.ReadLine();
                            string awnser15 = awnser14.ToUpper();
                            if (awnser15 == "YES" || awnser15 == "YA" || awnser15 == "Y")
                            {
                                Console.WriteLine(" Do you like pepole with long rainbow hair or peppole who like unicorns?");
                    string awnser16 = Console.ReadLine();
                                string awnser17 = awnser16.ToUpper();
                                if (awnser17 == "YES" || awnser17 == "YA" || awnser17 == "Y")
                                {
                                    Console.WriteLine("Do you hate centipedes?");
                    string awnser18 = Console.ReadLine();
                                    string awnser19 = awnser18.ToUpper();
                                    if (awnser19 == "YES" || awnser19 == "YA" || awnser19 == "Y")
                                    {
                                        Console.WriteLine("You are ethier Sky or need therapy...\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You are 99 precent Sky");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You are 90 precent Sky");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You are 80 precent Sky");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You are 70 precent Sky");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are 60 precent Sky");
                    }
                }
                else
                {
                    Console.WriteLine("You are 50 precent Sky");
                }
            }
            else
            {
                Console.WriteLine("You are 40 precent Sky");
            }
        }
        else
        {
            Console.WriteLine("You are 30 precent Sky");
        }
    }
}


