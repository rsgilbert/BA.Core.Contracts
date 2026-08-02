using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums;


public enum DocumentStatus
{
    Open,
    
    [Display(Name = "Pending Approval")]
    PendingApproval,
    Rejected,
    Released
}