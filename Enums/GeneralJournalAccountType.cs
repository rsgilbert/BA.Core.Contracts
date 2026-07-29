using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums;

public enum GeneralJournalAccountType
{
       [Display(Name = "GL")]
    GLAccount,

       [Display(Name = "Customer")]
    Customer,

     [Display(Name = "Vendor")]
    Vendor,

     [Display(Name = "Bank")]
    BankAccount,

     [Display(Name = "Fixed Asset")]
    FixedAsset,

  
    Employee

}