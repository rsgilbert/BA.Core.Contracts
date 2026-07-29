using System.ComponentModel.DataAnnotations;
namespace Contracts.UI;


public class RoleCenterGroupDto
{

    public required string Name { get; set; }


    public string? Description { get; set; }


    [MinLength(1)]
    public required List<RoleCenterGroupItemDto> Items { get; set; }


}