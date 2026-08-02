using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BA.Core.Contracts.Enums;
namespace BA.Core.Contracts.UI;


public class RoleCenterGroupItemDto
{

    public required int? PageId { get; set; }


    public string? Name { get; set; }


    


}