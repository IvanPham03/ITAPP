using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PlayerDTO
    {
        public PlayerDTO() { }
        public string PLAYERNAME { get; set; }
        public string PLAYERID { get; set; }
        public bool CAPTAIN { get; set; }
        public string DOB { get; set; }
        public string TEAMID { get; set; }
        public string PHONE { get; set; }
    }
}
