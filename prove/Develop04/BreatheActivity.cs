using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class BreatheActivity : Activity
    {
        public BreatheActivity(string name, string description) : base(name, description){}

        public string DisplayBreatheInMessage() => "Breathe in ...";

        public string DisplayBreatheOutMessage() => "Now Breathe out ...";
    }
}