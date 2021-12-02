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
        public Bank(int cashOnHand, int alarmScore, int vaultScore, int securityGaurdScore, bool isSecure)
        {
            CashOnHand = cashOnHand;
            AlarmScore = alarmScore;
            VaultScore = vaultScore;
            SecurityGaurdScore = securityGaurdScore;
            IsSecure = isSecure;
        }
        public string MostSecure()
        {
            if (SecurityGaurdScore < VaultScore && VaultScore > AlarmScore)
            {
                return "Vault";
            }
            else if (SecurityGaurdScore < AlarmScore && AlarmScore > VaultScore)
            {
                return "Alarm";
            }
            else
            {
                return "Security Guard";
            }
        }
        public string LeastSecure()
        {
            if (SecurityGaurdScore > VaultScore && VaultScore < AlarmScore)
            {
                return "Vault";
            }
            else if (SecurityGaurdScore > AlarmScore && AlarmScore < VaultScore)
            {
                return "Alarm";
            }
            else
            {
                return "Security Guard";
            }
        }
    }
}