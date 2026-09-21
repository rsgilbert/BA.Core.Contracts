
using BA.Core.Contracts.Enums;


namespace BA.Core.Contracts.UI;



public class DialogPageFilterDto
{

    public DialogFilterType FilterType { get; set; }


    /// <summary>
    /// Field on the current page when FilterType is Field.
    /// </summary>
    public required string RelatedFieldName { get; set; }



    public FilterOperator Operator { get; set; }


    // used when FilterType is Constant
    public string? ConstantValue { get; set; }


    /// <summary>
    /// Field on the dialog page being filtered.
    /// </summary>
    public string? FieldName { get; set; }


    
}