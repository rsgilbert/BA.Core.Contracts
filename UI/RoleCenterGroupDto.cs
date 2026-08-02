using System.ComponentModel.DataAnnotations;
namespace BA.Core.Contracts.UI;


public class RoleCenterGroupDto
{

    public required string Name { get; set; }


    public string? Description { get; set; }


    [MinLength(1)]
    public required List<RoleCenterGroupItemDto> Items { get; set; }


}