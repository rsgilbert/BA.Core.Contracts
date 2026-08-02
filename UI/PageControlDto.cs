
using Contracts.Enums;

namespace Contracts.UI;



public class PageControlDto 
{

    public PageControlType ControlType { get; set; }

    public string? Name { get; set; }

    public bool? Editable { get; set; } 

    public bool? Visible { get; set; } 


    public string? Caption { get; set; }

    public bool? ShowCaption { get; set; } 

    public int? SubPageId { get; set; }

    public int? Columns { get;set; }


    public List<SubPageFilterDto> SubPageFilters { get; set; } = [];



    public List<PageControlFieldDto> Fields { get; set; } = [];


}