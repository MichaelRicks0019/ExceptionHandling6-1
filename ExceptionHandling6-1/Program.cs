using System;

namespace ExceptionHandling6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            character.RunClassNames();
            character.VerifyIfUserWantsClass();
            character.CharacterHealth = 68;
            character.CharacterMagic = 100;
            character.ChooseName();

            Console.WriteLine(character);
            

        }
    }
}
