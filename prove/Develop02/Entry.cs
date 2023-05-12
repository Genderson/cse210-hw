using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Entry
    {
        public string _response;
        public string _prompt;
        public string _date;

        public string Display(){
            return $"Date: {_date} - Prompt: {_prompt} - Response: {_response} \r\n";
        }
    }
}