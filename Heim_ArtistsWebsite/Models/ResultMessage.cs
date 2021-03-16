using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models
{
    public class ResultMessage
    {

        public string Header { get; set; }
        public string Messagetext { get; set; }
        public string Solution { get; set; }

        public ResultMessage() : this("","","") { }
        public ResultMessage(string header, string messagetext, string solution = "")
        {
            this.Header = header;
            this.Messagetext = messagetext;
            this.Solution = solution;
        }
    }
}
