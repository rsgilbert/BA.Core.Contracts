
using BA.Core.Contracts.Enums;


namespace BA.Core.Contracts.UI;



public class DialogPageFilterDto
{

    public DialogFilterType FilterType { get; set; }


    public required string RelatedFieldName { get; set; }



    public FilterOperator Operator { get; set; }


    // used when FilterType is Constant
    public string? ConstantValue { get; set; }


    // used when FilterType is Field
    public string? FieldName { get; set; }


    
}