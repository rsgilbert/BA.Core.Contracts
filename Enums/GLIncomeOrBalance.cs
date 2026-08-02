using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums
{
    public enum GLIncomeOrBalance
    {
        [Display(Name = "Balance Sheet")]
        BalanceSheet,


        [Display(Name = "Income Statement")]
        IncomeStatement,



    }
}