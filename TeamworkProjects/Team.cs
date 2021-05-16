using System;
using System.Collections.Generic;
using System.Text;

namespace TeamworkProjects
{
    public class Team
    {
        public Team()
        {
            Members = new List<string>();
        }
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
