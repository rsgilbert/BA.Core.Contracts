using System.ComponentModel.DataAnnotations;

namespace Contracts.Enums;


public enum SalesLineType
{
    None,


    [Display(Name = "GL")]
    GLAccount,
    
    Item,


    Resource,


    [Display(Name = "Fixed Asset")]
    FixedAsset
}