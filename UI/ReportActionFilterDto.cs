using BA.Core.Contracts.Enums;


namespace BA.Core.Contracts.UI;


public class ReportActionFilterDto
{
    public DialogFilterType FilterType { get; set; }

    public required string FieldName { get; set; }

    public string? RelatedFieldName { get; set; }

    public FilterOperator Operator { get; set; }

    public string? ConstantValue { get; set; }
}
