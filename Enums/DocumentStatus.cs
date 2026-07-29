using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums;


public enum DocumentStatus
{
    Open,
    
    [Display(Name = "Pending Approval")]
    PendingApproval,
    Rejected,
    Released
}