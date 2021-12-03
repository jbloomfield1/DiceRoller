using System;

namespace DiceRoller
{
    class Roller
    {

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = SettingOptions.SettingMenu();
            }
        }

        static class SettingOptions
        {
            public static string? setting;
            public static bool SettingMenu()
            {
                Console.Clear();
                Console.WriteLine("\rWelcom to Dice Roller!");
                Console.WriteLine("======================");
                Console.WriteLine("\r\nEnter the roller mode:");
                Console.WriteLine("     f) Full dice options (default)");
                Console.WriteLine("     h) Single D20 (roll to hit, save or for skill check)");
                Console.WriteLine("     a) Roll 2 D20s with advantage");
                Console.WriteLine("     d) Roll 2 D20s with disadvantage");
                Console.WriteLine("     o) Single D100");
                Console.WriteLine("     p) Percentage D10 x D10");
                Console.WriteLine("     r) Return to the main menu");
                Console.WriteLine("     q) Exit dice roller");
                Console.WriteLine("\r");
                switch (Console.ReadLine())
                {
                    case "f":
                        setting = "full";
                        MainMenu();
                        return true;
                    case "h":
                        setting = "D20";
                        MainMenu();
                        return true;
                    case "a":
                        setting = "advantage";
                        MainMenu();
                        return true;
                    case "d":
                        setting = "disadvantage";
                        MainMenu();
                        return true;
                    case "o":
                        setting = "D100";
                        MainMenu();
                        return true;
                    case "p":
                        setting = "percentage";
                        MainMenu();
                        return true;
                    case "r":
                        if (setting == null)
                        {
                            setting = "full";
                        }
                        MainMenu();
                        return true;
                    case "q":
                        Environment.Exit(0);
                        return false;
                    default:
                        setting = "full";
                        SettingMenu();
                        return true;
                }
            }
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Roller set to " + SettingOptions.setting);
            Console.WriteLine("\r     r) Roll some dice");
            Console.WriteLine("     s) Set roller mode");
            Console.WriteLine("     q) Exit Dice Roller");
            Console.WriteLine("\r\nSelect an option and press ENTER: ");
            switch (Console.ReadLine())
            {
                case "r":
                    switch (SettingOptions.setting)
                    {
                        case "full":
                            FullRoller();
                            break;
                        case "D20":
                            HCSd20Roller();
                            break;
                        case "advantage":
                            AdvantageRoller();
                            break;
                        case "disadvantage":
                            DisadvantageRoller();
                            break;
                        case "D100":
                            PercentageRoller();
                            break;
                        case "percentage":
                            NewPercentageRoller();
                            break;
                    }
                    break;
                case "s":
                    SettingOptions.SettingMenu();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    MainMenu();
                    break;
            }
        }

        public static void FullRoller()
        {
            int d4count;
            int d4 = 0;
            int d4total = 0;

            int d6count;
            int d6 = 0;
            int d6total = 0;

            int d8count;
            int d8 = 0;
            int d8total = 0;

            int d10count;
            int d10 = 0;
            int d10total = 0;

            int d12count;
            int d12 = 0;
            int d12total = 0;

            int d20count;
            int d20 = 0;
            int d20total = 0;

            int d100count;
            int d100 = 0;
            int d100total = 0;

            Console.Clear();

        D4tag:
            Console.WriteLine("\r****  D4  ****");
            Console.WriteLine("Enter the number of D4 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d4count))
            {
                if (d4count != 0)
                {
                    d4count = Convert.ToInt32(d4count);
                    Console.WriteLine("\r");
                    do
                    {
                        d4++;
                        Random rnd = new Random();
                        int d4rando = rnd.Next(1, 4);
                        Console.WriteLine("D4 Number " + d4 + " rolled: " + d4rando);
                        d4total = d4total + d4rando;
                    }
                    while (d4 < d4count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D4tag;
            }

        D6tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D6  ****");
            Console.WriteLine("Enter the number of D6 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d6count))
            {
                if (d6count != 0)
                {
                    d6count = Convert.ToInt32(d6count);
                    Console.WriteLine("\r");
                    do
                    {
                        d6++;
                        Random rnd = new Random();
                        int d6rando = rnd.Next(1, 6);
                        Console.WriteLine("D6 Number " + d6 + " rolled: " + d6rando);
                        d6total = d6total + d6rando;
                    }
                    while (d6 < d6count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D6tag;
            }

        D8tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D8  ****");
            Console.WriteLine("Enter the number of D8 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d8count))
            {
                if (d8count != 0)
                {
                    d8count = Convert.ToInt32(d8count);
                    Console.WriteLine("\r");
                    do
                    {
                        d8++;
                        Random rnd = new Random();
                        int d8rando = rnd.Next(1, 8);
                        Console.WriteLine("D8 Number " + d8 + " rolled: " + d8rando);
                        d8total = d8total + d8rando;
                    }
                    while (d8 < d8count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D8tag;
            }

        D10tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D10  ****");
            Console.WriteLine("Enter the number of D10 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d10count))
            {
                if (d10count != 0)
                {
                    d10count = Convert.ToInt32(d10count);
                    Console.WriteLine("\r");
                    do
                    {
                        d10++;
                        Random rnd = new Random();
                        int d10rando = rnd.Next(1, 10);
                        Console.WriteLine("D10 Number " + d10 + " rolled: " + d10rando);
                        d10total = d10total + d10rando;
                    }
                    while (d10 < d10count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D10tag;
            }

        D12tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D12  ****");
            Console.WriteLine("Enter the number of D12 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d12count))
            {
                if (d12count != 0)
                {
                    d12count = Convert.ToInt32(d12count);
                    Console.WriteLine("\r");
                    do
                    {
                        d12++;
                        Random rnd = new Random();
                        int d12rando = rnd.Next(1, 12);
                        Console.WriteLine("D12 Number " + d12 + " rolled: " + d12rando);
                        d12total = d12total + d12rando;
                    }
                    while (d12 < d12count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D12tag;
            }

        D20tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D20  ****");
            Console.WriteLine("Enter the number of D20 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d20count))
            {
                if (d20count != 0)
                {
                    d20count = Convert.ToInt32(d20count);
                    Console.WriteLine("\r");
                    do
                    {
                        d20++;
                        Random rnd = new Random();
                        int d20rando = rnd.Next(1, 20);
                        Console.WriteLine("D20 Number " + d20 + " rolled: " + d20rando);
                        d20total = d20total + d20rando;
                    }
                    while (d20 < d20count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D20tag;
            }

        D100tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D100  ****");
            Console.WriteLine("Enter the number of D100 dice to roll (0 - 9)");
            if (int.TryParse(Console.ReadLine(), out d100count))
            {
                if (d100count != 0)
                {
                    d100count = Convert.ToInt32(d100count);
                    Console.WriteLine("\r");
                    do
                    {
                        d100++;
                        Random rnd = new Random();
                        int d100rando = rnd.Next(1, 100);
                        Console.WriteLine("D100 Number " + d100 + " rolled: " + d100rando);
                        d100total = d100total + d100rando;
                    }
                    while (d100 < d100count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D100tag;
            }

            int diceTotal = d4total + d6total + d8total + d10total + d12total + d20total + d100total;
            Console.WriteLine("\r");
            Console.WriteLine("\r=================");
            Console.WriteLine("Total Rolled: " + diceTotal);
            Console.WriteLine("=================");
            Console.WriteLine("\r\nPress any key to return");
            Console.ReadKey();
            MainMenu();
        }

        public static void HCSd20Roller()
        {

            int d20count = 1;
            int d20 = 0;
            int d20total = 0;


        D20tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D20  ****");
            Console.WriteLine("Press ENTER to roll");
            Console.ReadLine();
            if (d20count == 1)
            {
                if (d20count != 0)
                {
                    d20count = Convert.ToInt32(d20count);
                    Console.WriteLine("\r");
                    do
                    {
                        d20++;
                        Random rnd = new Random();
                        int d20rando = rnd.Next(1, 20);
                        d20total = d20total + d20rando;
                    }
                    while (d20 < d20count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D20tag;
            }
            int diceTotal = d20total;
            Console.WriteLine("\r");
            Console.WriteLine("\r=================");
            Console.WriteLine("Total Rolled: " + diceTotal);
            Console.WriteLine("=================");
            Console.WriteLine("\r\nPress any key to return");
            Console.ReadKey();
            MainMenu();
        }

        public static void AdvantageRoller()
        {

            int d20count = 2;
            int d20 = 0;
            int d20total = 0;
            int d20first = 0;
            int d20second = 0;

        D20tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D20 with Advantage  ****");
            Console.WriteLine("Press ENTER to roll");
            Console.ReadLine();
            if (d20count == 2)
            {
                if (d20count != 0)
                {
                    d20count = Convert.ToInt32(d20count);
                    Console.WriteLine("\r");
                    do
                    {
                        d20++;
                        Random rnd = new Random();
                        int d20rando = rnd.Next(1, 20);
                        Console.WriteLine("D20 Number " + d20 + " rolled: " + d20rando);
                        d20total = d20total + d20rando;
                        if (d20 == 1)
                        {
                            d20first = d20rando;
                        }
                        if (d20 == 2)
                        {
                            d20second = d20rando;
                        }
                    }
                    while (d20 < d20count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D20tag;
            }
            if (d20first >= d20second)
            {
                Console.WriteLine("\r");
                Console.WriteLine("\r=================");
                Console.WriteLine("Total Rolled: " + d20first);
                Console.WriteLine("=================");
                Console.WriteLine("\r\nPress any key to return");
                Console.ReadKey();
                MainMenu();
            }
            if (d20first < d20second)
            {
                Console.WriteLine("\r");
                Console.WriteLine("\r=================");
                Console.WriteLine("Total Rolled: " + d20second);
                Console.WriteLine("=================");
                Console.WriteLine("\r\nPress any key to return");
                Console.ReadKey();
                MainMenu();
            }
        }

        public static void DisadvantageRoller()
        {

            int d20count = 2;
            int d20 = 0;
            int d20total = 0;
            int d20first = 0;
            int d20second = 0;

        D20tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  D20 with Disadvantage  ****");
            Console.WriteLine("Press ENTER to roll");
            Console.ReadLine();
            if (d20count == 2)
            {
                if (d20count != 0)
                {
                    d20count = Convert.ToInt32(d20count);
                    Console.WriteLine("\r");
                    do
                    {
                        d20++;
                        Random rnd = new Random();
                        int d20rando = rnd.Next(1, 20);
                        Console.WriteLine("D20 Number " + d20 + " rolled: " + d20rando);
                        d20total = d20total + d20rando;
                        if (d20 == 1)
                        {
                            d20first = d20rando;
                        }
                        if (d20 == 2)
                        {
                            d20second = d20rando;
                        }
                    }
                    while (d20 < d20count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D20tag;
            }
            if (d20first <= d20second)
            {
                Console.WriteLine("\r");
                Console.WriteLine("\r=================");
                Console.WriteLine("Total Rolled: " + d20first);
                Console.WriteLine("=================");
                Console.WriteLine("\r\nPress any key to return");
                Console.ReadKey();
                MainMenu();
            }
            if (d20first > d20second)
            {
                Console.WriteLine("\r");
                Console.WriteLine("\r=================");
                Console.WriteLine("Total Rolled: " + d20second);
                Console.WriteLine("=================");
                Console.WriteLine("\r\nPress any key to return");
                Console.ReadKey();
                MainMenu();
            }
        }

        public static void PercentageRoller()
        {

            int d100count = 1;
            int d100 = 0;
            int d100total = 0;


        D100tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  Percentage D100  ****");
            Console.WriteLine("Press ENTER to roll");
            Console.ReadLine();
            if (d100count == 1)
            {
                if (d100count != 0)
                {
                    d100count = Convert.ToInt32(d100count);
                    Console.WriteLine("\r");
                    do
                    {
                        d100++;
                        Random rnd = new Random();
                        int d100rando = rnd.Next(1, 100);
                        d100total = d100total + d100rando;
                    }
                    while (d100 < d100count);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D100tag;
            }
            int diceTotal = d100total;
            Console.WriteLine("\r");
            Console.WriteLine("\r=================");
            Console.WriteLine("Total Rolled: " + diceTotal);
            Console.WriteLine("=================");
            Console.WriteLine("\r\nPress any key to return");
            Console.ReadKey();
            MainMenu();
        }


        public static void NewPercentageRoller()
        {

            int d10count = 2;
            int d10 = 0;
            int d10total = 0;
            int d10ones = 0;
            int d10tens = 0;

        D10tag:
            Console.WriteLine("\r");
            Console.WriteLine("****  Percentage (10 x 10)  ****");
            Console.WriteLine("Press ENTER to roll");
            Console.ReadLine();
            if (d10count == 2)
            {
                if (d10count != 0)
                {
                    d10count = Convert.ToInt32(d10count);
                    Console.WriteLine("\r");
                    do
                    {
                        d10++;
                        if (d10 == 1)
                        {
                            Random rnd = new Random();
                            int d10rando = rnd.Next(1, 10);
                            d10ones = d10rando;
                            Console.WriteLine("D10 (ones) rolled: " + d10ones);
                        }
                        if (d10 == 2)
                        {
                            Random rnd = new Random();
                            int d10rando = rnd.Next(1, 10);
                            d10tens = d10rando * 10;
                            Console.WriteLine("D10 (tens) rolled: " + d10tens);
                        }
                    }
                    while (d10 < d10count);
                    d10total = (d10ones + d10tens);
                }
            }
            else
            {
                Console.WriteLine("\r");
                Console.WriteLine("Enter a number between 0 and 9");
                goto D10tag;
            }
            Console.WriteLine("\r");
            Console.WriteLine("\r=================");
            Console.WriteLine("Total Rolled: " + d10total);
            Console.WriteLine("=================");
            Console.WriteLine("\r\nPress any key to return");
            Console.ReadKey();
            MainMenu();
        }
    }
}