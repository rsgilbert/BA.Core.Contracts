using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Contracts.Enums;


namespace Contracts.UI;



public class PageDto
{

    public required int PageId { get; set; }

    public string? Name { get; set; }


    public string? Caption { get; set; }



    public required string SourceTable { get; set; }

    public bool? Editable { get; set; } 

    public bool? DeleteAllowed { get; set; } 

    public bool? InsertAllowed { get; set; } 

    public bool? ModifyAllowed { get; set; } 


    public PageType PageType { get; set; }

    public int? CardPageId { get; set; }

    public List<PageOrderDto> PageOrders { get; set; } = [];

    public List<PageFilterDto> PageFilters { get; set; } = [];

    public List<PageControlDto> PageControls { get; set; } = [];


    public List<PageActionDto> PageActions { get; set; } = [];




  

}