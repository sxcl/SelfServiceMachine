﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SelfServiceMachine.Entity.SResponse
{
    public class getClinicalTrial
    {
        public int resultCode { get; set; }
        public string resultMessage { get; set; }
        public string SSSerNum { get; set; }
        public string cardArea { get; set; }
        public string akc190 { get; set; }
    }
}
