using System;
using System.Collections.Generic;

namespace ExceptionHandling6_1
{
    class Character
    {
        public List<string> defaultClassNames = new List<string>
        {"Warlock", "Barbarian", "Wizard", "Ranger", "Bard" };

        private string characterClass;
        public string CharacterName { get; set; }
        private double characterHealth;
        private double characterMagic;

        public double CharacterHealth
        {
            get
            {
                return characterHealth;
            }
            set
            {
                if (characterHealth < 0 || characterHealth > 100)
                {
                    throw new GameExceptionDefaultHealth($"{CharacterName ?? "Hero"}'s default health must be between 0 and 100");
                }
                else
                {
                    characterHealth = value;
                }
            }
        }

        public double CharacterMagic
        {
            get
            {
                return characterMagic;
            }
            set
            {
                if (characterMagic < 0 || characterMagic > 100)
                {
                    throw new GameExceptionDefaultHealth($"{CharacterName ?? "Hero"}'s default magic must be between 0 and 100");
                }
                else
                {
                    characterMagic = value;
                }
            }
        }

        public string CharacterClass
        {
            get
            {
                return characterClass;
            }
            set 
            {
                if (value != defaultClassNames[0] || value != defaultClassNames[1] || value != defaultClassNames[2] || value != defaultClassNames[3] || value != defaultClassNames[4])
                {
                    throw new GameExceptionsClassName($"{CharacterName ?? "Hero"}'s Class Name must be one of the 5 names");
                }
                else
                {
                    characterClass = value;
                }
            }
        }

        public void DisplayClassNames()
        {
            foreach (string className in defaultClassNames)
            {
                Console.WriteLine(className);
            }
        }

        public void DisplayClassNamesWithNumber()
        {
                for (int x = 0; x < defaultClassNames.Count; x++)
                {
                    Console.WriteLine($"{x}: {defaultClassNames[x]}");
                }
                
           
        }

        public void RunClassNames()
        {
            bool validClassName = false;
            int userInput;
            do
            {
                DisplayClassNamesWithNumber();
                Console.WriteLine("Enter Character Class number:");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < 0 || userInput > 5)
                    {
                        throw new GameExceptionsClassName();
                    }
                    characterClass = defaultClassNames[userInput];
                    validClassName = true;
                }
                catch (GameExceptionsClassName ex)
                {
                    Console.WriteLine("Must choose a valid given value");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured");
                    Console.WriteLine(ex.Message);
                }
                    { }
            }while (validClassName == false);
        }

        public void VerifyIfUserWantsClass()
        {
            string yesOrNoInput;
            Console.WriteLine($"Do you accept {CharacterClass} as your class\nyes or no");
            yesOrNoInput = Console.ReadLine();
            if (yesOrNoInput == "yes" || yesOrNoInput == "Yes")
            {
                
            }
            else if (yesOrNoInput == "no" || yesOrNoInput == "No")
            {
                RunClassNames();
                VerifyIfUserWantsClass();
            }
            else
            {
                Console.WriteLine("Invalid response");
                VerifyIfUserWantsClass();
            }
        }

        public void ChooseName()
        {
            string yesOrNoInput;
            Console.WriteLine("Enter your Character Name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"Do you accept {CharacterName} as your name\nyes or no");
            yesOrNoInput = Console.ReadLine();
            if (yesOrNoInput == "yes" || yesOrNoInput == "Yes")
            {

            }
            else if (yesOrNoInput == "no" || yesOrNoInput == "No")
            {
                ChooseName();
            }
            else
            {
                Console.WriteLine("Invalid response");
                ChooseName();
            }

        }

        public void VerifyName()
        {
            //ADD HEREs
        }

        public override string ToString() =>
            $"Character Class: {characterClass}\nCharacter Name: {CharacterName}\nHealth: {characterHealth}\nMagic: {characterMagic}";
    }
}
