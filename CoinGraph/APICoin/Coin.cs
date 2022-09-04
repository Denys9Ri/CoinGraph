using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace APICoin
{
    public class Coin
    {
        public DateTime timestamp { get; set; }
        public  int error_code { get; set; }
        public string error_message { get; set; }

    }
}
