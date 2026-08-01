using System.ComponentModel.DataAnnotations;
namespace Contracts.UI;


public class RoleCenterDto
{


    public required int Id { get; set; }



    public required string Name { get; set; }



    public string? Caption { get; set; }



    [MinLength(1)]
    public required List<RoleCenterGroupDto> Groups { get; set; }




}

