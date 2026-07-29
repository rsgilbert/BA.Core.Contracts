using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums;


public enum LabRequestType
{
    [Display(Name = "Walk In")]
    WalkIn,


    [Display(Name = "Home Collection")]
    HomeCollection
}