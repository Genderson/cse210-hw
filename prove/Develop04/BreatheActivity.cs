using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class BreatheActivity : Activity
    {
        public BreatheActivity(string name, string description) : base(name, description){}

        public string DisplayBreatheInMessage(){
            return "Please";
        }

        public string DisplayBreatheOutMessage(){
            return "Done";
        }
    }
}