using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums;

public enum GeneralJournalDocumentType
{
    [Display(Name = "None")]
    None,


    Payment,

  
    Invoice,


    [Display(Name = "Credit Memo")]
    CreditMemo,


    [Display(Name = "Finance Charge Memo")]
    FinanceChargeMemo,


    [Display(Name = "Reminder")]
    Reminder,

    Refund

}