using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Payment
    {
        public Payment()
        {

        }   
        
        protected void Spinner()
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

        public abstract void ProcessPayment(double cost);
        public abstract void DisplayPaymentDescription();        
    }
}