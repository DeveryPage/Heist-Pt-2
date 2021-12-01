using System;
using System.Collections.Generic;

namespace Heist_Pt_2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGaurdScore { get; set; }
        public bool IsSecure = true;
    }
}