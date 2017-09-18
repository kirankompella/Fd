using System;

namespace FdApi.Interfaces
{
    public interface Investment
    {
        string InvestmentId { get; set; } 
        float InvestmentAmount { get; set; }
        DateTime InvestmentDate { get; set; }
        DateTime MaturityDate { get; set; }
        float MaturityAmount { get; set; }
        string InvestedBy { get; set; } 
        string NominatedTo { get; set; }
        float RateOfIntrest { get; set; }
        string InvestmentType { get; set; }
        bool IsMarketLineked {get; set;}
    }
}