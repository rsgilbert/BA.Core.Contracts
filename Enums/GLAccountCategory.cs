using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums;

public enum GLAccountCategory
{
    Assets,
    Liabilities,
    Equity,
    Income,


    [Display(Name = "COGS")]
    CostOfGoodsSold,
    
    Expense
}

