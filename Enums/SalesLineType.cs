using System.ComponentModel.DataAnnotations;

namespace BA.Core.Contracts.Enums;


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