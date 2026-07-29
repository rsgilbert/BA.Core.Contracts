using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums;

    public enum SalesDocumentType 
    {
        Quote,
        Order,
        Invoice,


        [Display(Name = "Credit Memo")]
        CreditMemo
    }
