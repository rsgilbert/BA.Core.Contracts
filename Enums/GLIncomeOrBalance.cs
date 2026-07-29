using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums
{
    public enum GLIncomeOrBalance
    {
        [Display(Name = "Balance Sheet")]
        BalanceSheet,


        [Display(Name = "Income Statement")]
        IncomeStatement,



    }
}