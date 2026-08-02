using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BA.Core.Contracts.Enums;

namespace BA.Core.Contracts.UI;



public class PageActionDto
{

    public PageActionType ActionType { get; set; }

    public required string Name { get; set; }

    public string? Caption { get; set; }

    public bool RequiresConfirmation { get; set; }

    public string? ConfirmationMessage { get; set; }

    public string? Tooltip { get; set; }


    public bool? Visible { get; set; } = true;

    public string? ImageUrl { get; set; }


    public int? DialogPageId { get;set; }


    public List<DialogPageFilterDto> DialogPageFilters { get;set; } = [];

    public string? ActionRelativeUrl
    {
        get;
        set
        {
            if (!string.IsNullOrEmpty(value) && value.StartsWith('/'))
            {
                throw new Exception($"ActionRelativeUrl {value} for page action {Name} should not start with a slash");
            }
            field = value;
        }
    }


}
