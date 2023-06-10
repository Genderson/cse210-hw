using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public static class DisplayHelper
    {
        public static void ReverseTimer(int seconds)
        {
            for(int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public static void Spinner()
        {
            List<string> animationCharacters = new List<string>();
            animationCharacters.Add("|");
            animationCharacters.Add("/");
            animationCharacters.Add("-");
            animationCharacters.Add("\\");
            animationCharacters.Add("|");
            animationCharacters.Add("/");
            animationCharacters.Add("-");
            animationCharacters.Add("\\");

            foreach(string animationCharacter in animationCharacters)
            {
                Console.Write(animationCharacter);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }   
        }
    }
}