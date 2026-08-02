using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums;

    public enum SalesDocumentType 
    {
        Quote,
        Order,
        Invoice,


        [Display(Name = "Credit Memo")]
        CreditMemo
    }
