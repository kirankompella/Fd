using System;
using FdApi.Interfaces;

namespace FdApi.Models
{
    public class Fd : Investment
    {
        public string InvestmentId { get; set; } 
        public float InvestmentAmount { get; set; }
        public DateTime InvestmentDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public float MaturityAmount { get; set; }
        public string InvestedBy { get; set; } 
        public string NominatedTo { get; set; }
        public float RateOfIntrest { get; set; }
        public string InvestmentType { get; set; }
        public bool IsMarketLineked {get; set;}
    }
}