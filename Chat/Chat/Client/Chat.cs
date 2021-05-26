using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Client
{
    public class Chatt
    {
        public string Mymessage { get; set; }
        public string SimsMessage { get; set; }

    }
    //everychat

    public class FriendOne
    {
        public string OnesName { get; set; }
        public string OnesMessage { get; set; }
        public bool IsOneSpoken { get; set; }
    }

    public class FriendTwo
    {
        public string TwosName { get; set; }
        public string TwosMessage { get; set; }
        public bool IsTwoSpoken { get; set; }
    }

    public class FriendThree
    {
        public string ThreesName { get; set; }
        public string ThreesMessage { get; set; }
        public bool IsThreeSpoken { get; set; }
    }

}
